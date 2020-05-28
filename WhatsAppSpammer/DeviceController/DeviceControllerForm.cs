using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppSpammer.DeviceController
{
    public partial class DeviceControllerForm : Form
    {
        public DeviceController DeviceController {get;set;}
        public DeviceControllerForm(string deviceName, string proxy)
        {
            DeviceController = new DeviceController(deviceName, proxy);
            InitializeComponent();
        }

        private void DeviceControllerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
