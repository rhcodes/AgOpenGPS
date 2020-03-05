﻿namespace AgOpenGPS
{
    partial class FormIMU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headingGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rbtnHeadingHDT = new System.Windows.Forms.RadioButton();
            this.rbtnHeadingGPS = new System.Windows.Forms.RadioButton();
            this.rbtnHeadingFix = new System.Windows.Forms.RadioButton();
            this.btnRollZero = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveZeroOffsetPitch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZeroPitch = new System.Windows.Forms.Button();
            this.btnRemoveZeroOffset = new System.Windows.Forms.Button();
            this.lblRollZeroOffset = new System.Windows.Forms.Label();
            this.btnZeroRoll = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbtnRollNone = new System.Windows.Forms.RadioButton();
            this.rbtnRollUDP = new System.Windows.Forms.RadioButton();
            this.rbtnRollAutoSteer = new System.Windows.Forms.RadioButton();
            this.rbtnRollGPS = new System.Windows.Forms.RadioButton();
            this.groupBoxHeadingCorrection = new System.Windows.Forms.GroupBox();
            this.rbtnHeadingCorrUDP = new System.Windows.Forms.RadioButton();
            this.rbtnHeadingCorrBrick = new System.Windows.Forms.RadioButton();
            this.rbtnHeadingCorrAutoSteer = new System.Windows.Forms.RadioButton();
            this.rbtnHeadingCorrNone = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxTinkerUID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.nudMinFixStepDistance = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFix = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxNMEAHz = new System.Windows.Forms.ComboBox();
            this.lblSimGGA = new System.Windows.Forms.Label();
            this.cboxIsRTK = new System.Windows.Forms.CheckBox();
            this.rbtnOGI = new System.Windows.Forms.RadioButton();
            this.rbtnRMC = new System.Windows.Forms.RadioButton();
            this.rbtnGGA = new System.Windows.Forms.RadioButton();
            this.tabHeading = new System.Windows.Forms.TabPage();
            this.tabRoll = new System.Windows.Forms.TabPage();
            this.headingGroupBox.SuspendLayout();
            this.btnRollZero.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBoxHeadingCorrection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinFixStepDistance)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabFix.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabHeading.SuspendLayout();
            this.tabRoll.SuspendLayout();
            this.SuspendLayout();
            // 
            // headingGroupBox
            // 
            this.headingGroupBox.Controls.Add(this.label13);
            this.headingGroupBox.Controls.Add(this.label12);
            this.headingGroupBox.Controls.Add(this.label11);
            this.headingGroupBox.Controls.Add(this.rbtnHeadingHDT);
            this.headingGroupBox.Controls.Add(this.rbtnHeadingGPS);
            this.headingGroupBox.Controls.Add(this.rbtnHeadingFix);
            this.headingGroupBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingGroupBox.Location = new System.Drawing.Point(17, 20);
            this.headingGroupBox.Name = "headingGroupBox";
            this.headingGroupBox.Size = new System.Drawing.Size(332, 247);
            this.headingGroupBox.TabIndex = 84;
            this.headingGroupBox.TabStop = false;
            this.headingGroupBox.Text = "GPS Heading From";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(160, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 43);
            this.label13.TabIndex = 88;
            this.label13.Text = "Dual Antenna";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(160, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 43);
            this.label12.TabIndex = 87;
            this.label12.Text = "From VTG or RMC ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(160, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 43);
            this.label11.TabIndex = 86;
            this.label11.Text = "Fix to Fix Calc";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtnHeadingHDT
            // 
            this.rbtnHeadingHDT.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHeadingHDT.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnHeadingHDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHeadingHDT.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHeadingHDT.Location = new System.Drawing.Point(6, 189);
            this.rbtnHeadingHDT.Name = "rbtnHeadingHDT";
            this.rbtnHeadingHDT.Size = new System.Drawing.Size(137, 43);
            this.rbtnHeadingHDT.TabIndex = 2;
            this.rbtnHeadingHDT.Text = "Dual";
            this.rbtnHeadingHDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnHeadingHDT.UseVisualStyleBackColor = true;
            this.rbtnHeadingHDT.CheckedChanged += new System.EventHandler(this.RbtnHeadingFix_CheckedChanged);
            // 
            // rbtnHeadingGPS
            // 
            this.rbtnHeadingGPS.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHeadingGPS.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnHeadingGPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHeadingGPS.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHeadingGPS.Location = new System.Drawing.Point(6, 122);
            this.rbtnHeadingGPS.Name = "rbtnHeadingGPS";
            this.rbtnHeadingGPS.Size = new System.Drawing.Size(137, 43);
            this.rbtnHeadingGPS.TabIndex = 1;
            this.rbtnHeadingGPS.Text = "GPS";
            this.rbtnHeadingGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnHeadingGPS.UseVisualStyleBackColor = true;
            this.rbtnHeadingGPS.CheckedChanged += new System.EventHandler(this.RbtnHeadingFix_CheckedChanged);
            // 
            // rbtnHeadingFix
            // 
            this.rbtnHeadingFix.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHeadingFix.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnHeadingFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHeadingFix.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHeadingFix.Location = new System.Drawing.Point(6, 55);
            this.rbtnHeadingFix.Name = "rbtnHeadingFix";
            this.rbtnHeadingFix.Size = new System.Drawing.Size(137, 43);
            this.rbtnHeadingFix.TabIndex = 0;
            this.rbtnHeadingFix.Text = "Fix";
            this.rbtnHeadingFix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnHeadingFix.UseVisualStyleBackColor = true;
            this.rbtnHeadingFix.CheckedChanged += new System.EventHandler(this.RbtnHeadingFix_CheckedChanged);
            // 
            // btnRollZero
            // 
            this.btnRollZero.Controls.Add(this.label2);
            this.btnRollZero.Controls.Add(this.btnRemoveZeroOffsetPitch);
            this.btnRollZero.Controls.Add(this.label1);
            this.btnRollZero.Controls.Add(this.btnZeroPitch);
            this.btnRollZero.Controls.Add(this.btnRemoveZeroOffset);
            this.btnRollZero.Controls.Add(this.lblRollZeroOffset);
            this.btnRollZero.Controls.Add(this.btnZeroRoll);
            this.btnRollZero.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollZero.Location = new System.Drawing.Point(19, 66);
            this.btnRollZero.Name = "btnRollZero";
            this.btnRollZero.Size = new System.Drawing.Size(314, 227);
            this.btnRollZero.TabIndex = 83;
            this.btnRollZero.TabStop = false;
            this.btnRollZero.Text = "Roll Zero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(204, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Pitch";
            // 
            // btnRemoveZeroOffsetPitch
            // 
            this.btnRemoveZeroOffsetPitch.Enabled = false;
            this.btnRemoveZeroOffsetPitch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveZeroOffsetPitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoveZeroOffsetPitch.Location = new System.Drawing.Point(12, 242);
            this.btnRemoveZeroOffsetPitch.Name = "btnRemoveZeroOffsetPitch";
            this.btnRemoveZeroOffsetPitch.Size = new System.Drawing.Size(79, 48);
            this.btnRemoveZeroOffsetPitch.TabIndex = 79;
            this.btnRemoveZeroOffsetPitch.Text = "Remove Offset";
            this.btnRemoveZeroOffsetPitch.UseVisualStyleBackColor = true;
            this.btnRemoveZeroOffsetPitch.Click += new System.EventHandler(this.BtnRemoveZeroOffsetPitch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(99, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 33);
            this.label1.TabIndex = 78;
            this.label1.Text = "--";
            // 
            // btnZeroPitch
            // 
            this.btnZeroPitch.Enabled = false;
            this.btnZeroPitch.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeroPitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZeroPitch.Location = new System.Drawing.Point(207, 242);
            this.btnZeroPitch.Name = "btnZeroPitch";
            this.btnZeroPitch.Size = new System.Drawing.Size(103, 48);
            this.btnZeroPitch.TabIndex = 77;
            this.btnZeroPitch.Text = "> 0 <";
            this.btnZeroPitch.UseVisualStyleBackColor = true;
            this.btnZeroPitch.Click += new System.EventHandler(this.BtnZeroPitch_Click);
            // 
            // btnRemoveZeroOffset
            // 
            this.btnRemoveZeroOffset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveZeroOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoveZeroOffset.Location = new System.Drawing.Point(28, 53);
            this.btnRemoveZeroOffset.Name = "btnRemoveZeroOffset";
            this.btnRemoveZeroOffset.Size = new System.Drawing.Size(103, 49);
            this.btnRemoveZeroOffset.TabIndex = 76;
            this.btnRemoveZeroOffset.Text = "Remove Offset";
            this.btnRemoveZeroOffset.UseVisualStyleBackColor = true;
            this.btnRemoveZeroOffset.Click += new System.EventHandler(this.BtnRemoveZeroOffset_Click);
            // 
            // lblRollZeroOffset
            // 
            this.lblRollZeroOffset.AutoSize = true;
            this.lblRollZeroOffset.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.lblRollZeroOffset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRollZeroOffset.Location = new System.Drawing.Point(149, 151);
            this.lblRollZeroOffset.Name = "lblRollZeroOffset";
            this.lblRollZeroOffset.Size = new System.Drawing.Size(100, 33);
            this.lblRollZeroOffset.TabIndex = 75;
            this.lblRollZeroOffset.Text = "label11";
            // 
            // btnZeroRoll
            // 
            this.btnZeroRoll.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeroRoll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZeroRoll.Location = new System.Drawing.Point(28, 142);
            this.btnZeroRoll.Name = "btnZeroRoll";
            this.btnZeroRoll.Size = new System.Drawing.Size(103, 48);
            this.btnZeroRoll.TabIndex = 73;
            this.btnZeroRoll.Text = "> 0 <";
            this.btnZeroRoll.UseVisualStyleBackColor = true;
            this.btnZeroRoll.Click += new System.EventHandler(this.BtnZeroRoll_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(12, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(419, 69);
            this.label10.TabIndex = 82;
            this.label10.Text = "*ALL Settings Require Restart";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbtnRollNone);
            this.groupBox6.Controls.Add(this.rbtnRollUDP);
            this.groupBox6.Controls.Add(this.rbtnRollAutoSteer);
            this.groupBox6.Controls.Add(this.rbtnRollGPS);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(405, 55);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(288, 334);
            this.groupBox6.TabIndex = 80;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Roll Source";
            // 
            // rbtnRollNone
            // 
            this.rbtnRollNone.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnRollNone.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnRollNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRollNone.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRollNone.Location = new System.Drawing.Point(16, 42);
            this.rbtnRollNone.Name = "rbtnRollNone";
            this.rbtnRollNone.Size = new System.Drawing.Size(248, 43);
            this.rbtnRollNone.TabIndex = 96;
            this.rbtnRollNone.TabStop = true;
            this.rbtnRollNone.Text = "None";
            this.rbtnRollNone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnRollNone.UseVisualStyleBackColor = true;
            // 
            // rbtnRollUDP
            // 
            this.rbtnRollUDP.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnRollUDP.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnRollUDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRollUDP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRollUDP.Location = new System.Drawing.Point(16, 261);
            this.rbtnRollUDP.Name = "rbtnRollUDP";
            this.rbtnRollUDP.Size = new System.Drawing.Size(248, 43);
            this.rbtnRollUDP.TabIndex = 95;
            this.rbtnRollUDP.TabStop = true;
            this.rbtnRollUDP.Text = "UDP";
            this.rbtnRollUDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnRollUDP.UseVisualStyleBackColor = true;
            // 
            // rbtnRollAutoSteer
            // 
            this.rbtnRollAutoSteer.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnRollAutoSteer.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnRollAutoSteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRollAutoSteer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRollAutoSteer.Location = new System.Drawing.Point(16, 115);
            this.rbtnRollAutoSteer.Name = "rbtnRollAutoSteer";
            this.rbtnRollAutoSteer.Size = new System.Drawing.Size(248, 43);
            this.rbtnRollAutoSteer.TabIndex = 93;
            this.rbtnRollAutoSteer.TabStop = true;
            this.rbtnRollAutoSteer.Text = "Auto Steer Module";
            this.rbtnRollAutoSteer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnRollAutoSteer.UseVisualStyleBackColor = true;
            // 
            // rbtnRollGPS
            // 
            this.rbtnRollGPS.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnRollGPS.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnRollGPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRollGPS.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRollGPS.Location = new System.Drawing.Point(16, 188);
            this.rbtnRollGPS.Name = "rbtnRollGPS";
            this.rbtnRollGPS.Size = new System.Drawing.Size(248, 43);
            this.rbtnRollGPS.TabIndex = 94;
            this.rbtnRollGPS.TabStop = true;
            this.rbtnRollGPS.Text = "Dual Antenna";
            this.rbtnRollGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnRollGPS.UseVisualStyleBackColor = true;
            // 
            // groupBoxHeadingCorrection
            // 
            this.groupBoxHeadingCorrection.Controls.Add(this.rbtnHeadingCorrUDP);
            this.groupBoxHeadingCorrection.Controls.Add(this.rbtnHeadingCorrBrick);
            this.groupBoxHeadingCorrection.Controls.Add(this.rbtnHeadingCorrAutoSteer);
            this.groupBoxHeadingCorrection.Controls.Add(this.rbtnHeadingCorrNone);
            this.groupBoxHeadingCorrection.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHeadingCorrection.Location = new System.Drawing.Point(406, 20);
            this.groupBoxHeadingCorrection.Name = "groupBoxHeadingCorrection";
            this.groupBoxHeadingCorrection.Size = new System.Drawing.Size(288, 307);
            this.groupBoxHeadingCorrection.TabIndex = 81;
            this.groupBoxHeadingCorrection.TabStop = false;
            this.groupBoxHeadingCorrection.Text = "Heading Correction Source";
            // 
            // rbtnHeadingCorrUDP
            // 
            this.rbtnHeadingCorrUDP.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHeadingCorrUDP.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnHeadingCorrUDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHeadingCorrUDP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHeadingCorrUDP.Location = new System.Drawing.Point(16, 242);
            this.rbtnHeadingCorrUDP.Name = "rbtnHeadingCorrUDP";
            this.rbtnHeadingCorrUDP.Size = new System.Drawing.Size(248, 43);
            this.rbtnHeadingCorrUDP.TabIndex = 92;
            this.rbtnHeadingCorrUDP.TabStop = true;
            this.rbtnHeadingCorrUDP.Text = "UDP";
            this.rbtnHeadingCorrUDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnHeadingCorrUDP.UseVisualStyleBackColor = true;
            // 
            // rbtnHeadingCorrBrick
            // 
            this.rbtnHeadingCorrBrick.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHeadingCorrBrick.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnHeadingCorrBrick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHeadingCorrBrick.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHeadingCorrBrick.Location = new System.Drawing.Point(16, 175);
            this.rbtnHeadingCorrBrick.Name = "rbtnHeadingCorrBrick";
            this.rbtnHeadingCorrBrick.Size = new System.Drawing.Size(248, 43);
            this.rbtnHeadingCorrBrick.TabIndex = 91;
            this.rbtnHeadingCorrBrick.TabStop = true;
            this.rbtnHeadingCorrBrick.Text = "Brick v2";
            this.rbtnHeadingCorrBrick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnHeadingCorrBrick.UseVisualStyleBackColor = true;
            // 
            // rbtnHeadingCorrAutoSteer
            // 
            this.rbtnHeadingCorrAutoSteer.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHeadingCorrAutoSteer.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnHeadingCorrAutoSteer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHeadingCorrAutoSteer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHeadingCorrAutoSteer.Location = new System.Drawing.Point(16, 108);
            this.rbtnHeadingCorrAutoSteer.Name = "rbtnHeadingCorrAutoSteer";
            this.rbtnHeadingCorrAutoSteer.Size = new System.Drawing.Size(248, 43);
            this.rbtnHeadingCorrAutoSteer.TabIndex = 90;
            this.rbtnHeadingCorrAutoSteer.TabStop = true;
            this.rbtnHeadingCorrAutoSteer.Text = "Auto Steer Module";
            this.rbtnHeadingCorrAutoSteer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnHeadingCorrAutoSteer.UseVisualStyleBackColor = true;
            // 
            // rbtnHeadingCorrNone
            // 
            this.rbtnHeadingCorrNone.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHeadingCorrNone.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnHeadingCorrNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHeadingCorrNone.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHeadingCorrNone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnHeadingCorrNone.Location = new System.Drawing.Point(16, 41);
            this.rbtnHeadingCorrNone.Name = "rbtnHeadingCorrNone";
            this.rbtnHeadingCorrNone.Size = new System.Drawing.Size(248, 43);
            this.rbtnHeadingCorrNone.TabIndex = 89;
            this.rbtnHeadingCorrNone.TabStop = true;
            this.rbtnHeadingCorrNone.Text = "None";
            this.rbtnHeadingCorrNone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnHeadingCorrNone.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(450, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 23);
            this.label9.TabIndex = 79;
            this.label9.Text = "IMU Brick v2 UID";
            // 
            // tboxTinkerUID
            // 
            this.tboxTinkerUID.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.tboxTinkerUID.Location = new System.Drawing.Point(453, 392);
            this.tboxTinkerUID.Name = "tboxTinkerUID";
            this.tboxTinkerUID.Size = new System.Drawing.Size(169, 33);
            this.tboxTinkerUID.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.nudMinFixStepDistance);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.groupBox1.Location = new System.Drawing.Point(17, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 125);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fix To Fix Distance";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label35.Location = new System.Drawing.Point(176, 60);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(94, 29);
            this.label35.TabIndex = 67;
            this.label35.Text = "Meters";
            // 
            // nudMinFixStepDistance
            // 
            this.nudMinFixStepDistance.BackColor = System.Drawing.Color.AliceBlue;
            this.nudMinFixStepDistance.DecimalPlaces = 1;
            this.nudMinFixStepDistance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinFixStepDistance.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudMinFixStepDistance.InterceptArrowKeys = false;
            this.nudMinFixStepDistance.Location = new System.Drawing.Point(22, 47);
            this.nudMinFixStepDistance.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            65536});
            this.nudMinFixStepDistance.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.nudMinFixStepDistance.Name = "nudMinFixStepDistance";
            this.nudMinFixStepDistance.Size = new System.Drawing.Size(129, 50);
            this.nudMinFixStepDistance.TabIndex = 66;
            this.nudMinFixStepDistance.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudMinFixStepDistance.ValueChanged += new System.EventHandler(this.NudMinFixStepDistance_ValueChanged);
            this.nudMinFixStepDistance.Enter += new System.EventHandler(this.NudMinFixStepDistance_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnCancel.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(452, 524);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 72);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // bntOK
            // 
            this.bntOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntOK.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.bntOK.Image = global::AgOpenGPS.Properties.Resources.OK64;
            this.bntOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bntOK.Location = new System.Drawing.Point(573, 524);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(156, 72);
            this.bntOK.TabIndex = 4;
            this.bntOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.BntOK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabFix);
            this.tabControl1.Controls.Add(this.tabHeading);
            this.tabControl1.Controls.Add(this.tabRoll);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(235, 60);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 504);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 122;
            // 
            // tabFix
            // 
            this.tabFix.BackColor = System.Drawing.Color.Azure;
            this.tabFix.Controls.Add(this.groupBox4);
            this.tabFix.Location = new System.Drawing.Point(4, 64);
            this.tabFix.Name = "tabFix";
            this.tabFix.Padding = new System.Windows.Forms.Padding(3);
            this.tabFix.Size = new System.Drawing.Size(709, 436);
            this.tabFix.TabIndex = 0;
            this.tabFix.Text = "Fix";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cboxNMEAHz);
            this.groupBox4.Controls.Add(this.lblSimGGA);
            this.groupBox4.Controls.Add(this.cboxIsRTK);
            this.groupBox4.Controls.Add(this.rbtnOGI);
            this.groupBox4.Controls.Add(this.rbtnRMC);
            this.groupBox4.Controls.Add(this.rbtnGGA);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(41, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(647, 264);
            this.groupBox4.TabIndex = 71;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Position From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(455, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 89;
            this.label7.Text = "NMEA Hz";
            // 
            // cboxNMEAHz
            // 
            this.cboxNMEAHz.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboxNMEAHz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxNMEAHz.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxNMEAHz.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "8",
            "10"});
            this.cboxNMEAHz.Location = new System.Drawing.Point(448, 161);
            this.cboxNMEAHz.Name = "cboxNMEAHz";
            this.cboxNMEAHz.Size = new System.Drawing.Size(96, 37);
            this.cboxNMEAHz.TabIndex = 88;
            this.cboxNMEAHz.SelectedIndexChanged += new System.EventHandler(this.CboxNMEAHz_SelectedIndexChanged);
            // 
            // lblSimGGA
            // 
            this.lblSimGGA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimGGA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSimGGA.Location = new System.Drawing.Point(167, 47);
            this.lblSimGGA.Name = "lblSimGGA";
            this.lblSimGGA.Size = new System.Drawing.Size(148, 45);
            this.lblSimGGA.TabIndex = 87;
            this.lblSimGGA.Text = "Use GGA For Simulator";
            this.lblSimGGA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxIsRTK
            // 
            this.cboxIsRTK.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxIsRTK.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.cboxIsRTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxIsRTK.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxIsRTK.Location = new System.Drawing.Point(423, 66);
            this.cboxIsRTK.Name = "cboxIsRTK";
            this.cboxIsRTK.Size = new System.Drawing.Size(140, 43);
            this.cboxIsRTK.TabIndex = 72;
            this.cboxIsRTK.Text = "RTK ?";
            this.cboxIsRTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxIsRTK.UseVisualStyleBackColor = true;
            // 
            // rbtnOGI
            // 
            this.rbtnOGI.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnOGI.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnOGI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnOGI.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOGI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnOGI.Location = new System.Drawing.Point(21, 197);
            this.rbtnOGI.Name = "rbtnOGI";
            this.rbtnOGI.Size = new System.Drawing.Size(140, 43);
            this.rbtnOGI.TabIndex = 71;
            this.rbtnOGI.TabStop = true;
            this.rbtnOGI.Text = "OGI";
            this.rbtnOGI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnOGI.UseVisualStyleBackColor = true;
            this.rbtnOGI.CheckedChanged += new System.EventHandler(this.RbtnGGA_CheckedChanged);
            // 
            // rbtnRMC
            // 
            this.rbtnRMC.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnRMC.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnRMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRMC.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRMC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnRMC.Location = new System.Drawing.Point(21, 122);
            this.rbtnRMC.Name = "rbtnRMC";
            this.rbtnRMC.Size = new System.Drawing.Size(140, 43);
            this.rbtnRMC.TabIndex = 70;
            this.rbtnRMC.TabStop = true;
            this.rbtnRMC.Text = "RMC";
            this.rbtnRMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnRMC.UseVisualStyleBackColor = true;
            this.rbtnRMC.CheckedChanged += new System.EventHandler(this.RbtnGGA_CheckedChanged);
            // 
            // rbtnGGA
            // 
            this.rbtnGGA.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnGGA.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnGGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnGGA.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGGA.Location = new System.Drawing.Point(21, 47);
            this.rbtnGGA.Name = "rbtnGGA";
            this.rbtnGGA.Size = new System.Drawing.Size(140, 43);
            this.rbtnGGA.TabIndex = 69;
            this.rbtnGGA.TabStop = true;
            this.rbtnGGA.Text = "GGA";
            this.rbtnGGA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnGGA.UseVisualStyleBackColor = true;
            this.rbtnGGA.CheckedChanged += new System.EventHandler(this.RbtnGGA_CheckedChanged);
            // 
            // tabHeading
            // 
            this.tabHeading.BackColor = System.Drawing.Color.Azure;
            this.tabHeading.Controls.Add(this.headingGroupBox);
            this.tabHeading.Controls.Add(this.groupBox1);
            this.tabHeading.Controls.Add(this.groupBoxHeadingCorrection);
            this.tabHeading.Controls.Add(this.label9);
            this.tabHeading.Controls.Add(this.tboxTinkerUID);
            this.tabHeading.Location = new System.Drawing.Point(4, 64);
            this.tabHeading.Name = "tabHeading";
            this.tabHeading.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeading.Size = new System.Drawing.Size(709, 436);
            this.tabHeading.TabIndex = 1;
            this.tabHeading.Text = "Heading";
            // 
            // tabRoll
            // 
            this.tabRoll.BackColor = System.Drawing.Color.Azure;
            this.tabRoll.Controls.Add(this.groupBox6);
            this.tabRoll.Controls.Add(this.btnRollZero);
            this.tabRoll.Location = new System.Drawing.Point(4, 64);
            this.tabRoll.Name = "tabRoll";
            this.tabRoll.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoll.Size = new System.Drawing.Size(709, 436);
            this.tabRoll.TabIndex = 2;
            this.tabRoll.Text = "Roll";
            // 
            // FormIMU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(736, 603);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bntOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIMU";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDisplaySettings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormDisplaySettings_Load);
            this.headingGroupBox.ResumeLayout(false);
            this.btnRollZero.ResumeLayout(false);
            this.btnRollZero.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBoxHeadingCorrection.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinFixStepDistance)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabFix.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabHeading.ResumeLayout(false);
            this.tabHeading.PerformLayout();
            this.tabRoll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.GroupBox headingGroupBox;
        private System.Windows.Forms.GroupBox btnRollZero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveZeroOffsetPitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZeroPitch;
        private System.Windows.Forms.Button btnRemoveZeroOffset;
        private System.Windows.Forms.Label lblRollZeroOffset;
        private System.Windows.Forms.Button btnZeroRoll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxHeadingCorrection;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxTinkerUID;
        private System.Windows.Forms.RadioButton rbtnHeadingHDT;
        private System.Windows.Forms.RadioButton rbtnHeadingGPS;
        private System.Windows.Forms.RadioButton rbtnHeadingFix;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown nudMinFixStepDistance;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFix;
        private System.Windows.Forms.TabPage tabHeading;
        private System.Windows.Forms.TabPage tabRoll;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnOGI;
        private System.Windows.Forms.RadioButton rbtnRMC;
        private System.Windows.Forms.RadioButton rbtnGGA;
        private System.Windows.Forms.CheckBox cboxIsRTK;
        private System.Windows.Forms.RadioButton rbtnHeadingCorrUDP;
        private System.Windows.Forms.RadioButton rbtnHeadingCorrBrick;
        private System.Windows.Forms.RadioButton rbtnHeadingCorrAutoSteer;
        private System.Windows.Forms.RadioButton rbtnHeadingCorrNone;
        private System.Windows.Forms.RadioButton rbtnRollNone;
        private System.Windows.Forms.RadioButton rbtnRollUDP;
        private System.Windows.Forms.RadioButton rbtnRollAutoSteer;
        private System.Windows.Forms.RadioButton rbtnRollGPS;
        private System.Windows.Forms.Label lblSimGGA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxNMEAHz;
    }
}