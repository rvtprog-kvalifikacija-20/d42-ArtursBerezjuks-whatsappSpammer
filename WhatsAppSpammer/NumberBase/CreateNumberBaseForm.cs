using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using WhatsappSpammer;
using WhatsAppSpammer.Numbers;

namespace WhatsAppSpammer.NumberBase
{
    public partial class CreateNumberBaseForm : Form
    {
        public WhatsappSpammerContext DB;
        public CreateNumberBaseForm(WhatsappSpammerContext context)
        {
            DB = context;
            InitializeComponent();
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateNumberBase_Click(object sender, EventArgs e)
        {
            
            List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();

            FileReader.ReadFile(textBoxPath.Text).ForEach(i => phoneNumbers.Add(new PhoneNumber(i, null, null, null, null)));
            DB.NumberBase.Add(
                new NumberBase(
                    textBoxName.Text,
                    phoneNumbers,
                    new Message(textBoxMessage.Text)
                    )
                );
            try
            {
                DB.SaveChanges();

                MessageBox.Show("Ad company successfully added!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ad company not added, something went wrong");
            }
        }

        private void buttonsSelectFile_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            textBoxPath.Text = filePath;
        }
    }
}
