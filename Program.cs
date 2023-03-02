
namespace D19_ovn1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

        private static string Open(string search = "SVT")
        {
            string ret = null;
            string[] lines = File.ReadAllLines(@"C:\Users\Salim\source\repos\D19-ovn1.1\linkLinst.list");
            foreach (string line in lines)
            {
                string[] test = line.Split("|");
                if (test[0] == search)
                {
                    ret = test[2];
                }


                

            }
            return ret;

        }

        private static void GetLink()
        {
            string ret = null;
            string[] lines = File.ReadAllLines(@"C:\Users\Salim\source\repos\D19-ovn1.1\linkLinst.list");   
            foreach (string line in lines)
            {
                string[] test = line.Split("|");


                Console.WriteLine(test[0]);
                Console.WriteLine(test[1]);
                Console.WriteLine(test[2]);

            }
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