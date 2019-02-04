using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace VisualBasic_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            Collection collection = new Collection();
            collection.Add("Hello");
            // Problem code collection accessed without checking for > 0
              Console.WriteLine(collection[index]);

            // Fix code
            index = 1;
            if(index > 0 && index <= collection.Count)
            {
                Console.WriteLine(collection[index]);
            }
        }
    }
}
