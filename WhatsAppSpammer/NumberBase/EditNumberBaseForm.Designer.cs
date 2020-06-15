namespace WhatsAppSpammer.NumberBase
{
    partial class EditNumberBaseForm
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxNumbers = new System.Windows.Forms.ComboBox();
            this.labelPhoneNumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxNumbers
            // 
            this.comboBoxNumbers.FormattingEnabled = true;
            this.comboBoxNumbers.Location = new System.Drawing.Point(185, 12);
            this.comboBoxNumbers.Name = "comboBoxNumbers";
            this.comboBoxNumbers.Size = new System.Drawing.Size(142, 21);
            this.comboBoxNumbers.TabIndex = 1;
            // 
            // labelPhoneNumbers
            // 
            this.labelPhoneNumbers.AutoSize = true;
            this.labelPhoneNumbers.Location = new System.Drawing.Point(93, 17);
            this.labelPhoneNumbers.Name = "labelPhoneNumbers";
            this.labelPhoneNumbers.Size = new System.Drawing.Size(86, 13);
            this.labelPhoneNumbers.TabIndex = 4;
            this.labelPhoneNumbers.Text = "Phone Numbers:";
            // 
            // EditNumberBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 44);
            this.Controls.Add(this.labelPhoneNumbers);
            this.Controls.Add(this.comboBoxNumbers);
            this.Controls.Add(this.buttonDelete);
            this.Name = "EditNumberBaseForm";
            this.Text = "EditNumberBaseForm";
            this.Load += new System.EventHandler(this.EditNumberBaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxNumbers;
        private System.Windows.Forms.Label labelPhoneNumbers;
    }
}