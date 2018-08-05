using System;
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

<<<<<<< HEAD
        public static void SomeMethod2()
        {
            Console.WriteLine(nameof(SomeMethod2));
        }
=======
        public int MyProperty { get; set; }
>>>>>>> 11cc8f9dfc2b32f598190bd9b28c3900fd410021
    }
}
