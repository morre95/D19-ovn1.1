using System;
using System.Diagnostics;

namespace D19_ovn1._1
{

    public static class load
    {
        public static void All(string URL)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = URL;
            process.Start();
            process.WaitForExit();
        }
    }
}