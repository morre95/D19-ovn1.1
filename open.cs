using System;

namespace D19_ovn1._1
{

    public class open
    {
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
                    break;
                }




            }
            return ret;

        }
    }
}
