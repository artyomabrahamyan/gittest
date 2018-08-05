using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProj
{
    class Some { }

    class A : B
    {
        

    }

    class B
    {

    }

    class Program
    {
        static void Main()
        {
            Random r = new Random();
            Console.WriteLine("This is from testing");
            int x = 0;
            int y = 10;
            A a = new A();

            Exception e = new Exception();
            double d = 5;
        }
    }

    interface another
    {
        void Create();

        void Something();

        double Dummy();

        void Some();
        void First();

    }
}
