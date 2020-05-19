using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppSpammer
{
    class SettingForm
    {
        Form settingForm;
        Dictionary<string, TextBox> settings;
        public SettingForm()
        {
            Init();
        }

        private void Init()
        {
            settings = new Dictionary<string, TextBox>();

            settingForm = new Form();
            settingForm.AutoSize = true;
            settingForm.Padding = new Padding(10);

            int y = 10;

            foreach (SettingsProperty property in Properties.Settings.Default.Properties)
            {
                Label label = new Label();
                TextBox textBox = new TextBox();

                label.Location = new Point(10, y);
                label.Text = property.Name;

                textBox.Location = new Point(100, y);
                textBox.Size = new Size(500, 20);
                textBox.Text = property.DefaultValue.ToString();

                settingForm.Controls.Add(label);
                settingForm.Controls.Add(textBox);

                label.BringToFront();
                textBox.BringToFront();
                textBox.Show();

                y += 25;

                settings.Add(property.Name, textBox);
            }

            Button saveButton = new Button();
            saveButton.Text = "Save settings";
            saveButton.Location = new Point(10, y);
            saveButton.Click += SaveButton_Click;
            settingForm.Controls.Add(saveButton);

            settingForm.Refresh();
            settingForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            foreach(var setting in settings)
            {
                Properties.Settings.Default[setting.Key] = setting.Value.Text.ToString();             
            }
            
                
            DialogResult dialogResult = MessageBox.Show("To apply settings you need to restart program! Do you want to restart program", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
