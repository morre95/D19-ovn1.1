using System;
using System.Diagnostics;

namespace D19_ovn1._1
{
    internal static class FileHelper
    {
        private static string _path = "linkList.list";

        public static void Set(string[] contextArr)
        {
            using(StreamWriter sw = new StreamWriter(_path))
            {
                sw.WriteLine(string.Join("|", contextArr));
            }
        }
        public static string[] GetAll()
        {
            return File.ReadAllLines(_path);
        }

        public static string[] Get(string search)
        {
            foreach(string line in GetAll())
            {
                string[] parts = line.Split("|");
                if (parts[0] == search)
                {
                    return parts;
                }
            }
            return null;
        }
    }
}
