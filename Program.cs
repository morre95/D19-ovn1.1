
using System.IO;
using System.IO.Enumeration;
using static System.Net.Mime.MediaTypeNames;

namespace D19_ovn1._1
{
    internal class Program
    {
        private static string fileName = "linkList.list";

        static void Main(string[] args)
        {
            AddFunction.addFunction();
            PrintWelcome();
            Console.WriteLine(Open());
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
                else if (command == "list")
                {
                    list.All();
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