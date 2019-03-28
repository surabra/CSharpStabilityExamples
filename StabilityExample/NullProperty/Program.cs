using System;

namespace NullProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NullProperty.getSome().Real); // Issue NullReferenceException
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
        private static Some _some = null;

        public static Some getSome()
        {
            return _some;
        }
    }
}
