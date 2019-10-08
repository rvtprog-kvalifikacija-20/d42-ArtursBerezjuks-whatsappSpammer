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
            this.buttonChangeAndSaveSettings = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonChangePath = new System.Windows.Forms.Button();
            this.labelChangePath = new System.Windows.Forms.Label();
            this.labelToken = new System.Windows.Forms.Label();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.labelServerAnswer = new System.Windows.Forms.Label();
            this.labelPhoneNumbers = new System.Windows.Forms.Label();
            this.labelSelectadBases = new System.Windows.Forms.Label();
            this.labelPhoneNumberBases = new System.Windows.Forms.Label();
            this.listBoxServerAnswers = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listBoxPhoneNumbers = new System.Windows.Forms.ListBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.listBoxSelectedPhoneBases = new System.Windows.Forms.ListBox();
            this.listBoxPhoneBases = new System.Windows.Forms.ListBox();
            this.buttonSendMessages = new System.Windows.Forms.Button();
            this.listBoxQueue = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabMessages.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 1;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.buttonChangeAndSaveSettings);
            this.tabSettings.Controls.Add(this.textBoxPath);
            this.tabSettings.Controls.Add(this.labelPath);
            this.tabSettings.Controls.Add(this.buttonChangePath);
            this.tabSettings.Controls.Add(this.labelChangePath);
            this.tabSettings.Controls.Add(this.labelToken);
            this.tabSettings.Controls.Add(this.textBoxToken);
            this.tabSettings.Controls.Add(this.labelURL);
            this.tabSettings.Controls.Add(this.textBoxURL);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(792, 424);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // buttonChangeAndSaveSettings
            // 
            this.buttonChangeAndSaveSettings.Enabled = false;
            this.buttonChangeAndSaveSettings.Location = new System.Drawing.Point(9, 119);
            this.buttonChangeAndSaveSettings.Name = "buttonChangeAndSaveSettings";
            this.buttonChangeAndSaveSettings.Size = new System.Drawing.Size(252, 23);
            this.buttonChangeAndSaveSettings.TabIndex = 9;
            this.buttonChangeAndSaveSettings.Text = "Change and save settings";
            this.buttonChangeAndSaveSettings.UseVisualStyleBackColor = true;
            this.buttonChangeAndSaveSettings.Click += new System.EventHandler(this.buttonChangeAndSaveSettings_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(50, 84);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(211, 20);
            this.textBoxPath.TabIndex = 8;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(6, 87);
            this.labelPath.Name = "labelPath";
            this.labelPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPath.Size = new System.Drawing.Size(35, 13);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = "Path: ";
            // 
            // buttonChangePath
            // 
            this.buttonChangePath.Location = new System.Drawing.Point(159, 55);
            this.buttonChangePath.Name = "buttonChangePath";
            this.buttonChangePath.Size = new System.Drawing.Size(102, 23);
            this.buttonChangePath.TabIndex = 6;
            this.buttonChangePath.Text = "Select folder";
            this.buttonChangePath.UseVisualStyleBackColor = true;
            this.buttonChangePath.Click += new System.EventHandler(this.buttonpath_Click);
            // 
            // labelChangePath
            // 
            this.labelChangePath.AutoSize = true;
            this.labelChangePath.Location = new System.Drawing.Point(6, 58);
            this.labelChangePath.Name = "labelChangePath";
            this.labelChangePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelChangePath.Size = new System.Drawing.Size(147, 13);
            this.labelChangePath.TabIndex = 5;
            this.labelChangePath.Text = "Change path to phone bases:";
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Location = new System.Drawing.Point(3, 32);
            this.labelToken.Name = "labelToken";
            this.labelToken.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelToken.Size = new System.Drawing.Size(41, 13);
            this.labelToken.TabIndex = 3;
            this.labelToken.Text = "Token:";
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(50, 29);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(211, 20);
            this.textBoxToken.TabIndex = 2;
            this.textBoxToken.Text = "\r\n\r\n\r\n\r\n\r\n\r\n";
            this.textBoxToken.TextChanged += new System.EventHandler(this.textBoxToken_TextChanged);
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(3, 6);
            this.labelURL.Name = "labelURL";
            this.labelURL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelURL.Size = new System.Drawing.Size(32, 13);
            this.labelURL.TabIndex = 1;
            this.labelURL.Text = "URL:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(50, 3);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(211, 20);
            this.textBoxURL.TabIndex = 0;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // tabMessages
            // 
            this.tabMessages.Controls.Add(this.listBoxQueue);
            this.tabMessages.Controls.Add(this.labelServerAnswer);
            this.tabMessages.Controls.Add(this.labelPhoneNumbers);
            this.tabMessages.Controls.Add(this.labelSelectadBases);
            this.tabMessages.Controls.Add(this.labelPhoneNumberBases);
            this.tabMessages.Controls.Add(this.listBoxServerAnswers);
            this.tabMessages.Controls.Add(this.progressBar);
            this.tabMessages.Controls.Add(this.listBoxPhoneNumbers);
            this.tabMessages.Controls.Add(this.richTextBoxMessage);
            this.tabMessages.Controls.Add(this.listBoxSelectedPhoneBases);
            this.tabMessages.Controls.Add(this.listBoxPhoneBases);
            this.tabMessages.Controls.Add(this.buttonSendMessages);
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessages.Size = new System.Drawing.Size(792, 424);
            this.tabMessages.TabIndex = 1;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // labelServerAnswer
            // 
            this.labelServerAnswer.AutoSize = true;
            this.labelServerAnswer.Location = new System.Drawing.Point(8, 153);
            this.labelServerAnswer.Name = "labelServerAnswer";
            this.labelServerAnswer.Size = new System.Drawing.Size(83, 13);
            this.labelServerAnswer.TabIndex = 12;
            this.labelServerAnswer.Text = "Server answers:";
            // 
            // labelPhoneNumbers
            // 
            this.labelPhoneNumbers.AutoSize = true;
            this.labelPhoneNumbers.Location = new System.Drawing.Point(313, 6);
            this.labelPhoneNumbers.Name = "labelPhoneNumbers";
            this.labelPhoneNumbers.Size = new System.Drawing.Size(80, 13);
            this.labelPhoneNumbers.TabIndex = 11;
            this.labelPhoneNumbers.Text = "PhoneNumbers";
            // 
            // labelSelectadBases
            // 
            this.labelSelectadBases.AutoSize = true;
            this.labelSelectadBases.Location = new System.Drawing.Point(157, 6);
            this.labelSelectadBases.Name = "labelSelectadBases";
            this.labelSelectadBases.Size = new System.Drawing.Size(80, 13);
            this.labelSelectadBases.TabIndex = 10;
            this.labelSelectadBases.Text = "Selected bases";
            // 
            // labelPhoneNumberBases
            // 
            this.labelPhoneNumberBases.AutoSize = true;
            this.labelPhoneNumberBases.Location = new System.Drawing.Point(6, 6);
            this.labelPhoneNumberBases.Name = "labelPhoneNumberBases";
            this.labelPhoneNumberBases.Size = new System.Drawing.Size(112, 13);
            this.labelPhoneNumberBases.TabIndex = 9;
            this.labelPhoneNumberBases.Text = "Phone numbers bases";
            // 
            // listBoxServerAnswers
            // 
            this.listBoxServerAnswers.FormattingEnabled = true;
            this.listBoxServerAnswers.Location = new System.Drawing.Point(8, 169);
            this.listBoxServerAnswers.Name = "listBoxServerAnswers";
            this.listBoxServerAnswers.Size = new System.Drawing.Size(428, 238);
            this.listBoxServerAnswers.TabIndex = 8;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(8, 413);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 11);
            this.progressBar.TabIndex = 7;
            // 
            // listBoxPhoneNumbers
            // 
            this.listBoxPhoneNumbers.FormattingEnabled = true;
            this.listBoxPhoneNumbers.Location = new System.Drawing.Point(316, 23);
            this.listBoxPhoneNumbers.Name = "listBoxPhoneNumbers";
            this.listBoxPhoneNumbers.Size = new System.Drawing.Size(120, 108);
            this.listBoxPhoneNumbers.TabIndex = 6;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBoxMessage.Location = new System.Drawing.Point(471, 12);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(303, 96);
            this.richTextBoxMessage.TabIndex = 5;
            this.richTextBoxMessage.Text = "";
            // 
            // listBoxSelectedPhoneBases
            // 
            this.listBoxSelectedPhoneBases.FormattingEnabled = true;
            this.listBoxSelectedPhoneBases.Location = new System.Drawing.Point(160, 23);
            this.listBoxSelectedPhoneBases.Name = "listBoxSelectedPhoneBases";
            this.listBoxSelectedPhoneBases.Size = new System.Drawing.Size(120, 108);
            this.listBoxSelectedPhoneBases.TabIndex = 4;
            this.listBoxSelectedPhoneBases.Click += new System.EventHandler(this.listBoxSelectedPhoneBases_Click);
            this.listBoxSelectedPhoneBases.DoubleClick += new System.EventHandler(this.listBoxSelectedPhoneBases_DoubleClick);
            // 
            // listBoxPhoneBases
            // 
            this.listBoxPhoneBases.FormattingEnabled = true;
            this.listBoxPhoneBases.Location = new System.Drawing.Point(8, 23);
            this.listBoxPhoneBases.Name = "listBoxPhoneBases";
            this.listBoxPhoneBases.Size = new System.Drawing.Size(120, 108);
            this.listBoxPhoneBases.TabIndex = 2;
            this.listBoxPhoneBases.DoubleClick += new System.EventHandler(this.listBoxPhoneBases_DoubleClick);
            // 
            // buttonSendMessages
            // 
            this.buttonSendMessages.Location = new System.Drawing.Point(471, 114);
            this.buttonSendMessages.Name = "buttonSendMessages";
            this.buttonSendMessages.Size = new System.Drawing.Size(303, 23);
            this.buttonSendMessages.TabIndex = 0;
            this.buttonSendMessages.Text = "Send message";
            this.buttonSendMessages.UseVisualStyleBackColor = true;
            this.buttonSendMessages.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // listBoxQueue
            // 
            this.listBoxQueue.FormattingEnabled = true;
            this.listBoxQueue.Location = new System.Drawing.Point(442, 169);
            this.listBoxQueue.Name = "listBoxQueue";
            this.listBoxQueue.Size = new System.Drawing.Size(332, 238);
            this.listBoxQueue.TabIndex = 13;
            // 
            // WhatsAppSpammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "WhatsAppSpammer";
            this.Text = "WhatsappSpammer";
            this.tabControl.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabMessages.ResumeLayout(false);
            this.tabMessages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label labelChangePath;
        private System.Windows.Forms.Button buttonChangePath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonSendMessages;
        private System.Windows.Forms.ListBox listBoxPhoneBases;
        private System.Windows.Forms.ListBox listBoxSelectedPhoneBases;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.ListBox listBoxPhoneNumbers;
        private System.Windows.Forms.Label labelPhoneNumberBases;
        private System.Windows.Forms.ListBox listBoxServerAnswers;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelSelectadBases;
        private System.Windows.Forms.Label labelPhoneNumbers;
        private System.Windows.Forms.Label labelServerAnswer;
        private System.Windows.Forms.Button buttonChangeAndSaveSettings;
        private System.Windows.Forms.ListBox listBoxQueue;
    }
}

