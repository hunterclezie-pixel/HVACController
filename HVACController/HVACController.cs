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
