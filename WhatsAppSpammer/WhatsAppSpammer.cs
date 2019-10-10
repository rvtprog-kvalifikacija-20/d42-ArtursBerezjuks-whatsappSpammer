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
        private bool settingsChanged;
        private int Count { get; set; }
        public bool SettingsChanged { 
            get { 
                return SettingsChanged; 
            } 
            set {
                settingsChanged = value;
                buttonChangeAndSaveSettings.Enabled = value;
            } 
        }
        public WhatsAppSpammer()
        {
            InitializeComponent();
            textBoxURL.Text = Properties.Settings.Default.URL;
            textBoxToken.Text = Properties.Settings.Default.Token;
            textBoxPath.Text = Properties.Settings.Default.PathToDirectory;
            ms = new MessageSender(Properties.Settings.Default.URL, Properties.Settings.Default.Token, Properties.Settings.Default.PathToDirectory);
            SettingsChanged = false;
            var numberBases = ms.GetNumberBasesInDirectory();
            foreach (var item in numberBases)
            {
                listBoxPhoneBases.Items.Add(item);
            }
            var selectedNumberBases = ms.GetNumberBases();
            foreach (var item in selectedNumberBases)
            {
                listBoxSelectedPhoneBases.Items.Add(item);
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
            SettingsChanged = true;
        }

        private void textBoxToken_TextChanged(object sender, EventArgs e)
        {
            SettingsChanged = true;
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            SettingsChanged = true;
        }
        private void changeAndSaveSettings()
        {
            Properties.Settings.Default.URL = textBoxURL.Text;
            Properties.Settings.Default.Token = textBoxToken.Text;
            Properties.Settings.Default.PathToDirectory = textBoxPath.Text;
            ms.Url = Properties.Settings.Default.URL;
            ms.Token = Properties.Settings.Default.Token;
            ms.ChangeFileReaderPath(Properties.Settings.Default.PathToDirectory);
            Properties.Settings.Default.Save();
        }
        private void buttonTest_Click(object sender, EventArgs e)
        {
            Count = 0;
            var numberbases = ms.GetNumberBases().Values;
            List<string> numbers = new List<string>{};
            foreach (var item in numberbases)
            {
                Count += item.Numbers.Count;
                numbers = numbers.Concat(item.Numbers).ToList();
            }
            progressBar.Value = 0;
            progressBar.Maximum = Count;

            string message = richTextBoxMessage.Text;
            sendMessageToSelectedPhoneBases(message);
        }
        private async void sendMessageToSelectedPhoneBases(string message)
        {
            buttonSendMessages.Enabled = false;
            foreach (NumberBase numberBase in ms.GetNumberBases().Values)
            {
                foreach (string number in numberBase.Numbers)
                {
                    listBoxServerAnswers.Items.Add(await Task.Run(()=>ms.sendMessageAsync(number, message)));
                    
                    progressBar.Value++;
                }
            }
            buttonSendMessages.Enabled = true;
        }
        private void listBoxPhoneBases_DoubleClick(object sender, EventArgs e)
        {
            int index = this.listBoxPhoneBases.SelectedIndex;
            if (index >= 0)
            {
                string filename = this.listBoxPhoneBases.Text;
                listBoxPhoneBases.Items.RemoveAt(index);
                ms.AddNumberBase(filename);
                listBoxSelectedPhoneBases.Items.Add(filename);
            }
        }

        private void listBoxSelectedPhoneBases_Click(object sender, EventArgs e)
        {
            listBoxPhoneNumbers.Items.Clear();
            string filename = this.listBoxSelectedPhoneBases.Text;

            if (ms.GetNumberBases().Keys.Contains(filename))
            {
                NumberBase numberBase = ms.GetNumberBases()[filename];

                foreach (string number in numberBase.Numbers)
                {
                    listBoxPhoneNumbers.Items.Add(number);
                }
            }
        }

        private void listBoxSelectedPhoneBases_DoubleClick(object sender, EventArgs e)
        {
            int index = this.listBoxSelectedPhoneBases.SelectedIndex;
            if (index >= 0)
            {
                string filename = this.listBoxSelectedPhoneBases.Text;
                listBoxSelectedPhoneBases.Items.RemoveAt(index);
                ms.RemoveNumberBase(filename);
                listBoxPhoneBases.Items.Add(filename);
            }
            listBoxPhoneNumbers.Items.Clear();
        }

        private void buttonChangeAndSaveSettings_Click(object sender, EventArgs e)
        {
            changeAndSaveSettings();
            SettingsChanged = false;
        }

        private async void buttontTest_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int count = 0;
            var startTime = DateTime.Now.ToLocalTime();
            while (true)
            {
                int number = r.Next(7999999) + 2000000;

                string response = await Task.Run(() => ms.sendMessageAsync("3712" + number.ToString(), r.Next().ToString()));
                
                listBoxServerAnswers.Items.Add(response);
                if (response.Contains("not equals authenticated."))
                {
                    return;
                }
                count++;
                string timediff = (DateTime.Now.ToLocalTime() - startTime).ToString();
                labelServerAnswer.Text = "Server answers: (Count:" + count.ToString() + " Timediff: " + timediff + ")";
            }
        }
    }
}
