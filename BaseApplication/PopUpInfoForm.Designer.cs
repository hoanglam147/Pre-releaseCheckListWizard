namespace BaseApplication
{
    partial class PopUpInfoForm
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
            this.labelusrname = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelTestPlanId = new System.Windows.Forms.Label();
            this.labelBuildRecord = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxtestPlan = new System.Windows.Forms.TextBox();
            this.textBoxbuildRecord = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelusrname
            // 
            this.labelusrname.AutoSize = true;
            this.labelusrname.Location = new System.Drawing.Point(38, 29);
            this.labelusrname.Name = "labelusrname";
            this.labelusrname.Size = new System.Drawing.Size(58, 13);
            this.labelusrname.TabIndex = 0;
            this.labelusrname.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(38, 56);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelTestPlanId
            // 
            this.labelTestPlanId.AutoSize = true;
            this.labelTestPlanId.Location = new System.Drawing.Point(38, 85);
            this.labelTestPlanId.Name = "labelTestPlanId";
            this.labelTestPlanId.Size = new System.Drawing.Size(64, 13);
            this.labelTestPlanId.TabIndex = 2;
            this.labelTestPlanId.Text = "Test Plan Id";
            // 
            // labelBuildRecord
            // 
            this.labelBuildRecord.AutoSize = true;
            this.labelBuildRecord.Location = new System.Drawing.Point(38, 114);
            this.labelBuildRecord.Name = "labelBuildRecord";
            this.labelBuildRecord.Size = new System.Drawing.Size(68, 13);
            this.labelBuildRecord.TabIndex = 3;
            this.labelBuildRecord.Text = "Build Record";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(129, 26);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(129, 53);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // textBoxtestPlan
            // 
            this.textBoxtestPlan.Location = new System.Drawing.Point(129, 82);
            this.textBoxtestPlan.Name = "textBoxtestPlan";
            this.textBoxtestPlan.Size = new System.Drawing.Size(100, 20);
            this.textBoxtestPlan.TabIndex = 6;
            // 
            // textBoxbuildRecord
            // 
            this.textBoxbuildRecord.Location = new System.Drawing.Point(129, 114);
            this.textBoxbuildRecord.Name = "textBoxbuildRecord";
            this.textBoxbuildRecord.Size = new System.Drawing.Size(100, 20);
            this.textBoxbuildRecord.TabIndex = 7;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(84, 159);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(176, 159);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PopUpInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 205);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxbuildRecord);
            this.Controls.Add(this.textBoxtestPlan);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelBuildRecord);
            this.Controls.Add(this.labelTestPlanId);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelusrname);
            this.Name = "PopUpInfoForm";
            this.Text = "Jazz Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PopUpInfoForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelusrname;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelTestPlanId;
        private System.Windows.Forms.Label labelBuildRecord;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxtestPlan;
        private System.Windows.Forms.TextBox textBoxbuildRecord;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}