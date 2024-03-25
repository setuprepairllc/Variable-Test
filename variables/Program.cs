using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 2;
            double d = 1.0d;
            float f = 4.0f;
            decimal n = 3.0m;

            string s = "";
            s = "numbers are" + x + d + f + n;
            Console.WriteLine(s);

            Console.WriteLine("Please enter your name _");
            string t = Console.ReadLine();
            Console.WriteLine("Your name is " + t);

            Console.WriteLine("numbers are {0} {1} {2} {3}", x, d, f, n );
            Console.WriteLine("numbers are" + x + d + f + n);
            Console.ReadLine();

        }
    }
}
