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
            RoboticsLogoPictureBox = new Label();
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
            CommunicationStatusLabel = new Label();
            MaintenanceLabel = new Label();
            SafetyCheckBox = new CheckBox();
            HeatingCheckBox = new CheckBox();
            FanOnlyCheckBox = new CheckBox();
            PressureCheckBox = new CheckBox();
            CoolingCheckBox = new CheckBox();
            MainMenuStrip = new MenuStrip();
            FileStripMenuItem = new ToolStripMenuItem();
            SettingsMenuItem = new ToolStripMenuItem();
            SaveSettingsMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            CommunicationMenuItem = new ToolStripMenuItem();
            PortsComboBox = new ToolStripComboBox();
            ConnectMenuItem = new ToolStripMenuItem();
            DisconnectMenuItem = new ToolStripMenuItem();
            HVACTimer = new System.Windows.Forms.Timer(components);
            CommunicationTimer = new System.Windows.Forms.Timer(components);
            MainMenuStrip.SuspendLayout();
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
            UnitTempLabel.Text = "70.0°F";
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
            // RoboticsLogoPictureBox
            // 
            RoboticsLogoPictureBox.AutoSize = true;
            RoboticsLogoPictureBox.Location = new Point(16, 140);
            RoboticsLogoPictureBox.Name = "RoboticsLogoPictureBox";
            RoboticsLogoPictureBox.Size = new Size(131, 20);
            RoboticsLogoPictureBox.TabIndex = 4;
            RoboticsLogoPictureBox.Text = "ISU Robotics Logo";
            // 
            // HeatSetpointLabel
            // 
            HeatSetpointLabel.AutoSize = true;
            HeatSetpointLabel.Location = new Point(16, 199);
            HeatSetpointLabel.Name = "HeatSetpointLabel";
            HeatSetpointLabel.Size = new Size(49, 20);
            HeatSetpointLabel.TabIndex = 5;
            HeatSetpointLabel.Text = "68.0°F";
            // 
            // CoolSetpointLabel
            // 
            CoolSetpointLabel.AutoSize = true;
            CoolSetpointLabel.Location = new Point(16, 231);
            CoolSetpointLabel.Name = "CoolSetpointLabel";
            CoolSetpointLabel.Size = new Size(49, 20);
            CoolSetpointLabel.TabIndex = 6;
            CoolSetpointLabel.Text = "75.0°F";
            // 
            // HeatPlusButton
            // 
            HeatPlusButton.Location = new Point(16, 273);
            HeatPlusButton.Name = "HeatPlusButton";
            HeatPlusButton.Size = new Size(94, 45);
            HeatPlusButton.TabIndex = 7;
            HeatPlusButton.Text = "Heat +";
            HeatPlusButton.UseVisualStyleBackColor = true;
            // 
            // HeatMinusButton
            // 
            HeatMinusButton.Location = new Point(116, 273);
            HeatMinusButton.Name = "HeatMinusButton";
            HeatMinusButton.Size = new Size(94, 45);
            HeatMinusButton.TabIndex = 8;
            HeatMinusButton.Text = "Heat -";
            HeatMinusButton.UseVisualStyleBackColor = true;
            // 
            // CoolPlusButton
            // 
            CoolPlusButton.Location = new Point(16, 324);
            CoolPlusButton.Name = "CoolPlusButton";
            CoolPlusButton.Size = new Size(94, 45);
            CoolPlusButton.TabIndex = 9;
            CoolPlusButton.Text = "Cool +";
            CoolPlusButton.UseVisualStyleBackColor = true;
            // 
            // CoolMinusButton
            // 
            CoolMinusButton.Location = new Point(116, 324);
            CoolMinusButton.Name = "CoolMinusButton";
            CoolMinusButton.Size = new Size(94, 45);
            CoolMinusButton.TabIndex = 10;
            CoolMinusButton.Text = "Cool -";
            CoolMinusButton.UseVisualStyleBackColor = true;
            // 
            // ModeStatusLabel
            // 
            ModeStatusLabel.AutoSize = true;
            ModeStatusLabel.Location = new Point(250, 31);
            ModeStatusLabel.Name = "ModeStatusLabel";
            ModeStatusLabel.Size = new Size(34, 20);
            ModeStatusLabel.TabIndex = 11;
            ModeStatusLabel.Text = "OFF";
            // 
            // FanModeLabel
            // 
            FanModeLabel.AutoSize = true;
            FanModeLabel.Location = new Point(250, 51);
            FanModeLabel.Name = "FanModeLabel";
            FanModeLabel.Size = new Size(47, 20);
            FanModeLabel.TabIndex = 12;
            FanModeLabel.Text = "AUTO";
            // 
            // FanStatusLabel
            // 
            FanStatusLabel.AutoSize = true;
            FanStatusLabel.Location = new Point(250, 71);
            FanStatusLabel.Name = "FanStatusLabel";
            FanStatusLabel.Size = new Size(34, 20);
            FanStatusLabel.TabIndex = 13;
            FanStatusLabel.Text = "OFF";
            // 
            // HeatStatusLabel
            // 
            HeatStatusLabel.AutoSize = true;
            HeatStatusLabel.Location = new Point(250, 91);
            HeatStatusLabel.Name = "HeatStatusLabel";
            HeatStatusLabel.Size = new Size(34, 20);
            HeatStatusLabel.TabIndex = 14;
            HeatStatusLabel.Text = "OFF";
            // 
            // CoolStatusLabel
            // 
            CoolStatusLabel.AutoSize = true;
            CoolStatusLabel.Location = new Point(250, 111);
            CoolStatusLabel.Name = "CoolStatusLabel";
            CoolStatusLabel.Size = new Size(34, 20);
            CoolStatusLabel.TabIndex = 15;
            CoolStatusLabel.Text = "OFF";
            // 
            // SafetyStatusLabel
            // 
            SafetyStatusLabel.AutoSize = true;
            SafetyStatusLabel.Location = new Point(353, 30);
            SafetyStatusLabel.Name = "SafetyStatusLabel";
            SafetyStatusLabel.Size = new Size(42, 20);
            SafetyStatusLabel.TabIndex = 16;
            SafetyStatusLabel.Text = "SAFE";
            // 
            // PressureStatusLabel
            // 
            PressureStatusLabel.AutoSize = true;
            PressureStatusLabel.Location = new Point(353, 50);
            PressureStatusLabel.Name = "PressureStatusLabel";
            PressureStatusLabel.Size = new Size(29, 20);
            PressureStatusLabel.TabIndex = 17;
            PressureStatusLabel.Text = "OK";
            // 
            // FaultStatusLabel
            // 
            FaultStatusLabel.AutoSize = true;
            FaultStatusLabel.Location = new Point(353, 70);
            FaultStatusLabel.Name = "FaultStatusLabel";
            FaultStatusLabel.Size = new Size(75, 20);
            FaultStatusLabel.TabIndex = 18;
            FaultStatusLabel.Text = "NO FAULT";
            // 
            // CommunicationStatusLabel
            // 
            CommunicationStatusLabel.AutoSize = true;
            CommunicationStatusLabel.Location = new Point(353, 90);
            CommunicationStatusLabel.Name = "CommunicationStatusLabel";
            CommunicationStatusLabel.Size = new Size(99, 20);
            CommunicationStatusLabel.TabIndex = 19;
            CommunicationStatusLabel.Text = "Disconnected";
            // 
            // MaintenanceLabel
            // 
            MaintenanceLabel.AutoSize = true;
            MaintenanceLabel.Location = new Point(353, 110);
            MaintenanceLabel.Name = "MaintenanceLabel";
            MaintenanceLabel.Size = new Size(110, 20);
            MaintenanceLabel.TabIndex = 20;
            MaintenanceLabel.Text = "System Normal";
            // 
            // SafetyCheckBox
            // 
            SafetyCheckBox.AutoSize = true;
            SafetyCheckBox.Location = new Point(524, 30);
            SafetyCheckBox.Name = "SafetyCheckBox";
            SafetyCheckBox.Size = new Size(133, 24);
            SafetyCheckBox.TabIndex = 21;
            SafetyCheckBox.Text = "Safety Interlock";
            SafetyCheckBox.UseVisualStyleBackColor = true;
            // 
            // HeatingCheckBox
            // 
            HeatingCheckBox.AutoSize = true;
            HeatingCheckBox.Location = new Point(524, 60);
            HeatingCheckBox.Name = "HeatingCheckBox";
            HeatingCheckBox.Size = new Size(142, 24);
            HeatingCheckBox.TabIndex = 22;
            HeatingCheckBox.Text = "Heating Enabled";
            HeatingCheckBox.UseVisualStyleBackColor = true;
            // 
            // FanOnlyCheckBox
            // 
            FanOnlyCheckBox.AutoSize = true;
            FanOnlyCheckBox.Location = new Point(524, 90);
            FanOnlyCheckBox.Name = "FanOnlyCheckBox";
            FanOnlyCheckBox.Size = new Size(87, 24);
            FanOnlyCheckBox.TabIndex = 23;
            FanOnlyCheckBox.Text = "Fan Only";
            FanOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // PressureCheckBox
            // 
            PressureCheckBox.AutoSize = true;
            PressureCheckBox.Location = new Point(524, 120);
            PressureCheckBox.Name = "PressureCheckBox";
            PressureCheckBox.Size = new Size(109, 24);
            PressureCheckBox.TabIndex = 24;
            PressureCheckBox.Text = "Pressure OK";
            PressureCheckBox.UseVisualStyleBackColor = true;
            // 
            // CoolingCheckBox
            // 
            CoolingCheckBox.AutoSize = true;
            CoolingCheckBox.Location = new Point(524, 150);
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
            // SettingsMenuItem
            // 
            SettingsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CommunicationMenuItem });
            SettingsMenuItem.Name = "SettingsMenuItem";
            SettingsMenuItem.Size = new Size(76, 24);
            SettingsMenuItem.Text = "Settings";
            // 
            // SaveSettingsMenuItem
            // 
            SaveSettingsMenuItem.Name = "SaveSettingsMenuItem";
            SaveSettingsMenuItem.Size = new Size(180, 26);
            SaveSettingsMenuItem.Text = "Save Settings";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(180, 26);
            ExitMenuItem.Text = "Exit";
            // 
            // CommunicationMenuItem
            // 
            CommunicationMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PortsComboBox, ConnectMenuItem, DisconnectMenuItem });
            CommunicationMenuItem.Name = "CommunicationMenuItem";
            CommunicationMenuItem.Size = new Size(239, 26);
            CommunicationMenuItem.Text = "Communication Setup";
            // 
            // PortsComboBox
            // 
            PortsComboBox.Name = "PortsComboBox";
            PortsComboBox.Size = new Size(121, 28);
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
            // 
            // CommunicationTimer
            // 
            CommunicationTimer.Interval = 10000;
            // 
            // HVACController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CoolingCheckBox);
            Controls.Add(PressureCheckBox);
            Controls.Add(FanOnlyCheckBox);
            Controls.Add(HeatingCheckBox);
            Controls.Add(SafetyCheckBox);
            Controls.Add(MaintenanceLabel);
            Controls.Add(CommunicationStatusLabel);
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
            Controls.Add(RoboticsLogoPictureBox);
            Controls.Add(CurrentSetpointLabel);
            Controls.Add(UnitTempLabel);
            Controls.Add(RoomTempLabel);
            Controls.Add(ClockLabel);
            Controls.Add(MainMenuStrip);
            MainMenuStrip = MainMenuStrip;
            Name = "HVACController";
            Text = "Form1";
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ClockLabel;
        private Label RoomTempLabel;
        private Label UnitTempLabel;
        private Label CurrentSetpointLabel;
        private Label RoboticsLogoPictureBox;
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
        private Label CommunicationStatusLabel;
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
        private ToolStripComboBox PortsComboBox;
        private ToolStripMenuItem ConnectMenuItem;
        private ToolStripMenuItem DisconnectMenuItem;
        private System.Windows.Forms.Timer HVACTimer;
        private System.Windows.Forms.Timer CommunicationTimer;
    }
}
