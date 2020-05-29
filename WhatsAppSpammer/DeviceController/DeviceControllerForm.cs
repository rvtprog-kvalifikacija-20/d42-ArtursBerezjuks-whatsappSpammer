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
        public DeviceController DeviceController { get; set; }
        public DeviceControllerForm(DeviceController deviceController)
        {
            InitializeComponent();
            DeviceController = deviceController;
            labelName.Text = deviceController.DeviceName;
            labelNickname.Text = deviceController.Nickname;
            labelNumber.Text = "";
            labelProxy.Text = deviceController.Proxy;
        }

        private void DeviceControllerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
