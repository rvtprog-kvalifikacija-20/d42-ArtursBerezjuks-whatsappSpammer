using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppSpammer
{
    public partial class DeviceForm : Form
    {
        public DeviceForm(string device, string proxyIP)
        {
            InitializeComponent();
            table.ColumnCount = 3;
            table.Columns[0].Name = "Device";
            table.Columns[1].Name = "Proxy";
            table.Columns[2].Name = "Current Activity";
            AddDevice(device, proxyIP);
        }
        public void AddDevice(string device, string proxyIP)
        {

            string[] row = new string[3];
            row[0] = device;
            row[1] = proxyIP;
            row[2] = "";
            table.Rows.Add(row);
        }
        private void DeviceForm_Load(object sender, EventArgs e)
        {
        }
    }
}
