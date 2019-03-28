using System;
using Microsoft.VisualBasic;

namespace VisualBasic_Collection
{
    class Program
    {
        private static Collection collection = new Collection();
        static void Main(string[] args)
        {
            int index = 0;
            
            collection.Add("Hello");
            // Problem code collection accessed without checking for > 0 and <= collection.Count
            Console.WriteLine(collection[index]); // Issue Array/Collection Access

            // Fix code

            string str = GetString(1);
            Console.WriteLine(str);
        }

        private static string GetString(int index)
        {
            if (index > 0 && index <= collection.Count)
            {
                string str = collection[index] as string;
                return str;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
