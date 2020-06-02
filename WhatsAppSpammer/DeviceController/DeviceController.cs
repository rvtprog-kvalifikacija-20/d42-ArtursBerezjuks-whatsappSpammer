﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using WhatsAppSpammer.NumberBase;

namespace WhatsAppSpammer.DeviceController
{
    public class DeviceController
    {
        public string DeviceName { get; set; }
        public AppiumDevice AppiumDevice { get; set; }
        public string Nickname { get; set; }
        public string Proxy { get; set; }
        public string Port{ get; set; }
        public DeviceControllerForm DeviceControllerForm {get; set;}
        public NumberBase.NumberBase NumberBase { get; set; }

        public AbstractSmsRegistrator SmsRegistrator { get; set; }

        public DeviceController(
            string deviceName,
            string proxy,
            string smsRegistratorName,
            string nickname,
            AppiumDevice appiumDevice,
            string port
        )
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            DeviceName = deviceName;
            Proxy = proxy;
            Nickname = nickname;
            SmsRegistrator = (AbstractSmsRegistrator) CreateInstance(smsRegistratorName);
            AppiumDevice = appiumDevice;
            Port = port;
            DeviceControllerForm = new DeviceControllerForm(this);
        }
        public void Log(string text)
        {
            DeviceControllerForm.Log(text);
        }
        private static object CreateInstance(string className)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly.GetTypes()
                .First(t => t.Name == className);

            return Activator.CreateInstance(type);
        }
       public void Wait(int ms)
        {
            Thread.Sleep(ms);
        }

        public void RunEmulator()
        {
            string command = "emulator @" + DeviceName;
            if (Proxy != "" && Proxy != null)
            {
                command += " -http-proxy " + Proxy;
            }
            command += " -wipe-data -no-snapshot-load";

            CommandExecutor.ExecuteCommandAsync(command);
        }

    }
}
