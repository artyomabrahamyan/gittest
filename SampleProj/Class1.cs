﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj
{
    class Class1 : myclass
    {
        public static void Some()
        {

            Console.WriteLine("Bye");
            Console.WriteLine("See you!.");
        }

        public static void SomeMethod2()
        {
            Console.WriteLine(nameof(SomeMethod2));
        }
        public int MyProperty { get; set; }
    }
}
