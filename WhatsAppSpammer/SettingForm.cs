using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
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

            Properties.Settings.Default.Upgrade();
            foreach (SettingsProperty property in Properties.Settings.Default.Properties)
            {
                Label label = new Label();
                TextBox textBox = new TextBox();

                label.Location = new Point(10, y);
                label.Text = property.Name;

                textBox.Location = new Point(100, y);
                textBox.Size = new Size(500, 20);
                textBox.Text = Properties.Settings.Default[property.Name].ToString();

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
            foreach (var setting in settings)
            {
                Properties.Settings.Default[setting.Key] = setting.Value.Text.ToString();
            }


            DialogResult dialogResult = MessageBox.Show("Save settings and continue?", "Save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
                settingForm.Close();
            }
        }
    }
}
