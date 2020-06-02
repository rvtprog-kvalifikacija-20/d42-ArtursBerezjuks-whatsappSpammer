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
using NUnit.Framework;
using System.Management.Automation;
using System.Threading;
using MixERP.Net.VCards;
using System.Configuration;
using WhatsAppSpammer.SmsRegistrator;
using WhatsAppSpammer.DeviceController;
using WhatsAppSpammer.NumberBase;

namespace WhatsAppSpammer
{
    public partial class WhatsAppSpammer : Form
    {
        private WhatsappSpammerContext DB = new WhatsappSpammerContext();
        private AppiumDevice appium;
        private AbstractSmsRegistrator smsRegistrator;
        private List<Device> devices;
        private int Count { get; set; }
        public List<DeviceController.DeviceController> DeviceControllers { get; set; }

        
        public WhatsAppSpammer()
        {
            InitializeComponent();
            DeviceControllers = new List<DeviceController.DeviceController>();
            devices = new List<Device>();

            string advs = CommandExecutor.ExecuteCommandSync("emulator -list-avds");
            string[] adv = advs.Split('\n');
            foreach (var item in adv)
            {
                comboBoxAppium.Items.Add(item);
            }


            //com.whatsapp:id/eula_accept 
            //com.whatsapp:id/registration_phone
            //com.whatsapp:id/registration_submit
            //com.whatsapp:id/registration_cc
            //android:id/button1
            //com.whatsapp:id/verify_sms_code_input


            smsRegistrator = new SmsActivate(
               Properties.Settings.Default["ApiKey"].ToString(),
               Properties.Settings.Default["Referal"].ToString(),
              Properties.Settings.Default["Country"].ToString());

            string response = ""; // ApiRequest.GetRequestSync("https://www.proxy-list.download/api/v1/get?type=http&country=RU");
            string[] adresses = response.Split('\n');
            Random rand = new Random();
            int index = rand.Next(0, adresses.Length);
            textBoxProxy.Text = adresses[index].Trim();

            DB.NumberBase.ToList<NumberBase.NumberBase>().ForEach(i => {
                comboBoxAdCompanies.Items.Add(i.Name);
            });

            Logger.initLogger();
            //Logger.loggerForm.Show();
            
        }


        [Obsolete]
        private  void buttonAppiumRun_Click(object sender, EventArgs e)
        {
            try
            {
                appium = new AppiumDevice(
                   Apps.WhatsApp,
                   Apps.WhatsAppActivity_Home,
                   new Device(comboBoxAppium.Text)
                );
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void buttonEmulatorRun_Click(object sender, EventArgs e)
        {
            try
            {
                Invoke(new Action(() =>  CreateDeviceController(
                    comboBoxAppium.Text,
                    textBoxProxy.Text,
                    comboBoxSmsRegistrator.Text,
                    textBoxName.Text,
                    null,
                    textBoxAppiumPort.Text)
                ));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CreateDeviceController(
            string deviceName,
            string proxy,
            string smsRegistrator,
            string nickname,
            AppiumDevice device,
            string port
        ) {
            DeviceController.DeviceController deviceController =
                    new DeviceController.DeviceController(
                        deviceName,
                        proxy,
                        smsRegistrator,
                        nickname,
                        null,
                        port
                    );
            DeviceControllers.Add(deviceController);

            deviceController.DeviceControllerForm.Show();
            WhatsAppScenario.Registration(deviceController);

            // Automatization(comboBoxAppium.Text, textBoxProxy.Text);
        }
        private async void buttonGetProxy_Click(object sender, EventArgs e)
        {
            string response = await ApiRequest.GetRequestAsync(Properties.Settings.Default.ProxyUrl);
            //string response = await ApiRequest.GetRequestAsync("https://my.virty.io/proxy_list/proxies.php?hash=0576f42d7cbe136471e6241a6531020f&type=http&format=format3");
            string[] adresses = response.Split('\n');
          
            Random rand = new Random();
            int index = rand.Next(0, adresses.Length-1);
            textBoxProxy.Text = adresses[index].Trim();
                
        }

       


        private async void buttonGenerateVcard_Click(object sender, EventArgs e)
        {
            try
            {
                string vCardText = await Task.Run(() => VCardGenerator());
                await Task.Run(() =>
                {
                    System.IO.File.WriteAllText(Properties.Settings.Default.PathToDirectory + "/vcard.vcf", vCardText);
                });
                MessageBox.Show("VCard ready!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }
    
        private string VCardGenerator()
        {
            List<string> numbers = new List<string>();
            var numberBases = new Dictionary<string, string>();
            foreach (var numberBase in numberBases.Values)
            {
              //  numbers = numbers.Concat(numberBase.Numbers).ToList();
            }
            string vcards = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                vcards += "BEGIN:VCARD\nVERSION:2.1\nN:;+" + numbers[i] + ";;;\nFN:+" + numbers[i] + "\nTEL;CELL:+" + numbers[i] + "\nEND:VCARD\n";
            }
            return vcards;
        }

        private void buttonSendVcard_Click(object sender, EventArgs e)
        {
            SendVCard();
        }
        
        private async void SendVCard()
        {
            string command = "cd " + Properties.Settings.Default.PathToSDK + "/platform-tools";
            CommandExecutor.ExecuteCommandAsync(command);
            command = " push " + Properties.Settings.Default.PathToDirectory + "/vcard.vcf /sdcard";
            await CommandExecutor.AdbExecutor(command);
        }

     

        [Obsolete]
        private void buttonAppiumContacts_Click(object sender, EventArgs e)
        {
            Invoke(
                new Action(() => 
                    appium = new AppiumDevice(Apps.Contacts, Apps.ContatsActivity_Main, new Device(comboBoxAppium.Text)
                    )
                )
            );
            ContactsScenario.ImportContacts(appium);
        }

        private void buttonEmulator_Click(object sender, EventArgs e)
        {
            Invoke(new Action(
                () =>
                {
                    RunEmulator(comboBoxAppium.Text, textBoxProxy.Text);
                })
            );
        }

        public void RunEmulator(string deviceName, string proxy)
        {
            string command = "emulator @" + deviceName;
            if (proxy != "" && proxy != null)
            {
                command += " -http-proxy " + proxy;
            }
            command += " -wipe-data -no-snapshot-load";

            CommandExecutor.ExecuteCommandAsync(command);
        }

        private void buttonStopAppium_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            new SettingForm();
        }

        private void buttonSelectPhoneNumbers_Click(object sender, EventArgs e)
        {

        }

        private void WhatsAppSpammer_Load(object sender, EventArgs e)
        {

        }

        private void buttonNumberBase_Click(object sender, EventArgs e)
        {
            CreateNumberBaseForm form = new CreateNumberBaseForm();
            form.Show();
        }
    }
}

