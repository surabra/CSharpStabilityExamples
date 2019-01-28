using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NullProperty.getSome().Real);
        }
    }

    class Some
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public Some()
        {

        }

    }
    class NullProperty
    {
        private static Some realNumner = null;

        public static Some getSome()
        {
            return realNumner;
        }
    }
}
