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
            WhatsappSpammerContext DB = new WhatsappSpammerContext();
            List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();

            FileReader.ReadFile(textBoxPath.Text).ForEach(i => phoneNumbers.Add(new PhoneNumber(i,null,null,null,null)));
            DB.NumberBase.Add(
                new NumberBase(
                    textBoxName.Text,
                    phoneNumbers,
                    new Message(textBoxMessage.Text)
                    )
                );
        }
    }
}
