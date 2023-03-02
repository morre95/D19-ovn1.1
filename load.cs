using System;
using System.Diagnostics;

namespace D19_ovn1._1
{

    public static class load
    {
        public static void All()
        {
            string path = Directory.GetCurrentDirectory();
            string[] lines = File.ReadAllLines($@"{path}\linkList.list");
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                Process process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = parts[2];
                process.Start();
            }
        }
    }
}