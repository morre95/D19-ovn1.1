
using static System.Net.Mime.MediaTypeNames;

namespace D19_ovn1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currDir = Directory.GetCurrentDirectory();
            Console.WriteLine($@"{currDir}\linkLinst.list");
            Console.WriteLine(GetLink("google"));
            PrintWelcome();
            string command;
            do
            {
                Console.Write(": ");
                command = Console.ReadLine();
                if (command == "quit")
                {
                    Console.WriteLine("Good bye!");
                }
                else if (command == "help")
                {
                    WriteTheHelp();
                }
                else if (command == "load")
                {
                    NotYetImplemented(command);
                }
                else if (command == "open")
                {
                    NotYetImplemented(command);
                }
                else
                {
                    Console.WriteLine($"Unknown command '{command}'");
                }
            } while (command != "quit");
        }

        private static void NotYetImplemented(string command)
        {
            Console.WriteLine($"Sorry: '{command}' is not yet implemented");
        }

        private static void Open(string search)
        {

        }

        private static string GetLink(string check)
        {
            string ret = null;
            //string currDir = Directory.GetCurrentDirectory();
            string[] lines = File.ReadAllLines(@"C:\Users\Erik\source\repos\D19-ovn1.1\bin\Debug\net6.0\linkLinst.list");   
            foreach (string line in lines)
            {
                string[] test = line.Split("|");
                if (test[0] == check)
                {
                    ret = test[2];
                }
                
            }
            return ret;
        }

        private static void PrintWelcome()
        {
            Console.WriteLine("Hello and welcome to the ... program ...");
            Console.WriteLine("that does ... something.");
            Console.WriteLine("Write 'help' for help!");
        }

        private static void WriteTheHelp()
        {
            string[] hstr = {
                "help  - display this help",
                "load  - load all links from a file",
                "open  - open a specific link",
                "quit  - quit the program"
            };
            foreach (string h in hstr) Console.WriteLine(h);
        }
    }
}