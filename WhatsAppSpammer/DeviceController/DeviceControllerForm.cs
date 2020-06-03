using System;
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
        public void Log(string text)
        {
            listBoxLogger.Items.Add(text);
        }
        private void DeviceControllerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
