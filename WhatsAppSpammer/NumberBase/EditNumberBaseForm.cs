using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppSpammer.NumberBase
{
    public partial class EditNumberBaseForm : Form
    {
        public WhatsappSpammerContext DB { get; set; }
        public NumberBase NumberBase { get; set; }
        public EditNumberBaseForm(WhatsappSpammerContext DB, NumberBase numberBase)
        {
            InitializeComponent();
            NumberBase = numberBase;
            this.Text = numberBase.Name;
            this.DB = DB;
            var phoneNumbers = DB.PhoneNumbers.Where(p => p.NumberBaseId == numberBase.Id).ToList() ;

            NumberBase.PhoneNumbers.ForEach(p => comboBoxNumbers.Items.Add(p.Number));
        }

        private void EditNumberBaseForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DB.NumberBase.Remove(NumberBase);
            DB.SaveChanges();
            this.Close();
        }
    }
}
