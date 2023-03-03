using System;
using System.Diagnostics;

namespace D19_ovn1._1
{
    public class open
    {
        public static void OpenLink(string command)
        {
            Console.Write("Ange sida du vill besöka: ");
            string search = Console.ReadLine();
           
            string[] lines = FileHelper.Get(search);
            if (lines != null)
            {
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;

                proc.StartInfo.FileName = $"{lines[2]}";
                proc.Start();
            }
            else
            {
                Console.WriteLine("Hörrrrrrrö du du ditt jävla pucko. Den finns ju inte!!!!!");
                open.OpenLink(command);
            }
        }
    }
}
