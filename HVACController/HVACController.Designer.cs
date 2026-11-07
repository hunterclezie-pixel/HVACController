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
            SafetyStatusLabel = new Label();
            PressureStatusLabel = new Label();
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
            ExirButton = new Button();
            SimulationGroupBox = new GroupBox();
            HeatRadioButton = new RadioButton();
            CoolRadioButton = new RadioButton();
            OffRadioButton = new RadioButton();
            FanOnCheckBox = new CheckBox();
            PortsComboBox = new ComboBox();
            OperatingModeGroupBox = new GroupBox();
            SimulationCheckBox = new CheckBox();
            RoomTempNumericUpDown = new NumericUpDown();
            UnitTempNumericUpDown = new NumericUpDown();
            SimulatedTempLabel = new Label();
            MainMenuStrip.SuspendLayout();
            SimulationGroupBox.SuspendLayout();
            OperatingModeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RoomTempNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UnitTempNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // ClockLabel
            // 
            ClockLabel.AutoSize = true;
            ClockLabel.Location = new Point(16, 31);
            ClockLabel.Name = "ClockLabel";
            ClockLabel.Size = new Size(44, 20);
            ClockLabel.TabIndex = 0;
            ClockLabel.Text = "12:00";
            // 
            // RoomTempLabel
            // 
            RoomTempLabel.AutoSize = true;
            RoomTempLabel.Location = new Point(16, 64);
            RoomTempLabel.Name = "RoomTempLabel";
            RoomTempLabel.Size = new Size(49, 20);
            RoomTempLabel.TabIndex = 1;
            RoomTempLabel.Text = "70.0°F";
            // 
            // UnitTempLabel
            // 
            UnitTempLabel.AutoSize = true;
            UnitTempLabel.Location = new Point(16, 84);
            UnitTempLabel.Name = "UnitTempLabel";
            UnitTempLabel.Size = new Size(49, 20);
            UnitTempLabel.TabIndex = 2;
            UnitTempLabel.Text = "80.0°F";
            // 
            // CurrentSetpointLabel
            // 
            CurrentSetpointLabel.AutoSize = true;
            CurrentSetpointLabel.Location = new Point(16, 104);
            CurrentSetpointLabel.Name = "CurrentSetpointLabel";
            CurrentSetpointLabel.Size = new Size(49, 20);
            CurrentSetpointLabel.TabIndex = 3;
            CurrentSetpointLabel.Text = "70.0°F";
            // 
            // HeatSetpointLabel
            // 
            HeatSetpointLabel.AutoSize = true;
            HeatSetpointLabel.Location = new Point(12, 157);
            HeatSetpointLabel.Name = "HeatSetpointLabel";
            HeatSetpointLabel.Size = new Size(88, 20);
            HeatSetpointLabel.TabIndex = 5;
            HeatSetpointLabel.Text = "Heat: 68.0°F";
            // 
            // CoolSetpointLabel
            // 
            CoolSetpointLabel.AutoSize = true;
            CoolSetpointLabel.Location = new Point(112, 157);
            CoolSetpointLabel.Name = "CoolSetpointLabel";
            CoolSetpointLabel.Size = new Size(87, 20);
            CoolSetpointLabel.TabIndex = 6;
            CoolSetpointLabel.Text = "Cool: 75.0°F";
            // 
            // HeatPlusButton
            // 
            HeatPlusButton.Location = new Point(12, 180);
            HeatPlusButton.Name = "HeatPlusButton";
            HeatPlusButton.Size = new Size(94, 45);
            HeatPlusButton.TabIndex = 7;
            HeatPlusButton.Text = "Heat +";
            HeatPlusButton.UseVisualStyleBackColor = true;
            HeatPlusButton.Click += HeatPlusButton_Click;
            // 
            // HeatMinusButton
            // 
            HeatMinusButton.Location = new Point(12, 231);
            HeatMinusButton.Name = "HeatMinusButton";
            HeatMinusButton.Size = new Size(94, 45);
            HeatMinusButton.TabIndex = 8;
            HeatMinusButton.Text = "Heat -";
            HeatMinusButton.UseVisualStyleBackColor = true;
            HeatMinusButton.Click += HeatMinusButton_Click;
            // 
            // CoolPlusButton
            // 
            CoolPlusButton.Location = new Point(112, 180);
            CoolPlusButton.Name = "CoolPlusButton";
            CoolPlusButton.Size = new Size(94, 45);
            CoolPlusButton.TabIndex = 9;
            CoolPlusButton.Text = "Cool +";
            CoolPlusButton.UseVisualStyleBackColor = true;
            CoolPlusButton.Click += CoolPlusButton_Click;
            // 
            // CoolMinusButton
            // 
            CoolMinusButton.Location = new Point(112, 231);
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
            ModeStatusLabel.Location = new Point(211, 31);
            ModeStatusLabel.Name = "ModeStatusLabel";
            ModeStatusLabel.Size = new Size(80, 20);
            ModeStatusLabel.TabIndex = 11;
            ModeStatusLabel.Text = "Mode: OFF";
            // 
            // FanModeLabel
            // 
            FanModeLabel.AutoSize = true;
            FanModeLabel.Location = new Point(211, 51);
            FanModeLabel.Name = "FanModeLabel";
            FanModeLabel.Size = new Size(119, 20);
            FanModeLabel.TabIndex = 12;
            FanModeLabel.Text = "Fan Mode: AUTO";
            // 
            // FanStatusLabel
            // 
            FanStatusLabel.AutoSize = true;
            FanStatusLabel.Location = new Point(211, 71);
            FanStatusLabel.Name = "FanStatusLabel";
            FanStatusLabel.Size = new Size(63, 20);
            FanStatusLabel.TabIndex = 13;
            FanStatusLabel.Text = "Fan: OFF";
            // 
            // HeatStatusLabel
            // 
            HeatStatusLabel.AutoSize = true;
            HeatStatusLabel.Location = new Point(211, 92);
            HeatStatusLabel.Name = "HeatStatusLabel";
            HeatStatusLabel.Size = new Size(94, 20);
            HeatStatusLabel.TabIndex = 14;
            HeatStatusLabel.Text = "Heating: OFF";
            // 
            // CoolStatusLabel
            // 
            CoolStatusLabel.AutoSize = true;
            CoolStatusLabel.Location = new Point(211, 112);
            CoolStatusLabel.Name = "CoolStatusLabel";
            CoolStatusLabel.Size = new Size(93, 20);
            CoolStatusLabel.TabIndex = 15;
            CoolStatusLabel.Text = "Cooling: OFF";
            // 
            // SafetyStatusLabel
            // 
            SafetyStatusLabel.AutoSize = true;
            SafetyStatusLabel.Location = new Point(386, 215);
            SafetyStatusLabel.Name = "SafetyStatusLabel";
            SafetyStatusLabel.Size = new Size(42, 20);
            SafetyStatusLabel.TabIndex = 16;
            SafetyStatusLabel.Text = "SAFE";
            // 
            // PressureStatusLabel
            // 
            PressureStatusLabel.AutoSize = true;
            PressureStatusLabel.Location = new Point(386, 235);
            PressureStatusLabel.Name = "PressureStatusLabel";
            PressureStatusLabel.Size = new Size(29, 20);
            PressureStatusLabel.TabIndex = 17;
            PressureStatusLabel.Text = "OK";
            // 
            // FaultStatusLabel
            // 
            FaultStatusLabel.AutoSize = true;
            FaultStatusLabel.Location = new Point(386, 255);
            FaultStatusLabel.Name = "FaultStatusLabel";
            FaultStatusLabel.Size = new Size(75, 20);
            FaultStatusLabel.TabIndex = 18;
            FaultStatusLabel.Text = "NO FAULT";
            // 
            // CommStatusLabel
            // 
            CommStatusLabel.AutoSize = true;
            CommStatusLabel.Location = new Point(494, 342);
            CommStatusLabel.Name = "CommStatusLabel";
            CommStatusLabel.Size = new Size(99, 20);
            CommStatusLabel.TabIndex = 19;
            CommStatusLabel.Text = "Disconnected";
            // 
            // MaintenanceLabel
            // 
            MaintenanceLabel.AutoSize = true;
            MaintenanceLabel.Location = new Point(386, 280);
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
            SaveSettingsMenuItem.Click += SaveSettingsMenuItem_Click;
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
            CommunicationMenuItem.Click += CommunicationMenuItem_Click;
            // 
            // PortsStripComboBox
            // 
            PortsStripComboBox.Name = "PortsStripComboBox";
            PortsStripComboBox.Size = new Size(121, 28);
            // 
            // ConnectMenuItem
            // 
            ConnectMenuItem.Name = "ConnectMenuItem";
            ConnectMenuItem.Size = new Size(224, 26);
            ConnectMenuItem.Text = "Connect";
            // 
            // DisconnectMenuItem
            // 
            DisconnectMenuItem.Name = "DisconnectMenuItem";
            DisconnectMenuItem.Size = new Size(224, 26);
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
            ConnectButton.Location = new Point(494, 400);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(94, 39);
            ConnectButton.TabIndex = 27;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // DisconnectButton
            // 
            DisconnectButton.Location = new Point(594, 399);
            DisconnectButton.Name = "DisconnectButton";
            DisconnectButton.Size = new Size(94, 39);
            DisconnectButton.TabIndex = 28;
            DisconnectButton.Text = "Disconnect";
            DisconnectButton.UseVisualStyleBackColor = true;
            DisconnectButton.Click += DisconnectButton_Click;
            // 
            // ExirButton
            // 
            ExirButton.Location = new Point(694, 399);
            ExirButton.Name = "ExirButton";
            ExirButton.Size = new Size(94, 39);
            ExirButton.TabIndex = 29;
            ExirButton.Text = "Exit";
            ExirButton.UseVisualStyleBackColor = true;
            ExirButton.Click += ExirButton_Click;
            // 
            // SimulationGroupBox
            // 
            SimulationGroupBox.Controls.Add(SimulationCheckBox);
            SimulationGroupBox.Controls.Add(SafetyCheckBox);
            SimulationGroupBox.Controls.Add(HeatingCheckBox);
            SimulationGroupBox.Controls.Add(FanOnlyCheckBox);
            SimulationGroupBox.Controls.Add(PressureCheckBox);
            SimulationGroupBox.Controls.Add(CoolingCheckBox);
            SimulationGroupBox.Location = new Point(538, 31);
            SimulationGroupBox.Name = "SimulationGroupBox";
            SimulationGroupBox.Size = new Size(250, 204);
            SimulationGroupBox.TabIndex = 30;
            SimulationGroupBox.TabStop = false;
            SimulationGroupBox.Text = "Simulation Check Boxes";
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
            PortsComboBox.Location = new Point(494, 365);
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
            OperatingModeGroupBox.Location = new Point(386, 31);
            OperatingModeGroupBox.Name = "OperatingModeGroupBox";
            OperatingModeGroupBox.Size = new Size(146, 146);
            OperatingModeGroupBox.TabIndex = 36;
            OperatingModeGroupBox.TabStop = false;
            OperatingModeGroupBox.Text = "Operating Modes";
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
            RoomTempNumericUpDown.Location = new Point(16, 315);
            RoomTempNumericUpDown.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            RoomTempNumericUpDown.Name = "RoomTempNumericUpDown";
            RoomTempNumericUpDown.Size = new Size(208, 27);
            RoomTempNumericUpDown.TabIndex = 37;
            RoomTempNumericUpDown.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // UnitTempNumericUpDown
            // 
            UnitTempNumericUpDown.DecimalPlaces = 1;
            UnitTempNumericUpDown.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            UnitTempNumericUpDown.Location = new Point(16, 348);
            UnitTempNumericUpDown.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            UnitTempNumericUpDown.Name = "UnitTempNumericUpDown";
            UnitTempNumericUpDown.Size = new Size(208, 27);
            UnitTempNumericUpDown.TabIndex = 38;
            UnitTempNumericUpDown.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // SimulatedTempLabel
            // 
            SimulatedTempLabel.AutoSize = true;
            SimulatedTempLabel.Location = new Point(16, 290);
            SimulatedTempLabel.Name = "SimulatedTempLabel";
            SimulatedTempLabel.Size = new Size(208, 20);
            SimulatedTempLabel.TabIndex = 39;
            SimulatedTempLabel.Text = "Simulated Room Temperature";
            // 
            // HVACController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SimulatedTempLabel);
            Controls.Add(UnitTempNumericUpDown);
            Controls.Add(RoomTempNumericUpDown);
            Controls.Add(OperatingModeGroupBox);
            Controls.Add(PortsComboBox);
            Controls.Add(SimulationGroupBox);
            Controls.Add(ExirButton);
            Controls.Add(DisconnectButton);
            Controls.Add(ConnectButton);
            Controls.Add(MaintenanceLabel);
            Controls.Add(CommStatusLabel);
            Controls.Add(FaultStatusLabel);
            Controls.Add(PressureStatusLabel);
            Controls.Add(SafetyStatusLabel);
            Controls.Add(CoolStatusLabel);
            Controls.Add(HeatStatusLabel);
            Controls.Add(FanStatusLabel);
            Controls.Add(FanModeLabel);
            Controls.Add(ModeStatusLabel);
            Controls.Add(CoolMinusButton);
            Controls.Add(CoolPlusButton);
            Controls.Add(HeatMinusButton);
            Controls.Add(HeatPlusButton);
            Controls.Add(CoolSetpointLabel);
            Controls.Add(HeatSetpointLabel);
            Controls.Add(CurrentSetpointLabel);
            Controls.Add(UnitTempLabel);
            Controls.Add(RoomTempLabel);
            Controls.Add(ClockLabel);
            Controls.Add(MainMenuStrip);
            Name = "HVACController";
            Text = "Form1";
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            SimulationGroupBox.ResumeLayout(false);
            SimulationGroupBox.PerformLayout();
            OperatingModeGroupBox.ResumeLayout(false);
            OperatingModeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RoomTempNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)UnitTempNumericUpDown).EndInit();
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
        private Label SafetyStatusLabel;
        private Label PressureStatusLabel;
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
        private Button ExirButton;
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
    }
}
