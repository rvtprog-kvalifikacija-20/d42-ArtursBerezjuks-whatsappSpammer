namespace WhatsAppSpammer.DeviceController
{
    partial class DeviceControllerForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelProxy = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBoxLogger = new System.Windows.Forms.ListBox();
            this.labelNickname = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            // 
            // labelProxy
            // 
            this.labelProxy.AutoSize = true;
            this.labelProxy.Location = new System.Drawing.Point(12, 32);
            this.labelProxy.Name = "labelProxy";
            this.labelProxy.Size = new System.Drawing.Size(35, 13);
            this.labelProxy.TabIndex = 1;
            this.labelProxy.Text = "label2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 417);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // listBoxLogger
            // 
            this.listBoxLogger.FormattingEnabled = true;
            this.listBoxLogger.Location = new System.Drawing.Point(3, 160);
            this.listBoxLogger.Name = "listBoxLogger";
            this.listBoxLogger.Size = new System.Drawing.Size(256, 251);
            this.listBoxLogger.TabIndex = 3;
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Location = new System.Drawing.Point(140, 9);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(35, 13);
            this.labelNickname.TabIndex = 4;
            this.labelNickname.Text = "label3";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(140, 32);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(35, 13);
            this.labelNumber.TabIndex = 5;
            this.labelNumber.Text = "label4";
            // 
            // DeviceControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 450);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.listBoxLogger);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelProxy);
            this.Controls.Add(this.labelName);
            this.Name = "DeviceControllerForm";
            this.Text = "DeviceControllerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProxy;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBoxLogger;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Label labelNumber;
    }
}