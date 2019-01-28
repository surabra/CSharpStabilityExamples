using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatNullCheck
{
    public class AnotherClass
    {
        public string Name { get; set; }
    }
    public static class SomeClass
    {
        public static AnotherClass AnotherInstance { get; set; }
    }
}
