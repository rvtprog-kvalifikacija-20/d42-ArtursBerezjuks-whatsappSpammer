using System;
using System.Windows.Forms;

namespace WhatsAppSpammer
{
    public static class Logger
    {
        public static Form loggerForm;

        public static ListBox listbox;

        public static void log(string text)
        {
            listbox.Items.Insert(0, DateTime.Now.ToString() + " | " + text);
        }
        public static void log(string text, bool timestamp)
        {
            if (timestamp)
            {
                listbox.Items.Insert(0, DateTime.Now.ToString() + " | " + text);
            }
            else
            {
                listbox.Items.Insert(0, text);
            }

        }
        public static Form initLogger()
        {
            loggerForm = new Form();
            listbox = new ListBox();
            loggerForm.Width = 600;
            loggerForm.Height = 300;
            listbox.Width = 600;
            listbox.Height = 300;
            loggerForm.Controls.Add(listbox);
            loggerForm.Text = "Logger";
            loggerForm.Activate();
            return loggerForm;
        }
    }
}
