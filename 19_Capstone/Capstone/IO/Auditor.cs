using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Capstone;

namespace Capstone
{
    public static class Auditor
    {
        public static void Audit(string message)
        {
            // start with current directory
            string currentDirectory = Directory.GetCurrentDirectory();
            // find the directory with the readme
            string targetDirectory = currentDirectory.Remove(currentDirectory.IndexOf("19_Capstone") + 11);
            // add file name to path
            using (StreamWriter sw = File.AppendText(targetDirectory + "\\Log.txt"))
            {
                sw.WriteLine($"{DateTime.Now.ToString("G")} {message}");
            }
        }
    }
}