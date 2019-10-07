using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsappSpammer;

namespace WhatsAppSpammer
{
    public partial class WhatsAppSpammer : Form
    {
        private MessageSender ms { get; set; }
        public WhatsAppSpammer()
        {
            InitializeComponent();
            ms = new MessageSender(textBoxURL.Text, textBoxToken.Text, textBoxPath.Text);
            var numberBases = ms.GetNumberBasesInDirectory();
            foreach (var item in numberBases)
            {
                listBoxPhoneBases.Items.Add(item);
            }
            var selectedNumberBases = ms.GetNumberBases();
            foreach (var item in selectedNumberBases)
            {
                checkedListBoxPhoneBases.Items.Add(item);
            }
        }

        private void buttonpath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.ShowDialog();
                textBoxPath.Text = dialog.SelectedPath;
                ms.ChangeFileReaderPath(textBoxPath.Text);
            }
            
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {
            ms.Url = textBoxURL.Text;
        }

        private void textBoxToken_TextChanged(object sender, EventArgs e)
        {
            ms.Url = textBoxToken.Text;
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            ms.ChangeFileReaderPath(textBoxPath.Text);
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            foreach (string numberBase in ms.GetNumberBases())
            {
                foreach(string number in numberBase)
                {
                    ms.sendMessage(number, textBoxMessage.Text);
                }
            }
            MessageBox.Show(ms.sendMessage("37127583637","works"));
        }

        private void listBoxPhoneBases_DoubleClick(object sender, EventArgs e)
        {
            int index = this.listBoxPhoneBases.SelectedIndex;
            if (index >= 0)
            {
                string filename = this.listBoxPhoneBases.Text;
                listBoxPhoneBases.Items.RemoveAt(index);
                ms.AddNumberBase(filename);
                checkedListBoxPhoneBases.Items.Add(filename, true);
            }
            
            
        }
    }
}
