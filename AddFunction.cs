using System;

namespace D19_ovn1._1
{
	public static class AddFunction
	{
		public static void addFunction()
		{
            Console.WriteLine("vill du lägg till nya länkar? skriv J for ja elle N för nej");
            string svaret = Console.ReadLine();
            if (svaret == "J")
            {
                int grans = 0;
                Console.WriteLine("Hur många länkar vill du mata in=");
                grans = Int32.Parse((Console.ReadLine()));
                for (int i = 0; i < grans; i++)
                {
                    Console.WriteLine("Skriv namnet: ");
                    string namn = Console.ReadLine();
                    Console.WriteLine("Skriv kort beskrivning: ");
                    string beskrivning = Console.ReadLine();
                    Console.WriteLine("Skriv lanken, t.e. www.Google.com ");
                    string lanken = Console.ReadLine();
                    string[] nylank = { namn, beskrivning, lanken };
                    string inmatning = nylank[0] + "|" + nylank[1] + "|" + nylank[2];
                    File.WriteAllText(@"C:\Users\Erik\source\repos\D19-ovn1.1\linkLinst.list", inmatning);
                }
                Console.WriteLine("Vill du lägga till mer länkar?");
                
            }
            else
            {
                Console.WriteLine("Tack för att du använder vår tjänst.");
            }
            
            

            

        }
    }
}