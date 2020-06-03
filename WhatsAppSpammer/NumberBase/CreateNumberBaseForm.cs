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
        public CreateNumberBaseForm()
        {
            InitializeComponent();
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateNumberBase_Click(object sender, EventArgs e)
        {
            using (WhatsappSpammerContext DB = new WhatsappSpammerContext())
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

                var number = DB.NumberBase.Find(textBoxName.Text);
                if (number != null)
                {

                    MessageBox.Show("Ad company successfully added!");
                }
                else
                {

                    MessageBox.Show("Ad company not added, something went wrong");
                }
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
