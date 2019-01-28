using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullVariable
{
    class Program
    {
        private static String sName = null;
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Property.test();
            myClass.GetProgram().test();

        }

        public void test()
        {
            int i = 10;
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
