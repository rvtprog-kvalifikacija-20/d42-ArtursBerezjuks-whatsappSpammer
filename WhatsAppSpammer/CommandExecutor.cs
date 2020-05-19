using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace WhatsAppSpammer
{
    public static class CommandExecutor
    {
        public static string ExecuteCommandSync(string command)
        {
            try
            {
                string result = "";
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.RedirectStandardError = true;
                procStartInfo.RedirectStandardInput = true;
                procStartInfo.UseShellExecute = false;

                procStartInfo.CreateNoWindow = true;
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();

                result += proc.StandardOutput.ReadToEnd();
                return result;
            }
            catch (Exception objException)
            {
                return objException.Message;
            }
        }
        public static async Task<string> AdbExecutor(string command)
        {
            string result = "";
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo(@"C:/Program Files (x86)/Android/android-sdk/platform-tools/adb.exe ", command);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardError = true;
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            Process proc = new Process();
            proc.StartInfo = procStartInfo;
            proc.OutputDataReceived += (s, e) => { result += e.Data; };
            proc.ErrorDataReceived += (s, e) => { result += e.Data; };
            proc.Start();
            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();
            proc.WaitForExit();
            proc.Close();
            proc.Dispose();
            return result;
        }
        public static string ExecuteCommandsSync(List<string> commands)
        {
            try
            {
                string result = "";
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c ");

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.RedirectStandardError = true;
                procStartInfo.RedirectStandardInput = true;
                procStartInfo.UseShellExecute = false;

                procStartInfo.CreateNoWindow = true;
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.OutputDataReceived += (s, e) => { result += e.Data; };
                proc.ErrorDataReceived += (s, e) => { result += e.Data; };
                proc.Start();
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();
                foreach (var command in commands)
                {
                    proc.StandardInput.WriteLine(command);

                }
                proc.WaitForExit();
                return result;
            }
            catch (Exception objException)
            {
                return objException.Message;
            }
        }

        public static void ExecuteCommandSync(object command)
        {
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }
        public static string ExecuteCommandAsync(string command)
        {
            try
            {
                string result = "";
                Thread objThread = new Thread(stat =>
                {
                    result = ExecuteCommandSync(command);
                });
                objThread.IsBackground = true;
                objThread.Priority = ThreadPriority.AboveNormal;
                objThread.Start();
                return result;
            }
            catch (ThreadStartException objException)
            {
                return objException.Message;
            }
            catch (ThreadAbortException objException)
            {
                return objException.Message;
            }
            catch (Exception objException)
            {
                return objException.Message;
            }
        }
        public static string ExecuteCommandsAsync(List<string> commands)
        {
            try
            {
                string result = "";
                Thread objThread = new Thread(stat =>
                {
                    result = ExecuteCommandsSync(commands);
                });
                objThread.IsBackground = true;
                objThread.Priority = ThreadPriority.AboveNormal;
                objThread.Start();
                return result;
            }
            catch (ThreadStartException objException)
            {
                return objException.Message;
            }
            catch (ThreadAbortException objException)
            {
                return objException.Message;
            }
            catch (Exception objException)
            {
                return objException.Message;
            }
        }
        public static void ExecuteCommandAsyncVoid(string command)
        {
            Thread objThread = new Thread(new ParameterizedThreadStart(ExecuteCommandSync)); 
            objThread.IsBackground = true;             
            objThread.Priority = ThreadPriority.AboveNormal;                
            objThread.Start(command);
        }
    }
}
