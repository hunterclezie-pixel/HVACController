namespace HVACController
{
    partial class HVACController
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PictureBox BennEPictureBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HVACController));
            ClockLabel = new Label();
            RoomTempLabel = new Label();
            UnitTempLabel = new Label();
            CurrentSetpointLabel = new Label();
            HeatSetpointLabel = new Label();
            CoolSetpointLabel = new Label();
            HeatPlusButton = new Button();
            HeatMinusButton = new Button();
            CoolPlusButton = new Button();
            CoolMinusButton = new Button();
            ModeStatusLabel = new Label();
            FanModeLabel = new Label();
            FanStatusLabel = new Label();
            HeatStatusLabel = new Label();
            CoolStatusLabel = new Label();
            FaultStatusLabel = new Label();
            CommStatusLabel = new Label();
            MaintenanceLabel = new Label();
            SafetyCheckBox = new CheckBox();
            HeatingCheckBox = new CheckBox();
            FanOnlyCheckBox = new CheckBox();
            PressureCheckBox = new CheckBox();
            CoolingCheckBox = new CheckBox();
            MainMenuStrip = new MenuStrip();
            FileStripMenuItem = new ToolStripMenuItem();
            SaveSettingsMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            SettingsMenuItem = new ToolStripMenuItem();
            CommunicationMenuItem = new ToolStripMenuItem();
            PortsStripComboBox = new ToolStripComboBox();
            ConnectMenuItem = new ToolStripMenuItem();
            DisconnectMenuItem = new ToolStripMenuItem();
            HVACTimer = new System.Windows.Forms.Timer(components);
            CommunicationTimer = new System.Windows.Forms.Timer(components);
            ConnectButton = new Button();
            DisconnectButton = new Button();
            ExitButton = new Button();
            SimulationGroupBox = new GroupBox();
            SimulatedTempLabel = new Label();
            UnitTempNumericUpDown = new NumericUpDown();
            SimulationCheckBox = new CheckBox();
            RoomTempNumericUpDown = new NumericUpDown();
            HeatRadioButton = new RadioButton();
            CoolRadioButton = new RadioButton();
            OffRadioButton = new RadioButton();
            FanOnCheckBox = new CheckBox();
            PortsComboBox = new ComboBox();
            OperatingModeGroupBox = new GroupBox();
            TemperatureGroupBox = new GroupBox();
            OperationGroupBox = new GroupBox();
            GearPictureBox = new PictureBox();
            ConnectionGroupBox = new GroupBox();
            BennEPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BennEPictureBox).BeginInit();
            MainMenuStrip.SuspendLayout();
            SimulationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UnitTempNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RoomTempNumericUpDown).BeginInit();
            OperatingModeGroupBox.SuspendLayout();
            TemperatureGroupBox.SuspendLayout();
            OperationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GearPictureBox).BeginInit();
            ConnectionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // BennEPictureBox
            // 
            BennEPictureBox.Image = (Image)resources.GetObject("BennEPictureBox.Image");
            BennEPictureBox.Location = new Point(639, 193);
            BennEPictureBox.Name = "BennEPictureBox";
            BennEPictureBox.Size = new Size(149, 149);
            BennEPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BennEPictureBox.TabIndex = 39;
            BennEPictureBox.TabStop = false;
            // 
            // ClockLabel
            // 
            ClockLabel.AutoSize = true;
            ClockLabel.Location = new Point(70, 326);
            ClockLabel.Name = "ClockLabel";
            ClockLabel.Size = new Size(44, 20);
            ClockLabel.TabIndex = 0;
            ClockLabel.Text = "12:00";
            ClockLabel.Click += ClockLabel_Click;
            // 
            // RoomTempLabel
            // 
            RoomTempLabel.AutoSize = true;
            RoomTempLabel.Location = new Point(13, 28);
            RoomTempLabel.Name = "RoomTempLabel";
            RoomTempLabel.Size = new Size(96, 20);
            RoomTempLabel.TabIndex = 1;
            RoomTempLabel.Text = "Room: 70.0°F";
            // 
            // UnitTempLabel
            // 
            UnitTempLabel.AutoSize = true;
            UnitTempLabel.Location = new Point(13, 59);
            UnitTempLabel.Name = "UnitTempLabel";
            UnitTempLabel.Size = new Size(83, 20);
            UnitTempLabel.TabIndex = 2;
            UnitTempLabel.Text = "Unit: 80.0°F";
            // 
            // CurrentSetpointLabel
            // 
            CurrentSetpointLabel.AutoSize = true;
            CurrentSetpointLabel.Location = new Point(13, 90);
            CurrentSetpointLabel.Name = "CurrentSetpointLabel";
            CurrentSetpointLabel.Size = new Size(164, 20);
            CurrentSetpointLabel.TabIndex = 3;
            CurrentSetpointLabel.Text = "Current Setpoint: 70.0°F";
            // 
            // HeatSetpointLabel
            // 
            HeatSetpointLabel.AutoSize = true;
            HeatSetpointLabel.Location = new Point(63, 128);
            HeatSetpointLabel.Name = "HeatSetpointLabel";
            HeatSetpointLabel.Size = new Size(88, 20);
            HeatSetpointLabel.TabIndex = 5;
            HeatSetpointLabel.Text = "Heat: 68.0°F";
            // 
            // CoolSetpointLabel
            // 
            CoolSetpointLabel.AutoSize = true;
            CoolSetpointLabel.Location = new Point(63, 214);
            CoolSetpointLabel.Name = "CoolSetpointLabel";
            CoolSetpointLabel.Size = new Size(87, 20);
            CoolSetpointLabel.TabIndex = 6;
            CoolSetpointLabel.Text = "Cool: 75.0°F";
            // 
            // HeatPlusButton
            // 
            HeatPlusButton.Location = new Point(9, 151);
            HeatPlusButton.Name = "HeatPlusButton";
            HeatPlusButton.Size = new Size(94, 45);
            HeatPlusButton.TabIndex = 7;
            HeatPlusButton.Text = "Heat +";
            HeatPlusButton.UseVisualStyleBackColor = true;
            HeatPlusButton.Click += HeatPlusButton_Click;
            // 
            // HeatMinusButton
            // 
            HeatMinusButton.Location = new Point(109, 151);
            HeatMinusButton.Name = "HeatMinusButton";
            HeatMinusButton.Size = new Size(94, 45);
            HeatMinusButton.TabIndex = 8;
            HeatMinusButton.Text = "Heat -";
            HeatMinusButton.UseVisualStyleBackColor = true;
            HeatMinusButton.Click += HeatMinusButton_Click;
            // 
            // CoolPlusButton
            // 
            CoolPlusButton.Location = new Point(9, 237);
            CoolPlusButton.Name = "CoolPlusButton";
            CoolPlusButton.Size = new Size(94, 45);
            CoolPlusButton.TabIndex = 9;
            CoolPlusButton.Text = "Cool +";
            CoolPlusButton.UseVisualStyleBackColor = true;
            CoolPlusButton.Click += CoolPlusButton_Click;
            // 
            // CoolMinusButton
            // 
            CoolMinusButton.Location = new Point(109, 237);
            CoolMinusButton.Name = "CoolMinusButton";
            CoolMinusButton.Size = new Size(94, 45);
            CoolMinusButton.TabIndex = 10;
            CoolMinusButton.Text = "Cool -";
            CoolMinusButton.UseVisualStyleBackColor = true;
            CoolMinusButton.Click += CoolMinusButton_Click;
            // 
            // ModeStatusLabel
            // 
            ModeStatusLabel.AutoSize = true;
            ModeStatusLabel.Location = new Point(6, 23);
            ModeStatusLabel.Name = "ModeStatusLabel";
            ModeStatusLabel.Size = new Size(80, 20);
            ModeStatusLabel.TabIndex = 11;
            ModeStatusLabel.Text = "Mode: OFF";
            // 
            // FanModeLabel
            // 
            FanModeLabel.AutoSize = true;
            FanModeLabel.Location = new Point(6, 46);
            FanModeLabel.Name = "FanModeLabel";
            FanModeLabel.Size = new Size(119, 20);
            FanModeLabel.TabIndex = 12;
            FanModeLabel.Text = "Fan Mode: AUTO";
            // 
            // FanStatusLabel
            // 
            FanStatusLabel.AutoSize = true;
            FanStatusLabel.Location = new Point(7, 69);
            FanStatusLabel.Name = "FanStatusLabel";
            FanStatusLabel.Size = new Size(63, 20);
            FanStatusLabel.TabIndex = 13;
            FanStatusLabel.Text = "Fan: OFF";
            // 
            // HeatStatusLabel
            // 
            HeatStatusLabel.AutoSize = true;
            HeatStatusLabel.Location = new Point(6, 92);
            HeatStatusLabel.Name = "HeatStatusLabel";
            HeatStatusLabel.Size = new Size(94, 20);
            HeatStatusLabel.TabIndex = 14;
            HeatStatusLabel.Text = "Heating: OFF";
            // 
            // CoolStatusLabel
            // 
            CoolStatusLabel.AutoSize = true;
            CoolStatusLabel.Location = new Point(7, 114);
            CoolStatusLabel.Name = "CoolStatusLabel";
            CoolStatusLabel.Size = new Size(93, 20);
            CoolStatusLabel.TabIndex = 15;
            CoolStatusLabel.Text = "Cooling: OFF";
            // 
            // FaultStatusLabel
            // 
            FaultStatusLabel.AutoSize = true;
            FaultStatusLabel.Location = new Point(306, 70);
            FaultStatusLabel.Name = "FaultStatusLabel";
            FaultStatusLabel.Size = new Size(75, 20);
            FaultStatusLabel.TabIndex = 18;
            FaultStatusLabel.Text = "NO FAULT";
            // 
            // CommStatusLabel
            // 
            CommStatusLabel.AutoSize = true;
            CommStatusLabel.Location = new Point(306, 18);
            CommStatusLabel.Name = "CommStatusLabel";
            CommStatusLabel.Size = new Size(99, 20);
            CommStatusLabel.TabIndex = 19;
            CommStatusLabel.Text = "Disconnected";
            // 
            // MaintenanceLabel
            // 
            MaintenanceLabel.AutoSize = true;
            MaintenanceLabel.Location = new Point(306, 43);
            MaintenanceLabel.Name = "MaintenanceLabel";
            MaintenanceLabel.Size = new Size(110, 20);
            MaintenanceLabel.TabIndex = 20;
            MaintenanceLabel.Text = "System Normal";
            // 
            // SafetyCheckBox
            // 
            SafetyCheckBox.AutoSize = true;
            SafetyCheckBox.Location = new Point(17, 52);
            SafetyCheckBox.Name = "SafetyCheckBox";
            SafetyCheckBox.Size = new Size(133, 24);
            SafetyCheckBox.TabIndex = 21;
            SafetyCheckBox.Text = "Safety Interlock";
            SafetyCheckBox.UseVisualStyleBackColor = true;
            // 
            // HeatingCheckBox
            // 
            HeatingCheckBox.AutoSize = true;
            HeatingCheckBox.Location = new Point(17, 142);
            HeatingCheckBox.Name = "HeatingCheckBox";
            HeatingCheckBox.Size = new Size(142, 24);
            HeatingCheckBox.TabIndex = 22;
            HeatingCheckBox.Text = "Heating Enabled";
            HeatingCheckBox.UseVisualStyleBackColor = true;
            // 
            // FanOnlyCheckBox
            // 
            FanOnlyCheckBox.AutoSize = true;
            FanOnlyCheckBox.Location = new Point(17, 112);
            FanOnlyCheckBox.Name = "FanOnlyCheckBox";
            FanOnlyCheckBox.Size = new Size(87, 24);
            FanOnlyCheckBox.TabIndex = 23;
            FanOnlyCheckBox.Text = "Fan Only";
            FanOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // PressureCheckBox
            // 
            PressureCheckBox.AutoSize = true;
            PressureCheckBox.Location = new Point(17, 82);
            PressureCheckBox.Name = "PressureCheckBox";
            PressureCheckBox.Size = new Size(109, 24);
            PressureCheckBox.TabIndex = 24;
            PressureCheckBox.Text = "Pressure OK";
            PressureCheckBox.UseVisualStyleBackColor = true;
            // 
            // CoolingCheckBox
            // 
            CoolingCheckBox.AutoSize = true;
            CoolingCheckBox.Location = new Point(17, 172);
            CoolingCheckBox.Name = "CoolingCheckBox";
            CoolingCheckBox.Size = new Size(141, 24);
            CoolingCheckBox.TabIndex = 25;
            CoolingCheckBox.Text = "Cooling Enabled";
            CoolingCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.ImageScalingSize = new Size(20, 20);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { FileStripMenuItem, SettingsMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(800, 28);
            MainMenuStrip.TabIndex = 26;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // FileStripMenuItem
            // 
            FileStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveSettingsMenuItem, ExitMenuItem });
            FileStripMenuItem.Name = "FileStripMenuItem";
            FileStripMenuItem.Size = new Size(46, 24);
            FileStripMenuItem.Text = "File";
            // 
            // SaveSettingsMenuItem
            // 
            SaveSettingsMenuItem.Name = "SaveSettingsMenuItem";
            SaveSettingsMenuItem.Size = new Size(224, 26);
            SaveSettingsMenuItem.Text = "Save Settings";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(224, 26);
            ExitMenuItem.Text = "Exit";
            // 
            // SettingsMenuItem
            // 
            SettingsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CommunicationMenuItem });
            SettingsMenuItem.Name = "SettingsMenuItem";
            SettingsMenuItem.Size = new Size(76, 24);
            SettingsMenuItem.Text = "Settings";
            // 
            // CommunicationMenuItem
            // 
            CommunicationMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PortsStripComboBox, ConnectMenuItem, DisconnectMenuItem });
            CommunicationMenuItem.Name = "CommunicationMenuItem";
            CommunicationMenuItem.Size = new Size(239, 26);
            CommunicationMenuItem.Text = "Communication Setup";
            // 
            // PortsStripComboBox
            // 
            PortsStripComboBox.Name = "PortsStripComboBox";
            PortsStripComboBox.Size = new Size(121, 28);
            // 
            // ConnectMenuItem
            // 
            ConnectMenuItem.Name = "ConnectMenuItem";
            ConnectMenuItem.Size = new Size(195, 26);
            ConnectMenuItem.Text = "Connect";
            // 
            // DisconnectMenuItem
            // 
            DisconnectMenuItem.Name = "DisconnectMenuItem";
            DisconnectMenuItem.Size = new Size(195, 26);
            DisconnectMenuItem.Text = "Disconnect";
            // 
            // HVACTimer
            // 
            HVACTimer.Interval = 1000;
            HVACTimer.Tick += HVACTimer_Tick;
            // 
            // CommunicationTimer
            // 
            CommunicationTimer.Interval = 10000;
            CommunicationTimer.Tick += CommunicationTimer_Tick;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(6, 52);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(94, 39);
            ConnectButton.TabIndex = 27;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // DisconnectButton
            // 
            DisconnectButton.Location = new Point(106, 51);
            DisconnectButton.Name = "DisconnectButton";
            DisconnectButton.Size = new Size(94, 39);
            DisconnectButton.TabIndex = 28;
            DisconnectButton.Text = "Disconnect";
            DisconnectButton.UseVisualStyleBackColor = true;
            DisconnectButton.Click += DisconnectButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(206, 51);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 39);
            ExitButton.TabIndex = 29;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SimulationGroupBox
            // 
            SimulationGroupBox.Controls.Add(SimulatedTempLabel);
            SimulationGroupBox.Controls.Add(UnitTempNumericUpDown);
            SimulationGroupBox.Controls.Add(SimulationCheckBox);
            SimulationGroupBox.Controls.Add(RoomTempNumericUpDown);
            SimulationGroupBox.Controls.Add(SafetyCheckBox);
            SimulationGroupBox.Controls.Add(HeatingCheckBox);
            SimulationGroupBox.Controls.Add(FanOnlyCheckBox);
            SimulationGroupBox.Controls.Add(PressureCheckBox);
            SimulationGroupBox.Controls.Add(CoolingCheckBox);
            SimulationGroupBox.Location = new Point(383, 38);
            SimulationGroupBox.Name = "SimulationGroupBox";
            SimulationGroupBox.Size = new Size(250, 304);
            SimulationGroupBox.TabIndex = 30;
            SimulationGroupBox.TabStop = false;
            SimulationGroupBox.Text = "Simulation Check Boxes";
            // 
            // SimulatedTempLabel
            // 
            SimulatedTempLabel.AutoSize = true;
            SimulatedTempLabel.Location = new Point(17, 200);
            SimulatedTempLabel.Name = "SimulatedTempLabel";
            SimulatedTempLabel.Size = new Size(208, 20);
            SimulatedTempLabel.TabIndex = 39;
            SimulatedTempLabel.Text = "Simulated Room Temperature";
            // 
            // UnitTempNumericUpDown
            // 
            UnitTempNumericUpDown.DecimalPlaces = 1;
            UnitTempNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            UnitTempNumericUpDown.Location = new Point(17, 258);
            UnitTempNumericUpDown.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            UnitTempNumericUpDown.Name = "UnitTempNumericUpDown";
            UnitTempNumericUpDown.Size = new Size(208, 27);
            UnitTempNumericUpDown.TabIndex = 38;
            UnitTempNumericUpDown.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // SimulationCheckBox
            // 
            SimulationCheckBox.AutoSize = true;
            SimulationCheckBox.Location = new Point(17, 22);
            SimulationCheckBox.Name = "SimulationCheckBox";
            SimulationCheckBox.Size = new Size(145, 24);
            SimulationCheckBox.TabIndex = 26;
            SimulationCheckBox.Text = "Simulation Mode";
            SimulationCheckBox.UseVisualStyleBackColor = true;
            SimulationCheckBox.CheckedChanged += SimulationCheckBox_CheckedChanged;
            // 
            // RoomTempNumericUpDown
            // 
            RoomTempNumericUpDown.DecimalPlaces = 1;
            RoomTempNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            RoomTempNumericUpDown.Location = new Point(17, 223);
            RoomTempNumericUpDown.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            RoomTempNumericUpDown.Name = "RoomTempNumericUpDown";
            RoomTempNumericUpDown.Size = new Size(208, 27);
            RoomTempNumericUpDown.TabIndex = 37;
            RoomTempNumericUpDown.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // HeatRadioButton
            // 
            HeatRadioButton.AutoSize = true;
            HeatRadioButton.Location = new Point(11, 26);
            HeatRadioButton.Name = "HeatRadioButton";
            HeatRadioButton.Size = new Size(83, 24);
            HeatRadioButton.TabIndex = 31;
            HeatRadioButton.TabStop = true;
            HeatRadioButton.Text = "Heating";
            HeatRadioButton.UseVisualStyleBackColor = true;
            // 
            // CoolRadioButton
            // 
            CoolRadioButton.AutoSize = true;
            CoolRadioButton.Location = new Point(11, 57);
            CoolRadioButton.Name = "CoolRadioButton";
            CoolRadioButton.Size = new Size(82, 24);
            CoolRadioButton.TabIndex = 32;
            CoolRadioButton.TabStop = true;
            CoolRadioButton.Text = "Cooling";
            CoolRadioButton.UseVisualStyleBackColor = true;
            // 
            // OffRadioButton
            // 
            OffRadioButton.AutoSize = true;
            OffRadioButton.Location = new Point(11, 87);
            OffRadioButton.Name = "OffRadioButton";
            OffRadioButton.Size = new Size(51, 24);
            OffRadioButton.TabIndex = 33;
            OffRadioButton.TabStop = true;
            OffRadioButton.Text = "Off";
            OffRadioButton.UseVisualStyleBackColor = true;
            // 
            // FanOnCheckBox
            // 
            FanOnCheckBox.AutoSize = true;
            FanOnCheckBox.Location = new Point(11, 119);
            FanOnCheckBox.Name = "FanOnCheckBox";
            FanOnCheckBox.Size = new Size(76, 24);
            FanOnCheckBox.TabIndex = 34;
            FanOnCheckBox.Text = "Fan On";
            FanOnCheckBox.UseVisualStyleBackColor = true;
            FanOnCheckBox.CheckedChanged += FanOnCheckBox_CheckedChanged;
            // 
            // PortsComboBox
            // 
            PortsComboBox.FormattingEnabled = true;
            PortsComboBox.Location = new Point(6, 20);
            PortsComboBox.Name = "PortsComboBox";
            PortsComboBox.Size = new Size(294, 28);
            PortsComboBox.TabIndex = 35;
            // 
            // OperatingModeGroupBox
            // 
            OperatingModeGroupBox.Controls.Add(HeatRadioButton);
            OperatingModeGroupBox.Controls.Add(CoolRadioButton);
            OperatingModeGroupBox.Controls.Add(FanOnCheckBox);
            OperatingModeGroupBox.Controls.Add(OffRadioButton);
            OperatingModeGroupBox.Location = new Point(231, 38);
            OperatingModeGroupBox.Name = "OperatingModeGroupBox";
            OperatingModeGroupBox.Size = new Size(146, 157);
            OperatingModeGroupBox.TabIndex = 36;
            OperatingModeGroupBox.TabStop = false;
            OperatingModeGroupBox.Text = "Operating Modes";
            // 
            // TemperatureGroupBox
            // 
            TemperatureGroupBox.Controls.Add(RoomTempLabel);
            TemperatureGroupBox.Controls.Add(UnitTempLabel);
            TemperatureGroupBox.Controls.Add(CurrentSetpointLabel);
            TemperatureGroupBox.Controls.Add(HeatSetpointLabel);
            TemperatureGroupBox.Controls.Add(CoolSetpointLabel);
            TemperatureGroupBox.Controls.Add(HeatPlusButton);
            TemperatureGroupBox.Controls.Add(HeatMinusButton);
            TemperatureGroupBox.Controls.Add(CoolPlusButton);
            TemperatureGroupBox.Controls.Add(CoolMinusButton);
            TemperatureGroupBox.Location = new Point(12, 38);
            TemperatureGroupBox.Name = "TemperatureGroupBox";
            TemperatureGroupBox.Size = new Size(213, 304);
            TemperatureGroupBox.TabIndex = 37;
            TemperatureGroupBox.TabStop = false;
            TemperatureGroupBox.Text = "Temp Display And Controls";
            // 
            // OperationGroupBox
            // 
            OperationGroupBox.Controls.Add(ModeStatusLabel);
            OperationGroupBox.Controls.Add(CoolStatusLabel);
            OperationGroupBox.Controls.Add(FanModeLabel);
            OperationGroupBox.Controls.Add(FanStatusLabel);
            OperationGroupBox.Controls.Add(HeatStatusLabel);
            OperationGroupBox.Location = new Point(231, 201);
            OperationGroupBox.Name = "OperationGroupBox";
            OperationGroupBox.Size = new Size(146, 141);
            OperationGroupBox.TabIndex = 38;
            OperationGroupBox.TabStop = false;
            OperationGroupBox.Text = "Operating Status";
            // 
            // GearPictureBox
            // 
            GearPictureBox.Image = (Image)resources.GetObject("GearPictureBox.Image");
            GearPictureBox.Location = new Point(639, 38);
            GearPictureBox.Name = "GearPictureBox";
            GearPictureBox.Size = new Size(149, 149);
            GearPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            GearPictureBox.TabIndex = 40;
            GearPictureBox.TabStop = false;
            // 
            // ConnectionGroupBox
            // 
            ConnectionGroupBox.Controls.Add(PortsComboBox);
            ConnectionGroupBox.Controls.Add(FaultStatusLabel);
            ConnectionGroupBox.Controls.Add(CommStatusLabel);
            ConnectionGroupBox.Controls.Add(MaintenanceLabel);
            ConnectionGroupBox.Controls.Add(ConnectButton);
            ConnectionGroupBox.Controls.Add(DisconnectButton);
            ConnectionGroupBox.Controls.Add(ExitButton);
            ConnectionGroupBox.Location = new Point(12, 343);
            ConnectionGroupBox.Name = "ConnectionGroupBox";
            ConnectionGroupBox.Size = new Size(776, 97);
            ConnectionGroupBox.TabIndex = 41;
            ConnectionGroupBox.TabStop = false;
            ConnectionGroupBox.Text = "Connections and Ports";
            // 
            // HVACController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ConnectionGroupBox);
            Controls.Add(GearPictureBox);
            Controls.Add(BennEPictureBox);
            Controls.Add(OperationGroupBox);
            Controls.Add(TemperatureGroupBox);
            Controls.Add(OperatingModeGroupBox);
            Controls.Add(SimulationGroupBox);
            Controls.Add(ClockLabel);
            Controls.Add(MainMenuStrip);
            Name = "HVACController";
            Text = "HVAC Controller";
            ((System.ComponentModel.ISupportInitialize)BennEPictureBox).EndInit();
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            SimulationGroupBox.ResumeLayout(false);
            SimulationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UnitTempNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)RoomTempNumericUpDown).EndInit();
            OperatingModeGroupBox.ResumeLayout(false);
            OperatingModeGroupBox.PerformLayout();
            TemperatureGroupBox.ResumeLayout(false);
            TemperatureGroupBox.PerformLayout();
            OperationGroupBox.ResumeLayout(false);
            OperationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GearPictureBox).EndInit();
            ConnectionGroupBox.ResumeLayout(false);
            ConnectionGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ClockLabel;
        private Label RoomTempLabel;
        private Label UnitTempLabel;
        private Label CurrentSetpointLabel;
        private Label HeatSetpointLabel;
        private Label CoolSetpointLabel;
        private Button HeatPlusButton;
        private Button HeatMinusButton;
        private Button CoolPlusButton;
        private Button CoolMinusButton;
        private Label ModeStatusLabel;
        private Label FanModeLabel;
        private Label FanStatusLabel;
        private Label HeatStatusLabel;
        private Label CoolStatusLabel;
        private Label FaultStatusLabel;
        private Label CommStatusLabel;
        private Label MaintenanceLabel;
        private CheckBox SafetyCheckBox;
        private CheckBox HeatingCheckBox;
        private CheckBox FanOnlyCheckBox;
        private CheckBox PressureCheckBox;
        private CheckBox CoolingCheckBox;
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem FileStripMenuItem;
        private ToolStripMenuItem SaveSettingsMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem SettingsMenuItem;
        private ToolStripMenuItem CommunicationMenuItem;
        private ToolStripComboBox PortsStripComboBox;
        private ToolStripMenuItem ConnectMenuItem;
        private ToolStripMenuItem DisconnectMenuItem;
        private System.Windows.Forms.Timer HVACTimer;
        private System.Windows.Forms.Timer CommunicationTimer;
        private Button ConnectButton;
        private Button DisconnectButton;
        private Button ExitButton;
        private GroupBox SimulationGroupBox;
        private RadioButton HeatRadioButton;
        private RadioButton CoolRadioButton;
        private RadioButton OffRadioButton;
        private CheckBox FanOnCheckBox;
        private ComboBox PortsComboBox;
        private GroupBox OperatingModeGroupBox;
        private CheckBox SimulationCheckBox;
        private NumericUpDown RoomTempNumericUpDown;
        private NumericUpDown UnitTempNumericUpDown;
        private Label SimulatedTempLabel;
        private GroupBox TemperatureGroupBox;
        private GroupBox OperationGroupBox;
        private PictureBox GearPictureBox;
        private GroupBox ConnectionGroupBox;
    }
}
