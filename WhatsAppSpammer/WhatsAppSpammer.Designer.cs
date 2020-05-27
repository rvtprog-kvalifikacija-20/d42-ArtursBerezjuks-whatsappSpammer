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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.labelProxy = new System.Windows.Forms.Label();
            this.labelDevice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.buttonEmulator = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAppiumContacts = new System.Windows.Forms.Button();
            this.buttonGenerateVcard = new System.Windows.Forms.Button();
            this.buttonSendVcard = new System.Windows.Forms.Button();
            this.buttonGetProxy = new System.Windows.Forms.Button();
            this.textBoxProxy = new System.Windows.Forms.TextBox();
            this.buttonEmulatorRun = new System.Windows.Forms.Button();
            this.buttonAppiumRun = new System.Windows.Forms.Button();
            this.comboBoxAppium = new System.Windows.Forms.ComboBox();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabMessages);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(639, 457);
            this.tabControl.TabIndex = 1;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.labelProxy);
            this.tabSettings.Controls.Add(this.labelDevice);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Controls.Add(this.Settings);
            this.tabSettings.Controls.Add(this.buttonEmulator);
            this.tabSettings.Controls.Add(this.textBoxName);
            this.tabSettings.Controls.Add(this.buttonAppiumContacts);
            this.tabSettings.Controls.Add(this.buttonGenerateVcard);
            this.tabSettings.Controls.Add(this.buttonSendVcard);
            this.tabSettings.Controls.Add(this.buttonGetProxy);
            this.tabSettings.Controls.Add(this.textBoxProxy);
            this.tabSettings.Controls.Add(this.buttonEmulatorRun);
            this.tabSettings.Controls.Add(this.buttonAppiumRun);
            this.tabSettings.Controls.Add(this.comboBoxAppium);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(631, 431);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // labelProxy
            // 
            this.labelProxy.AutoSize = true;
            this.labelProxy.Location = new System.Drawing.Point(9, 61);
            this.labelProxy.Name = "labelProxy";
            this.labelProxy.Size = new System.Drawing.Size(33, 13);
            this.labelProxy.TabIndex = 44;
            this.labelProxy.Text = "Proxy";
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Location = new System.Drawing.Point(9, 36);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(41, 13);
            this.labelDevice.TabIndex = 43;
            this.labelDevice.Text = "Device";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "WhatsApp Nickname";
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(326, 146);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(298, 23);
            this.Settings.TabIndex = 41;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // buttonEmulator
            // 
            this.buttonEmulator.Location = new System.Drawing.Point(326, 32);
            this.buttonEmulator.Name = "buttonEmulator";
            this.buttonEmulator.Size = new System.Drawing.Size(298, 21);
            this.buttonEmulator.TabIndex = 37;
            this.buttonEmulator.Text = "Run emulator";
            this.buttonEmulator.UseVisualStyleBackColor = true;
            this.buttonEmulator.Click += new System.EventHandler(this.buttonEmulator_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(123, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(197, 20);
            this.textBoxName.TabIndex = 36;
            // 
            // buttonAppiumContacts
            // 
            this.buttonAppiumContacts.Location = new System.Drawing.Point(326, 90);
            this.buttonAppiumContacts.Name = "buttonAppiumContacts";
            this.buttonAppiumContacts.Size = new System.Drawing.Size(298, 21);
            this.buttonAppiumContacts.TabIndex = 35;
            this.buttonAppiumContacts.Text = "Run Contacts.apk";
            this.buttonAppiumContacts.UseVisualStyleBackColor = true;
            this.buttonAppiumContacts.Click += new System.EventHandler(this.buttonAppiumContacts_Click);
            // 
            // buttonGenerateVcard
            // 
            this.buttonGenerateVcard.Location = new System.Drawing.Point(326, 117);
            this.buttonGenerateVcard.Name = "buttonGenerateVcard";
            this.buttonGenerateVcard.Size = new System.Drawing.Size(100, 23);
            this.buttonGenerateVcard.TabIndex = 34;
            this.buttonGenerateVcard.Text = "generate vcard";
            this.buttonGenerateVcard.UseVisualStyleBackColor = true;
            this.buttonGenerateVcard.Click += new System.EventHandler(this.buttonGenerateVcard_Click);
            // 
            // buttonSendVcard
            // 
            this.buttonSendVcard.Location = new System.Drawing.Point(524, 117);
            this.buttonSendVcard.Name = "buttonSendVcard";
            this.buttonSendVcard.Size = new System.Drawing.Size(100, 23);
            this.buttonSendVcard.TabIndex = 33;
            this.buttonSendVcard.Text = "send vcard";
            this.buttonSendVcard.UseVisualStyleBackColor = true;
            this.buttonSendVcard.Click += new System.EventHandler(this.buttonSendVcard_Click);
            // 
            // buttonGetProxy
            // 
            this.buttonGetProxy.Location = new System.Drawing.Point(259, 61);
            this.buttonGetProxy.Name = "buttonGetProxy";
            this.buttonGetProxy.Size = new System.Drawing.Size(61, 23);
            this.buttonGetProxy.TabIndex = 23;
            this.buttonGetProxy.Text = "Get proxy";
            this.buttonGetProxy.UseVisualStyleBackColor = true;
            this.buttonGetProxy.Click += new System.EventHandler(this.buttonGetProxy_Click);
            // 
            // textBoxProxy
            // 
            this.textBoxProxy.Location = new System.Drawing.Point(48, 62);
            this.textBoxProxy.Name = "textBoxProxy";
            this.textBoxProxy.Size = new System.Drawing.Size(205, 20);
            this.textBoxProxy.TabIndex = 21;
            // 
            // buttonEmulatorRun
            // 
            this.buttonEmulatorRun.Location = new System.Drawing.Point(326, 4);
            this.buttonEmulatorRun.Name = "buttonEmulatorRun";
            this.buttonEmulatorRun.Size = new System.Drawing.Size(298, 21);
            this.buttonEmulatorRun.TabIndex = 15;
            this.buttonEmulatorRun.Text = "Run emulator, Import contacts and Register whatsapp";
            this.buttonEmulatorRun.UseVisualStyleBackColor = true;
            this.buttonEmulatorRun.Click += new System.EventHandler(this.buttonEmulatorRun_Click);
            // 
            // buttonAppiumRun
            // 
            this.buttonAppiumRun.Location = new System.Drawing.Point(326, 61);
            this.buttonAppiumRun.Name = "buttonAppiumRun";
            this.buttonAppiumRun.Size = new System.Drawing.Size(298, 21);
            this.buttonAppiumRun.TabIndex = 11;
            this.buttonAppiumRun.Text = "Run Whatsapp.apk";
            this.buttonAppiumRun.UseVisualStyleBackColor = true;
            this.buttonAppiumRun.Click += new System.EventHandler(this.buttonAppiumRun_Click);
            // 
            // comboBoxAppium
            // 
            this.comboBoxAppium.FormattingEnabled = true;
            this.comboBoxAppium.Location = new System.Drawing.Point(56, 32);
            this.comboBoxAppium.Name = "comboBoxAppium";
            this.comboBoxAppium.Size = new System.Drawing.Size(264, 21);
            this.comboBoxAppium.TabIndex = 10;
            this.comboBoxAppium.Text = "2_android_4.4_lv_gapi";
            // 
            // tabMessages
            // 
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessages.Size = new System.Drawing.Size(631, 431);
            this.tabMessages.TabIndex = 1;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // WhatsAppSpammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 457);
            this.Controls.Add(this.tabControl);
            this.Name = "WhatsAppSpammer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WhatsappSpammer";
            this.tabControl.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.Button buttonAppiumRun;
        private System.Windows.Forms.ComboBox comboBoxAppium;
        private System.Windows.Forms.Button buttonEmulatorRun;
        private System.Windows.Forms.TextBox textBoxProxy;
        private System.Windows.Forms.Button buttonGetProxy;
        private System.Windows.Forms.Button buttonGenerateVcard;
        private System.Windows.Forms.Button buttonSendVcard;
        private System.Windows.Forms.Button buttonAppiumContacts;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonEmulator;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Label labelProxy;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.Label label1;
    }
}

