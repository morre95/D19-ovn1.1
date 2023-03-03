using System;
using System.Diagnostics;

namespace D19_ovn1._1
{
    internal static class save
    {

        public static void Me()
        {
            ShowMenuEntry("--forms --title \"Save\" --text \"Save a new link:\" --add-entry=Name --add-entry=Description --add-entry=URL");
        }

        static void ShowMenuEntry(string str)
        {
            string[] output = StartZenity(str);

            string[] option = output[0].Split("|");

            while (!UrlHelper.IsValidUrl(option[2]))
            {
                Console.WriteLine($"Nej jag är inte en URL111: {option[2]}");
                output = StartZenity(str);
                option = output[0].Split("|");
            }

            FileHelper.Set(output[0]);
        }

        static string[] StartZenity(string zenityString)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = @"C:\Users\erikm\Test\zenity.exe";
            startInfo.FileName = Directory.GetCurrentDirectory() + "\\zenity.exe";

            startInfo.Arguments = zenityString;

            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            // Se till att kommandot inte körs i ett separat fönster
            startInfo.UseShellExecute = false;

            // Starta kommandot
            using (Process process = Process.Start(startInfo))
            {
                // Läs utdata från processen
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                return new string[2] { output, error };
            }
        }
    }
}
