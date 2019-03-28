using System;

namespace NullVariable
{
    class Program
    {
        private static String sName = null;

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            var check =myClass.Property.test(); // Issue NullReferenceException
            var mae = myClass.GetProgram().test(); // Issue NullReferenceException

        }

        public int test()
        {
            int i = 10;
            return i;

        }
    }

    class MyClass
    {
        public Program Property
        {
            get
            {
               return null;
            }
        }

        public Program GetProgram()
        {
            return null;
        }
    }
}
