using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappSpammer
{
    public static class FileReader
    {
        /// <summary>
        /// Read txt file by lines and put in dictionary(int,string)
        /// </summary>
        /// <param name="filename">txt filename</param>
        /// <returns>Dictionary(int,string) </returns>
        public static List<string> ReadFile(string filename)
        {
            string line;

            List<string> numbers = new List<string>();
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(filename);
            while ((line = file.ReadLine()) != null)
            {
                numbers.Add(line);
            }
            file.Close();
            return numbers;
        }
    

        public static List<string> GetFilenames(string path)
        {
            try
            {
                string[] filenamesArr = Directory.GetFiles(path, "*.txt");
                List<string> filenames = new List<string>();
                for (int i = 0; i < filenamesArr.Length; i++)
                {
                    string[] filename = filenamesArr[i].Split('\\');
                    filenames.Add(filename.Last());
                }
                return filenames;
            }
            catch
            {
                return new List<string>();
            }
        }
    }
}
