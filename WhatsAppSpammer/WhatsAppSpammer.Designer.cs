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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonChangePath = new System.Windows.Forms.Button();
            this.labelChangePath = new System.Windows.Forms.Label();
            this.labelToken = new System.Windows.Forms.Label();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.listBoxPhoneBases = new System.Windows.Forms.ListBox();
            this.checkedListBoxPhoneBases = new System.Windows.Forms.CheckedListBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
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
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(50, 84);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(211, 20);
            this.textBoxPath.TabIndex = 8;
            this.textBoxPath.Text = "C:\\Users\\User\\source\\repos\\WhatsAppSpammer\\WhatsAppSpammer\\bin\\Debug\\phoneNumbers" +
    "";
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
            this.textBoxToken.Text = "ec7ua2ymrt7qgf7u";
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
            this.textBoxURL.Text = "https://eu46.chat-api.com/instance70930";
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // tabMessages
            // 
            this.tabMessages.Controls.Add(this.textBoxMessage);
            this.tabMessages.Controls.Add(this.listBoxPhoneBases);
            this.tabMessages.Controls.Add(this.checkedListBoxPhoneBases);
            this.tabMessages.Controls.Add(this.buttonTest);
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessages.Size = new System.Drawing.Size(792, 424);
            this.tabMessages.TabIndex = 1;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // listBoxPhoneBases
            // 
            this.listBoxPhoneBases.FormattingEnabled = true;
            this.listBoxPhoneBases.Location = new System.Drawing.Point(6, 6);
            this.listBoxPhoneBases.Name = "listBoxPhoneBases";
            this.listBoxPhoneBases.Size = new System.Drawing.Size(120, 407);
            this.listBoxPhoneBases.TabIndex = 2;
            this.listBoxPhoneBases.DoubleClick += new System.EventHandler(this.listBoxPhoneBases_DoubleClick);
            // 
            // checkedListBoxPhoneBases
            // 
            this.checkedListBoxPhoneBases.FormattingEnabled = true;
            this.checkedListBoxPhoneBases.Location = new System.Drawing.Point(132, 6);
            this.checkedListBoxPhoneBases.Name = "checkedListBoxPhoneBases";
            this.checkedListBoxPhoneBases.Size = new System.Drawing.Size(120, 409);
            this.checkedListBoxPhoneBases.TabIndex = 1;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(687, 6);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(97, 23);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "test message";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(258, 6);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(296, 20);
            this.textBoxMessage.TabIndex = 3;
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
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.CheckedListBox checkedListBoxPhoneBases;
        private System.Windows.Forms.ListBox listBoxPhoneBases;
        private System.Windows.Forms.TextBox textBoxMessage;
    }
}

