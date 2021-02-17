using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv02
{
    class App
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Complex c = new Complex(5.1, -8.6);
            Complex c2 = new Complex(4.1, 7.6);
            Complex c3 = new Complex(5.1, -8.6);
            Console.WriteLine(c+c2);
            Console.WriteLine(c-c2);
            Console.WriteLine(c*c2);
            Console.WriteLine(c/c2);
            Console.WriteLine(c == c3);
            Console.WriteLine(c != c3);
            Console.WriteLine(-c);
            Console.ReadLine();
        }
    }
}
