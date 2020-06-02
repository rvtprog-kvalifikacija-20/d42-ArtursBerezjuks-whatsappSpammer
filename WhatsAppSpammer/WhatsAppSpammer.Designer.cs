namespace WhatsAppSpammer
{
    partial class WhatsAppSpammer
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
            this.labelProxy = new System.Windows.Forms.Label();
            this.labelDevice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxProxy = new System.Windows.Forms.TextBox();
            this.buttonGetProxy = new System.Windows.Forms.Button();
            this.comboBoxAppium = new System.Windows.Forms.ComboBox();
            this.buttonEmulatorRun = new System.Windows.Forms.Button();
            this.textBoxAppiumPort = new System.Windows.Forms.TextBox();
            this.labelAppiumPort = new System.Windows.Forms.Label();
            this.labelSmsRegistrator = new System.Windows.Forms.Label();
            this.comboBoxSmsRegistrator = new System.Windows.Forms.ComboBox();
            this.comboBoxAdCompanies = new System.Windows.Forms.ComboBox();
            this.labelAdCompany = new System.Windows.Forms.Label();
            this.buttonNumberBase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProxy
            // 
            this.labelProxy.AutoSize = true;
            this.labelProxy.Location = new System.Drawing.Point(29, 76);
            this.labelProxy.Name = "labelProxy";
            this.labelProxy.Size = new System.Drawing.Size(33, 13);
            this.labelProxy.TabIndex = 58;
            this.labelProxy.Text = "Proxy";
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Location = new System.Drawing.Point(29, 51);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(41, 13);
            this.labelDevice.TabIndex = 57;
            this.labelDevice.Text = "Device";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "WhatsApp Nickname";
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(29, 274);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(311, 23);
            this.Settings.TabIndex = 55;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(143, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(197, 20);
            this.textBoxName.TabIndex = 53;
            this.textBoxName.Text = "Nick";
            // 
            // textBoxProxy
            // 
            this.textBoxProxy.Location = new System.Drawing.Point(68, 77);
            this.textBoxProxy.Name = "textBoxProxy";
            this.textBoxProxy.Size = new System.Drawing.Size(205, 20);
            this.textBoxProxy.TabIndex = 48;
            // 
            // buttonGetProxy
            // 
            this.buttonGetProxy.Location = new System.Drawing.Point(279, 76);
            this.buttonGetProxy.Name = "buttonGetProxy";
            this.buttonGetProxy.Size = new System.Drawing.Size(61, 23);
            this.buttonGetProxy.TabIndex = 49;
            this.buttonGetProxy.Text = "Get proxy";
            this.buttonGetProxy.UseVisualStyleBackColor = true;
            this.buttonGetProxy.Click += new System.EventHandler(this.buttonGetProxy_Click);
            // 
            // comboBoxAppium
            // 
            this.comboBoxAppium.FormattingEnabled = true;
            this.comboBoxAppium.Location = new System.Drawing.Point(76, 47);
            this.comboBoxAppium.Name = "comboBoxAppium";
            this.comboBoxAppium.Size = new System.Drawing.Size(264, 21);
            this.comboBoxAppium.TabIndex = 45;
            // 
            // buttonEmulatorRun
            // 
            this.buttonEmulatorRun.Location = new System.Drawing.Point(29, 247);
            this.buttonEmulatorRun.Name = "buttonEmulatorRun";
            this.buttonEmulatorRun.Size = new System.Drawing.Size(311, 21);
            this.buttonEmulatorRun.TabIndex = 47;
            this.buttonEmulatorRun.Text = "Run emulator, Import contacts and Register whatsapp";
            this.buttonEmulatorRun.UseVisualStyleBackColor = true;
            this.buttonEmulatorRun.Click += new System.EventHandler(this.buttonEmulatorRun_Click);
            // 
            // textBoxAppiumPort
            // 
            this.textBoxAppiumPort.Location = new System.Drawing.Point(132, 103);
            this.textBoxAppiumPort.Name = "textBoxAppiumPort";
            this.textBoxAppiumPort.Size = new System.Drawing.Size(208, 20);
            this.textBoxAppiumPort.TabIndex = 59;
            this.textBoxAppiumPort.Text = "4723";
            // 
            // labelAppiumPort
            // 
            this.labelAppiumPort.AutoSize = true;
            this.labelAppiumPort.Location = new System.Drawing.Point(29, 106);
            this.labelAppiumPort.Name = "labelAppiumPort";
            this.labelAppiumPort.Size = new System.Drawing.Size(97, 13);
            this.labelAppiumPort.TabIndex = 60;
            this.labelAppiumPort.Text = "Appium Server port";
            // 
            // labelSmsRegistrator
            // 
            this.labelSmsRegistrator.AutoSize = true;
            this.labelSmsRegistrator.Location = new System.Drawing.Point(29, 132);
            this.labelSmsRegistrator.Name = "labelSmsRegistrator";
            this.labelSmsRegistrator.Size = new System.Drawing.Size(76, 13);
            this.labelSmsRegistrator.TabIndex = 62;
            this.labelSmsRegistrator.Text = "Sms registrator";
            // 
            // comboBoxSmsRegistrator
            // 
            this.comboBoxSmsRegistrator.FormattingEnabled = true;
            this.comboBoxSmsRegistrator.Items.AddRange(new object[] {
            "SmsActivate",
            "Registrator5SIM"});
            this.comboBoxSmsRegistrator.Location = new System.Drawing.Point(111, 129);
            this.comboBoxSmsRegistrator.Name = "comboBoxSmsRegistrator";
            this.comboBoxSmsRegistrator.Size = new System.Drawing.Size(229, 21);
            this.comboBoxSmsRegistrator.TabIndex = 63;
            this.comboBoxSmsRegistrator.Text = "SmsActivate";
            // 
            // comboBoxAdCompanies
            // 
            this.comboBoxAdCompanies.FormattingEnabled = true;
            this.comboBoxAdCompanies.Location = new System.Drawing.Point(98, 159);
            this.comboBoxAdCompanies.Name = "comboBoxAdCompanies";
            this.comboBoxAdCompanies.Size = new System.Drawing.Size(242, 21);
            this.comboBoxAdCompanies.TabIndex = 64;
            // 
            // labelAdCompany
            // 
            this.labelAdCompany.AutoSize = true;
            this.labelAdCompany.Location = new System.Drawing.Point(26, 159);
            this.labelAdCompany.Name = "labelAdCompany";
            this.labelAdCompany.Size = new System.Drawing.Size(66, 13);
            this.labelAdCompany.TabIndex = 65;
            this.labelAdCompany.Text = "Ad company";
            // 
            // buttonNumberBase
            // 
            this.buttonNumberBase.Location = new System.Drawing.Point(29, 218);
            this.buttonNumberBase.Name = "buttonNumberBase";
            this.buttonNumberBase.Size = new System.Drawing.Size(311, 23);
            this.buttonNumberBase.TabIndex = 67;
            this.buttonNumberBase.Text = "Create advertisment company";
            this.buttonNumberBase.UseVisualStyleBackColor = true;
            this.buttonNumberBase.Click += new System.EventHandler(this.buttonNumberBase_Click);
            // 
            // WhatsAppSpammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 320);
            this.Controls.Add(this.buttonNumberBase);
            this.Controls.Add(this.labelAdCompany);
            this.Controls.Add(this.comboBoxAdCompanies);
            this.Controls.Add(this.comboBoxSmsRegistrator);
            this.Controls.Add(this.labelSmsRegistrator);
            this.Controls.Add(this.labelAppiumPort);
            this.Controls.Add(this.textBoxAppiumPort);
            this.Controls.Add(this.labelProxy);
            this.Controls.Add(this.labelDevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxProxy);
            this.Controls.Add(this.buttonGetProxy);
            this.Controls.Add(this.buttonEmulatorRun);
            this.Controls.Add(this.comboBoxAppium);
            this.Name = "WhatsAppSpammer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WhatsappSpammer";
            this.Load += new System.EventHandler(this.WhatsAppSpammer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProxy;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxProxy;
        private System.Windows.Forms.Button buttonGetProxy;
        private System.Windows.Forms.ComboBox comboBoxAppium;
        private System.Windows.Forms.Button buttonEmulatorRun;
        private System.Windows.Forms.TextBox textBoxAppiumPort;
        private System.Windows.Forms.Label labelAppiumPort;
        private System.Windows.Forms.Label labelSmsRegistrator;
        private System.Windows.Forms.ComboBox comboBoxSmsRegistrator;
        private System.Windows.Forms.ComboBox comboBoxAdCompanies;
        private System.Windows.Forms.Label labelAdCompany;
        private System.Windows.Forms.Button buttonNumberBase;
    }
}

