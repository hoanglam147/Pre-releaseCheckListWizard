﻿namespace BaseApplication
{
    partial class FormBaseApp
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
            this.labelMatrixType = new System.Windows.Forms.Label();
            this.labelCurrentFW = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.groupBoxDeviceInfo = new System.Windows.Forms.GroupBox();
            this.comboBoxUpgradeTo = new System.Windows.Forms.ComboBox();
            this.comboBoxCurrentFW = new System.Windows.Forms.ComboBox();
            this.comboBoxUpgradeFrom = new System.Windows.Forms.ComboBox();
            this.labelUpgradeTo = new System.Windows.Forms.Label();
            this.comboBoxMatrixType = new System.Windows.Forms.ComboBox();
            this.groupBoxContains = new System.Windows.Forms.GroupBox();
            this.labelChannels = new System.Windows.Forms.Label();
            this.comboBoxChannels = new System.Windows.Forms.ComboBox();
            this.comboBoxLogicOperator = new System.Windows.Forms.ComboBox();
            this.comboBoxDiagnostics = new System.Windows.Forms.ComboBox();
            this.labelPCIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDeviceIP = new System.Windows.Forms.TextBox();
            this.comboBoxImageSaving = new System.Windows.Forms.ComboBox();
            this.comboBoxFieldbus = new System.Windows.Forms.ComboBox();
            this.comboBoxAnalysis = new System.Windows.Forms.ComboBox();
            this.comboBoxModes = new System.Windows.Forms.ComboBox();
            this.comboBoxCode2 = new System.Windows.Forms.ComboBox();
            this.comboBoxCode1 = new System.Windows.Forms.ComboBox();
            this.labelImageSaving = new System.Windows.Forms.Label();
            this.labelFieldbus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelModes = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.radioButtonUserDefined = new System.Windows.Forms.RadioButton();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.groupBoxDeviceInfo.SuspendLayout();
            this.groupBoxContains.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMatrixType
            // 
            this.labelMatrixType.AutoSize = true;
            this.labelMatrixType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatrixType.Location = new System.Drawing.Point(17, 20);
            this.labelMatrixType.Name = "labelMatrixType";
            this.labelMatrixType.Size = new System.Drawing.Size(76, 16);
            this.labelMatrixType.TabIndex = 0;
            this.labelMatrixType.Text = "Matrix type:";
            this.labelMatrixType.Click += new System.EventHandler(this.comboBoxMatrixType_SelectedIndexChanged);
            // 
            // labelCurrentFW
            // 
            this.labelCurrentFW.AutoSize = true;
            this.labelCurrentFW.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentFW.Location = new System.Drawing.Point(17, 47);
            this.labelCurrentFW.Name = "labelCurrentFW";
            this.labelCurrentFW.Size = new System.Drawing.Size(83, 16);
            this.labelCurrentFW.TabIndex = 1;
            this.labelCurrentFW.Text = "Current FW: ";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(18, 73);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(47, 16);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "From: ";
            // 
            // groupBoxDeviceInfo
            // 
            this.groupBoxDeviceInfo.Controls.Add(this.comboBoxUpgradeTo);
            this.groupBoxDeviceInfo.Controls.Add(this.comboBoxCurrentFW);
            this.groupBoxDeviceInfo.Controls.Add(this.comboBoxUpgradeFrom);
            this.groupBoxDeviceInfo.Controls.Add(this.labelUpgradeTo);
            this.groupBoxDeviceInfo.Controls.Add(this.comboBoxMatrixType);
            this.groupBoxDeviceInfo.Controls.Add(this.labelCurrentFW);
            this.groupBoxDeviceInfo.Controls.Add(this.labelFrom);
            this.groupBoxDeviceInfo.Controls.Add(this.labelMatrixType);
            this.groupBoxDeviceInfo.Location = new System.Drawing.Point(22, 12);
            this.groupBoxDeviceInfo.Name = "groupBoxDeviceInfo";
            this.groupBoxDeviceInfo.Size = new System.Drawing.Size(391, 109);
            this.groupBoxDeviceInfo.TabIndex = 3;
            this.groupBoxDeviceInfo.TabStop = false;
            // 
            // comboBoxUpgradeTo
            // 
            this.comboBoxUpgradeTo.FormattingEnabled = true;
            this.comboBoxUpgradeTo.Location = new System.Drawing.Point(262, 71);
            this.comboBoxUpgradeTo.Name = "comboBoxUpgradeTo";
            this.comboBoxUpgradeTo.Size = new System.Drawing.Size(81, 21);
            this.comboBoxUpgradeTo.TabIndex = 24;
            // 
            // comboBoxCurrentFW
            // 
            this.comboBoxCurrentFW.FormattingEnabled = true;
            this.comboBoxCurrentFW.Location = new System.Drawing.Point(119, 46);
            this.comboBoxCurrentFW.Name = "comboBoxCurrentFW";
            this.comboBoxCurrentFW.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCurrentFW.TabIndex = 10;
            this.comboBoxCurrentFW.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrentFW_SelectedIndexChanged);
            // 
            // comboBoxUpgradeFrom
            // 
            this.comboBoxUpgradeFrom.FormattingEnabled = true;
            this.comboBoxUpgradeFrom.Location = new System.Drawing.Point(119, 72);
            this.comboBoxUpgradeFrom.Name = "comboBoxUpgradeFrom";
            this.comboBoxUpgradeFrom.Size = new System.Drawing.Size(100, 21);
            this.comboBoxUpgradeFrom.TabIndex = 23;
            this.comboBoxUpgradeFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpgradeFrom_SelectedIndexChanged);
            // 
            // labelUpgradeTo
            // 
            this.labelUpgradeTo.AutoSize = true;
            this.labelUpgradeTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpgradeTo.Location = new System.Drawing.Point(228, 72);
            this.labelUpgradeTo.Name = "labelUpgradeTo";
            this.labelUpgradeTo.Size = new System.Drawing.Size(28, 16);
            this.labelUpgradeTo.TabIndex = 7;
            this.labelUpgradeTo.Text = "To:";
            // 
            // comboBoxMatrixType
            // 
            this.comboBoxMatrixType.FormattingEnabled = true;
            this.comboBoxMatrixType.Location = new System.Drawing.Point(119, 19);
            this.comboBoxMatrixType.Name = "comboBoxMatrixType";
            this.comboBoxMatrixType.Size = new System.Drawing.Size(224, 21);
            this.comboBoxMatrixType.TabIndex = 4;
            this.comboBoxMatrixType.SelectedIndexChanged += new System.EventHandler(this.comboBoxMatrixType_SelectedIndexChanged);
            this.comboBoxMatrixType.TextChanged += new System.EventHandler(this.comboBoxMatrixType_TextChanged);
            // 
            // groupBoxContains
            // 
            this.groupBoxContains.Controls.Add(this.radioButtonDefault);
            this.groupBoxContains.Controls.Add(this.radioButtonUserDefined);
            this.groupBoxContains.Controls.Add(this.labelChannels);
            this.groupBoxContains.Controls.Add(this.comboBoxChannels);
            this.groupBoxContains.Controls.Add(this.comboBoxLogicOperator);
            this.groupBoxContains.Controls.Add(this.comboBoxDiagnostics);
            this.groupBoxContains.Controls.Add(this.labelPCIP);
            this.groupBoxContains.Controls.Add(this.label1);
            this.groupBoxContains.Controls.Add(this.textBoxDeviceIP);
            this.groupBoxContains.Controls.Add(this.comboBoxImageSaving);
            this.groupBoxContains.Controls.Add(this.comboBoxFieldbus);
            this.groupBoxContains.Controls.Add(this.comboBoxAnalysis);
            this.groupBoxContains.Controls.Add(this.comboBoxModes);
            this.groupBoxContains.Controls.Add(this.comboBoxCode2);
            this.groupBoxContains.Controls.Add(this.comboBoxCode1);
            this.groupBoxContains.Controls.Add(this.labelImageSaving);
            this.groupBoxContains.Controls.Add(this.labelFieldbus);
            this.groupBoxContains.Controls.Add(this.label4);
            this.groupBoxContains.Controls.Add(this.labelModes);
            this.groupBoxContains.Controls.Add(this.labelCode);
            this.groupBoxContains.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxContains.Location = new System.Drawing.Point(22, 143);
            this.groupBoxContains.Name = "groupBoxContains";
            this.groupBoxContains.Size = new System.Drawing.Size(391, 344);
            this.groupBoxContains.TabIndex = 4;
            this.groupBoxContains.TabStop = false;
            this.groupBoxContains.Text = "Startup Job";
            this.groupBoxContains.Enter += new System.EventHandler(this.groupBoxContains_Enter);
            // 
            // labelChannels
            // 
            this.labelChannels.AutoSize = true;
            this.labelChannels.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChannels.Location = new System.Drawing.Point(17, 149);
            this.labelChannels.Name = "labelChannels";
            this.labelChannels.Size = new System.Drawing.Size(69, 16);
            this.labelChannels.TabIndex = 26;
            this.labelChannels.Text = "Channels: ";
            this.labelChannels.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxChannels
            // 
            this.comboBoxChannels.FormattingEnabled = true;
            this.comboBoxChannels.Location = new System.Drawing.Point(119, 148);
            this.comboBoxChannels.Name = "comboBoxChannels";
            this.comboBoxChannels.Size = new System.Drawing.Size(224, 24);
            this.comboBoxChannels.TabIndex = 25;
            this.comboBoxChannels.SelectedIndexChanged += new System.EventHandler(this.comboBoxChannels_SelectedIndexChanged);
            // 
            // comboBoxLogicOperator
            // 
            this.comboBoxLogicOperator.FormattingEnabled = true;
            this.comboBoxLogicOperator.Location = new System.Drawing.Point(249, 109);
            this.comboBoxLogicOperator.Name = "comboBoxLogicOperator";
            this.comboBoxLogicOperator.Size = new System.Drawing.Size(93, 24);
            this.comboBoxLogicOperator.TabIndex = 24;
            // 
            // comboBoxDiagnostics
            // 
            this.comboBoxDiagnostics.FormattingEnabled = true;
            this.comboBoxDiagnostics.Location = new System.Drawing.Point(118, 297);
            this.comboBoxDiagnostics.Name = "comboBoxDiagnostics";
            this.comboBoxDiagnostics.Size = new System.Drawing.Size(224, 24);
            this.comboBoxDiagnostics.TabIndex = 22;
            // 
            // labelPCIP
            // 
            this.labelPCIP.AutoSize = true;
            this.labelPCIP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPCIP.Location = new System.Drawing.Point(41, 260);
            this.labelPCIP.Name = "labelPCIP";
            this.labelPCIP.Size = new System.Drawing.Size(72, 16);
            this.labelPCIP.TabIndex = 21;
            this.labelPCIP.Text = "Remote IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Diagnostics:";
            // 
            // textBoxDeviceIP
            // 
            this.textBoxDeviceIP.Location = new System.Drawing.Point(119, 260);
            this.textBoxDeviceIP.Name = "textBoxDeviceIP";
            this.textBoxDeviceIP.Size = new System.Drawing.Size(149, 23);
            this.textBoxDeviceIP.TabIndex = 9;
            // 
            // comboBoxImageSaving
            // 
            this.comboBoxImageSaving.FormattingEnabled = true;
            this.comboBoxImageSaving.Location = new System.Drawing.Point(119, 221);
            this.comboBoxImageSaving.Name = "comboBoxImageSaving";
            this.comboBoxImageSaving.Size = new System.Drawing.Size(223, 24);
            this.comboBoxImageSaving.TabIndex = 19;
            this.comboBoxImageSaving.SelectedIndexChanged += new System.EventHandler(this.comboBoxImageSaving_SelectedIndexChanged);
            // 
            // comboBoxFieldbus
            // 
            this.comboBoxFieldbus.FormattingEnabled = true;
            this.comboBoxFieldbus.Location = new System.Drawing.Point(119, 188);
            this.comboBoxFieldbus.Name = "comboBoxFieldbus";
            this.comboBoxFieldbus.Size = new System.Drawing.Size(224, 24);
            this.comboBoxFieldbus.TabIndex = 18;
            // 
            // comboBoxAnalysis
            // 
            this.comboBoxAnalysis.FormattingEnabled = true;
            this.comboBoxAnalysis.Location = new System.Drawing.Point(119, 109);
            this.comboBoxAnalysis.Name = "comboBoxAnalysis";
            this.comboBoxAnalysis.Size = new System.Drawing.Size(124, 24);
            this.comboBoxAnalysis.TabIndex = 17;
            this.comboBoxAnalysis.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnalysis_SelectedIndexChanged_1);
            // 
            // comboBoxModes
            // 
            this.comboBoxModes.FormattingEnabled = true;
            this.comboBoxModes.Location = new System.Drawing.Point(119, 77);
            this.comboBoxModes.Name = "comboBoxModes";
            this.comboBoxModes.Size = new System.Drawing.Size(224, 24);
            this.comboBoxModes.TabIndex = 16;
            this.comboBoxModes.SelectedIndexChanged += new System.EventHandler(this.comboBoxModes_SelectedIndexChanged);
            // 
            // comboBoxCode2
            // 
            this.comboBoxCode2.FormattingEnabled = true;
            this.comboBoxCode2.Location = new System.Drawing.Point(249, 44);
            this.comboBoxCode2.Name = "comboBoxCode2";
            this.comboBoxCode2.Size = new System.Drawing.Size(94, 24);
            this.comboBoxCode2.TabIndex = 15;
            this.comboBoxCode2.SelectedIndexChanged += new System.EventHandler(this.OnComboBoxSelectedChange);
            // 
            // comboBoxCode1
            // 
            this.comboBoxCode1.FormattingEnabled = true;
            this.comboBoxCode1.Location = new System.Drawing.Point(119, 44);
            this.comboBoxCode1.Name = "comboBoxCode1";
            this.comboBoxCode1.Size = new System.Drawing.Size(100, 24);
            this.comboBoxCode1.TabIndex = 9;
            this.comboBoxCode1.SelectedIndexChanged += new System.EventHandler(this.OnComboBoxSelectedChange);
            this.comboBoxCode1.SizeChanged += new System.EventHandler(this.comboBoxImageSaving_SelectedIndexChanged);
            // 
            // labelImageSaving
            // 
            this.labelImageSaving.AutoSize = true;
            this.labelImageSaving.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImageSaving.Location = new System.Drawing.Point(17, 226);
            this.labelImageSaving.Name = "labelImageSaving";
            this.labelImageSaving.Size = new System.Drawing.Size(91, 16);
            this.labelImageSaving.TabIndex = 13;
            this.labelImageSaving.Text = "Image Saving:";
            // 
            // labelFieldbus
            // 
            this.labelFieldbus.AutoSize = true;
            this.labelFieldbus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFieldbus.Location = new System.Drawing.Point(18, 193);
            this.labelFieldbus.Name = "labelFieldbus";
            this.labelFieldbus.Size = new System.Drawing.Size(60, 16);
            this.labelFieldbus.TabIndex = 12;
            this.labelFieldbus.Text = "Fieldbus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Analysis: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelModes
            // 
            this.labelModes.AutoSize = true;
            this.labelModes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModes.Location = new System.Drawing.Point(17, 82);
            this.labelModes.Name = "labelModes";
            this.labelModes.Size = new System.Drawing.Size(50, 16);
            this.labelModes.TabIndex = 10;
            this.labelModes.Text = "Modes:";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(18, 49);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(52, 16);
            this.labelCode.TabIndex = 9;
            this.labelCode.Text = "Codes: ";
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(238, 508);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.Location = new System.Drawing.Point(324, 508);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Done";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // radioButtonUserDefined
            // 
            this.radioButtonUserDefined.AutoSize = true;
            this.radioButtonUserDefined.Location = new System.Drawing.Point(118, 18);
            this.radioButtonUserDefined.Name = "radioButtonUserDefined";
            this.radioButtonUserDefined.Size = new System.Drawing.Size(99, 20);
            this.radioButtonUserDefined.TabIndex = 28;
            this.radioButtonUserDefined.TabStop = true;
            this.radioButtonUserDefined.Text = "User-defined";
            this.radioButtonUserDefined.UseVisualStyleBackColor = true;
            this.radioButtonUserDefined.CheckedChanged += new System.EventHandler(this.radioButtonUserDefined_CheckedChanged);
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Location = new System.Drawing.Point(14, 18);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(66, 20);
            this.radioButtonDefault.TabIndex = 29;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Default";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            this.radioButtonDefault.CheckedChanged += new System.EventHandler(this.radioButtonDefault_CheckedChanged);
            // 
            // FormBaseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 557);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.groupBoxContains);
            this.Controls.Add(this.groupBoxDeviceInfo);
            this.Name = "FormBaseApp";
            this.Text = "Pre-release Check List Wizard";
            this.Load += new System.EventHandler(this.FormBaseApp_Load);
            this.groupBoxDeviceInfo.ResumeLayout(false);
            this.groupBoxDeviceInfo.PerformLayout();
            this.groupBoxContains.ResumeLayout(false);
            this.groupBoxContains.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMatrixType;
        private System.Windows.Forms.Label labelCurrentFW;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.GroupBox groupBoxDeviceInfo;
        private System.Windows.Forms.Label labelUpgradeTo;
        private System.Windows.Forms.ComboBox comboBoxMatrixType;
        private System.Windows.Forms.GroupBox groupBoxContains;
        private System.Windows.Forms.ComboBox comboBoxCode2;
        private System.Windows.Forms.ComboBox comboBoxCode1;
        private System.Windows.Forms.Label labelImageSaving;
        private System.Windows.Forms.Label labelFieldbus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelModes;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.ComboBox comboBoxModes;
        private System.Windows.Forms.ComboBox comboBoxAnalysis;
        private System.Windows.Forms.ComboBox comboBoxFieldbus;
        private System.Windows.Forms.ComboBox comboBoxImageSaving;
        private System.Windows.Forms.TextBox textBoxDeviceIP;
        private System.Windows.Forms.Label labelPCIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDiagnostics;
        private System.Windows.Forms.ComboBox comboBoxUpgradeTo;
        private System.Windows.Forms.ComboBox comboBoxCurrentFW;
        private System.Windows.Forms.ComboBox comboBoxUpgradeFrom;
        private System.Windows.Forms.ComboBox comboBoxLogicOperator;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label labelChannels;
        private System.Windows.Forms.ComboBox comboBoxChannels;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.RadioButton radioButtonUserDefined;
    }
}

