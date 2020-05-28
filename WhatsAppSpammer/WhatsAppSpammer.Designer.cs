﻿namespace WhatsAppSpammer
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
            this.Settings.Location = new System.Drawing.Point(29, 208);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(311, 23);
            this.Settings.TabIndex = 55;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(143, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(197, 20);
            this.textBoxName.TabIndex = 53;
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
            this.buttonEmulatorRun.Location = new System.Drawing.Point(29, 181);
            this.buttonEmulatorRun.Name = "buttonEmulatorRun";
            this.buttonEmulatorRun.Size = new System.Drawing.Size(311, 21);
            this.buttonEmulatorRun.TabIndex = 47;
            this.buttonEmulatorRun.Text = "Run emulator, Import contacts and Register whatsapp";
            this.buttonEmulatorRun.UseVisualStyleBackColor = true;
            this.buttonEmulatorRun.Click += new System.EventHandler(this.buttonEmulator_Click);
            // 
            // textBoxAppiumPort
            // 
            this.textBoxAppiumPort.Location = new System.Drawing.Point(132, 103);
            this.textBoxAppiumPort.Name = "textBoxAppiumPort";
            this.textBoxAppiumPort.Size = new System.Drawing.Size(208, 20);
            this.textBoxAppiumPort.TabIndex = 59;
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
            // WhatsAppSpammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 243);
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
    }
}

