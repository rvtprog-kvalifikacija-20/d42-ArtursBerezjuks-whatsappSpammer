using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.RedirectStandardError = true;
                procStartInfo.RedirectStandardInput = true;
                procStartInfo.UseShellExecute = false;
                
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                //proc.OutputDataReceived += (s, e) => {result += e.Data; };
                //proc.ErrorDataReceived += (s, e) => { result += e.Data; };
                proc.Start();
                
                //proc.StandardInput.WriteLine(command);

                //proc.BeginOutputReadLine();
                //proc.BeginErrorReadLine();
                // Get the output into a string
                
                //proc.WaitForExit();
                result += proc.StandardOutput.ReadToEnd();
                // Display the command output.
                return result;
            }
            catch (Exception objException)
            {
                return objException.Message;
            }
        }
        public static async Task<string> AdbExecutor(string command)
        {
            try
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
                return result;//proc.StandardOutput.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string ExecuteCommandsSync(List<string> commands)
        {
            try
            {
                string result = "";
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c ");

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.RedirectStandardError = true;
                procStartInfo.RedirectStandardInput = true;
                procStartInfo.UseShellExecute = false;

                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
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
                //result += proc.StandardOutput.ReadToEnd();
                // Display the command output.
                return result;
            }
            catch (Exception objException)
            {
                return objException.Message;
            }
        }

        public static void ExecuteCommandSync(object command)
        {
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
               
            }
            catch (Exception objException)
            {
                // Log the exception
            }
        }
        public static string ExecuteCommandAsync(string command)
        {
            try
            {
                //Asynchronously start the Thread to process the Execute command request.
                string result = "";
                Thread objThread = new Thread(stat =>
                {
                    result = ExecuteCommandSync(command);
                });//new ParameterizedThreadStart(ExecuteCommandSync(command)));
                //Make the thread as background thread.
                objThread.IsBackground = true;
                //Set the Priority of the thread.
                objThread.Priority = ThreadPriority.AboveNormal;
                //Start the thread.
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
                //Asynchronously start the Thread to process the Execute command request.
                string result = "";
                Thread objThread = new Thread(stat =>
                {
                    result = ExecuteCommandsSync(commands);
                });//new ParameterizedThreadStart(ExecuteCommandSync(command)));
                //Make the thread as background thread.
                objThread.IsBackground = true;
                //Set the Priority of the thread.
                objThread.Priority = ThreadPriority.AboveNormal;
                //Start the thread.
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
            try
            {
                //Asynchronously start the Thread to process the Execute command request.
                Thread objThread = new Thread(new ParameterizedThreadStart(ExecuteCommandSync));
                //Make the thread as background thread.
                objThread.IsBackground = true;
                //Set the Priority of the thread.
                objThread.Priority = ThreadPriority.AboveNormal;
                //Start the thread.
                objThread.Start(command);
            }
            catch (ThreadStartException objException)
            {
                // Log the exception
            }
            catch (ThreadAbortException objException)
            {
                // Log the exception
            }
            catch (Exception objException)
            {
                // Log the exception
            }
        }
    }
}
