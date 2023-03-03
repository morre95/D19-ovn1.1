using System;
using System.Diagnostics;

namespace D19_ovn1._1
{
    public class open
    {
        public static string OpenLink(string command)
        {
            Console.Write("Ange sida du vill besöka: ");
            string search = Console.ReadLine();
            string ret = null;
            string[] lines = FileHelper.GetAll();
            foreach (string line in lines)
            {
                string[] test = line.Split("|");
                if (test[0] == search)
                {
                    ret = test[2];
                    Process proc = new Process();
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.FileName = $"{ret}";
                    proc.Start();
                    break;
                }
            }
            return ret;
        }
    }
}
