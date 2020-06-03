namespace WhatsAppSpammer.NumberBase
{
    partial class CreateNumberBaseForm
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
            this.buttonCreateNumberBase = new System.Windows.Forms.Button();
            this.buttonsSelectFile = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelSelectFile = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCreateNumberBase
            // 
            this.buttonCreateNumberBase.Location = new System.Drawing.Point(301, 240);
            this.buttonCreateNumberBase.Name = "buttonCreateNumberBase";
            this.buttonCreateNumberBase.Size = new System.Drawing.Size(116, 23);
            this.buttonCreateNumberBase.TabIndex = 0;
            this.buttonCreateNumberBase.Text = "Create Number Base";
            this.buttonCreateNumberBase.UseVisualStyleBackColor = true;
            this.buttonCreateNumberBase.Click += new System.EventHandler(this.buttonCreateNumberBase_Click);
            // 
            // buttonsSelectFile
            // 
            this.buttonsSelectFile.Location = new System.Drawing.Point(342, 43);
            this.buttonsSelectFile.Name = "buttonsSelectFile";
            this.buttonsSelectFile.Size = new System.Drawing.Size(75, 23);
            this.buttonsSelectFile.TabIndex = 1;
            this.buttonsSelectFile.Text = "Select File";
            this.buttonsSelectFile.UseVisualStyleBackColor = true;
            this.buttonsSelectFile.Click += new System.EventHandler(this.buttonsSelectFile_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(121, 43);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(214, 20);
            this.textBoxPath.TabIndex = 2;
            // 
            // labelSelectFile
            // 
            this.labelSelectFile.AutoSize = true;
            this.labelSelectFile.Location = new System.Drawing.Point(12, 46);
            this.labelSelectFile.Name = "labelSelectFile";
            this.labelSelectFile.Size = new System.Drawing.Size(103, 13);
            this.labelSelectFile.TabIndex = 3;
            this.labelSelectFile.Text = "Number base .txt file";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(68, 74);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(349, 160);
            this.textBoxMessage.TabIndex = 4;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(111, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name of number base";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(129, 17);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(288, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // CreateNumberBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 277);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelSelectFile);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonsSelectFile);
            this.Controls.Add(this.buttonCreateNumberBase);
            this.Name = "CreateNumberBaseForm";
            this.Text = "CreateNumberBaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateNumberBase;
        private System.Windows.Forms.Button buttonsSelectFile;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelSelectFile;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
    }
}