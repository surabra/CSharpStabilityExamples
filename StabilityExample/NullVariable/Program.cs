using System;

namespace NullVariable
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            var check =myClass.Property.test(); // Issue NullReferenceException
            Console.WriteLine($"check = {check}");
            var mae = myClass.GetProgram().test(); // Issue NullReferenceException

            Console.WriteLine($"mae = {mae}");

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
