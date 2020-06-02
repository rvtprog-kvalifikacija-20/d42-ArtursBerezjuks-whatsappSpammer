using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappSpammer
{
    public class FileReader
    {
        private string Path { get; set; }
        /// <summary>
        /// Read txt file by lines and put in dictionary(int,string)
        /// </summary>
        /// <param name="filename">txt filename</param>
        /// <returns>Dictionary(int,string) </returns>
        public List<string> ReadFile(string filename)
        {
            string line;
            if (Path != "")
            {
                Path += "/";
            }
            List<string> numbers = new List<string>();
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(Path+filename);
            while ((line = file.ReadLine()) != null)
            {
                numbers.Add(line);
            }
            file.Close();
            return numbers;
        }
    
        /// <summary>
        /// set path to phone numbers dirtectory
        /// </summary>
        /// <param name="path"></param>
        public FileReader (string path)
        {
            this.Path = path;    
        } 
        public List<string> GetFilenames()
        {
            try
            {
                string[] filenamesArr = Directory.GetFiles(Path, "*.txt");
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
