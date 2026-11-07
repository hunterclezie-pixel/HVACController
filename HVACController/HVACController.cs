using System.Globalization;
using System.IO.Ports;


namespace HVACController
{
    public partial class HVACController : Form
    {
        public HVACController()
        {
            InitializeComponent();
            projectFolder = GetProjectFolder();

            // Menu and communication events
            SaveSettingsStripMenuItem.Click += SaveSettingsStripMenuItem_Click;
            ExitStripMenuItem.Click += ExitStripMenuItem_Click;
            CommunicationSetupStripMenuItem.Click += CommunicationSetupStripMenuItem_Click;
            PortsComboBox.DropDown += PortsComboBox_DropDown;

            // Mode and simulation controls
            HeatRadioButton.CheckedChanged += ModeRadioButton_CheckedChanged;
            CoolRadioButton.CheckedChanged += ModeRadioButton_CheckedChanged;
            OffRadioButton.CheckedChanged += ModeRadioButton_CheckedChanged;
            FanOnCheckBox.CheckedChanged += FanOnCheckBox_CheckedChanged;
            SimulationCheckBox.CheckedChanged += SimulationCheckBox_CheckedChanged;
            SafetyCheckBox.CheckedChanged += SimulationInputChanged;
            PressureCheckBox.CheckedChanged += SimulationInputChanged;
            RoomTempNumericUpDown.ValueChanged += SimulationInputChanged;
            UnitTempNumericUpDown.ValueChanged += SimulationInputChanged;

            // The three physical-switch checkboxes are indicators, not extra inputs
            HeatSwitchCheckBox.AutoCheck = false;
            FanSwitchCheckBox.AutoCheck = false;
            CoolSwitchCheckBox.AutoCheck = false;

            // Start in real-board mode, with all outputs disabled
            SimulationCheckBox.Checked = false;
            OffRadioButton.Checked = true;
            SafetyCheckBox.Checked = false;
            PressureCheckBox.Checked = false;
            StopOutputs();
            LoadSettings();
            UpdatePortList();
            SetSimulationControls();
            UpdateSetpoints();
            UpdateDisplay();
            HVACTimer.Start();
            CommunicationTimer.Start();
        }

        // Global Variables Below Here -------------------------------------------------------
        Color GrowlGreyLight = Color.FromArgb(230, 231, 232);
        Color RoarangeL = Color.FromArgb(246, 146, 64);
        SerialPort boardPort = new SerialPort();
        bool boardConnected = false;

        // Keep this false until the external HVAC wiring is checked.
        // The code assumes active-HIGH DO1-DO5 outputs in direct mode.
        // The QY@ isolated outputs can be inverted.
        bool hardwareOutputsEnabled = false;
        bool boardSearching = false;
        bool autoConnect = true;
        bool closing = false;
        bool updatingDisplay = false;
        string selectedPort = "Auto";
        DateTime nextSearch = DateTime.MinValue;
        double heatSetpoint = 68.0;
        double coolSetpoint = 76.0;
        double roomTemperature = 70.0;
        double unitTemperature = 80.0;
        bool inputsValid = false;
        bool safetyHigh = false;
        bool pressureHigh = false;
        bool heatSwitch = false;
        bool coolSwitch = false;
        bool fanSwitch = false;

        // Logical outputs: DO1 through DO5
        bool warningOutput = false;
        bool heatOutput = false;
        bool fanOnlyOutput = false;
        bool fanOutput = false;
        bool coolOutput = false;
        bool heatDemand = false;
        bool coolDemand = false;
        bool pressureVerified = false;
        bool maintenanceFault = false;
        DateTime fanStarted = DateTime.MinValue;
        DateTime fanUntil = DateTime.MinValue;
        DateTime nextPressureCheck = DateTime.MinValue;
        DateTime nextTemperatureCheck = DateTime.MinValue;
        string currentFault = "";
        string projectFolder = "";

        // Methods Below Here --------------------------------------------------------------

        // Finds the Visual Studio project folder (or the application folder)
        string GetProjectFolder()
        {
            DirectoryInfo folder = new DirectoryInfo(Application.StartupPath);

            for (int i = 0; i < 6 && folder != null; i++)
            {
                if (folder.GetFiles("*.csproj").Length > 0)
                    return folder.FullName;

                folder = folder.Parent;
            }
            return Application.StartupPath;
        }

        // Saves the current settings to a text file in the project folder
        void SaveSettings(bool showMessage = true)
        {
            try
            {
                string fileName = Path.Combine(projectFolder, "HVAC Settings");
                string[] settings =
                {
                    "COM=" + selectedPort,
                    "Heat=" + heatSetpoint.ToString("F1", CultureInfo.InvariantCulture),
                    "Cool=" + coolSetpoint.ToString("F1", CultureInfo.InvariantCulture)
                };
                File.WriteAllLines(fileName, settings);

                if (showMessage)
                    MessageBox.Show("Settings saved to:\n" + fileName);
            }
            catch (Exception ex)
            {
                if (showMessage)
                    MessageBox.Show("Could not save settings: " + ex.Message);
            }
        }

        // Loads the settings from a text file in the project folder
        void LoadSettings()
        {
            string fileName = Path.Combine(projectFolder, "HVAC Settings");
            if (!File.Exists(fileName))
                return;

            try
            {
                foreach (string line in File.ReadAllLines(fileName))
                {
                    string[] parts = line.Split('=', 2);
                    if (parts.Length != 2)
                        continue;

                    if (parts[0] == "COM")
                        selectedPort = parts[1];

                    if (parts[0] == "Heat" && double.TryParse(parts[1], NumberStyles.Float,
                        CultureInfo.InvariantCulture, out double heat))
                        heatSetpoint = heat;

                    if (parts[0] == "Cool" && double.TryParse(parts[1], NumberStyles.Float,
                        CultureInfo.InvariantCulture, out double cool))
                        coolSetpoint = cool;
                }

                heatSetpoint = Math.Max(50, Math.Min(90, heatSetpoint));
                coolSetpoint = Math.Max(50, Math.Min(90, coolSetpoint));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load settings: " + ex.Message);
            }
        }

        // Updates the heat and cool setpoint labels on the form
        void UpdateSetpoints()
        {
            HeatSetpointLabel.Text = "Heat: " + heatSetpoint.ToString("F1") + "°F";
            CoolSetpointLabel.Text = "Cool: " + coolSetpoint.ToString("F1") + "°F";
        }

        // Updates the indicator label text and background color based on the output state
        void SetIndicator(Label label, string text, bool isOn)
        {
            label.Text = text + (isOn ? "ON" : "OFF");
            label.BackColor = isOn ? RoarangeL : GrowlGreyLight;
        }

        // Updates the display labels and indicators on the form
        void UpdateDisplay()
        {
            updatingDisplay = true;

            ClockLabel.Text = DateTime.Now.ToString("hh:mm tt");
            RoomTempLabel.Text = inputsValid ? roomTemperature.ToString("F1") + "°F" : "--.-°F";
            UnitTempLabel.Text = inputsValid ? unitTemperature.ToString("F1") + "°F" : "--.-°F";
            UpdateSetpoints();

            string mode = heatSwitch ? "Heating" : coolSwitch ? "Cooling" : "Off";
            if (heatSwitch && coolSwitch) mode = "Conflict";
            ModeStatusLabel.Text = "Mode: " + mode;
            FanModeLabel.Text = "Fan Mode: " + (fanSwitch ? "On" : "Auto");

            // Show simulated outputs, or hardware outputs only when enabled.
            bool outputsEnabled = SimulationCheckBox.Checked ||
                (boardConnected && hardwareOutputsEnabled);
            SetIndicator(HeatStatusLabel, "Heating: ", heatOutput && outputsEnabled);
            SetIndicator(CoolStatusLabel, "Cooling: ", coolOutput && outputsEnabled);
            SetIndicator(FanStatusLabel, "Fan: ", (fanOutput || fanOnlyOutput) && outputsEnabled);

            FaultStatusLabel.Text = currentFault == "" ? "Fault: None" : "Fault: " + currentFault;
            FaultStatusLabel.BackColor = currentFault == "" ? GrowlGreyLight : Color.MistyRose;

            if (SimulationCheckBox.Checked)
                CommStatusLabel.Text = "Simulation Mode - no hardware commands";
            else if (boardConnected && !hardwareOutputsEnabled)
                CommStatusLabel.Text = "QY@: Connected (" + boardPort.PortName + ") - outputs disabled";
            else if (boardConnected)
                CommStatusLabel.Text = "QY@: Connected (" + boardPort.PortName + ")";
            else if (boardSearching)
                CommStatusLabel.Text = "QY@: Searching...";
            else if (!autoConnect)
                CommStatusLabel.Text = "QY@: Manually disconnected";
            else
                CommStatusLabel.Text = "QY@: Disconnected - retrying";

            // Mirror the physical inputs using the Designer indicators.
            HeatSwitchCheckBox.Checked = heatSwitch;
            FanSwitchCheckBox.Checked = fanSwitch;
            CoolSwitchCheckBox.Checked = coolSwitch;

            if (!SimulationCheckBox.Checked)
            {
                SafetyCheckBox.Checked = safetyHigh;
                PressureCheckBox.Checked = pressureHigh;
                HeatRadioButton.Checked = heatSwitch;
                CoolRadioButton.Checked = coolSwitch;
                OffRadioButton.Checked = !heatSwitch && !coolSwitch;
                FanOnCheckBox.Checked = fanSwitch;
            }

            updatingDisplay = false;
            SetSimulationControls();
        }

        // Event Handlers Below Here -------------------------------------------------------
        private void HeatPlusButton_Click(object sender, EventArgs e)
        {

        }

        private void HeatMinusButton_Click(object sender, EventArgs e)
        {

        }

        private void CoolPlusButton_Click(object sender, EventArgs e)
        {

        }

        private void CoolMinusButton_Click(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {

        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {

        }

        private void ExirButton_Click(object sender, EventArgs e)
        {

        }

        private void HVACTimer_Tick(object sender, EventArgs e)
        {

        }

        private void CommunicationTimer_Tick(object sender, EventArgs e)
        {

        }

        private void FanOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SimulationCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaveSettingsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CommunicationMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HVACForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
            HVACTimer.Stop();
            CommunicationTimer.Stop();
            StopOutputs();
            DisconnectBoard(false);
            SaveSettings(false);

            try
            {
                boardPort.Dispose();
            }
            catch { }
        }
    }
}
