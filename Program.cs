
using System.IO;
using System.IO.Enumeration;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace D19_ovn1._1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            using (StreamWriter w = File.AppendText("linkList.list")) { }
            PrintWelcome();
            string command;
            do
            {
                Console.Write(": ");
                command = Console.ReadLine().ToLower();
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
                    load.All();
                }
                else if (command == "list")
                {
                    list.All();
                }
                else if (command == "open")
                {
                    open.OpenLink(command);
                }
                else if (command == "save")
                {
                    save.Me();
                }
                else if (command == "select file")
                {
                    FileHelper.SelectFile();
                    //load.All();
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
                "save  - save links",
                "list  - list all links",
                "select file  - select or create new file",
                "quit  - quit the program"
            };
            foreach (string h in hstr) Console.WriteLine(h);
        }
    }
}