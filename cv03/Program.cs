using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv03
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[,] { { 5, 4 }, { 3, 4 } };
            double[,] b = new double[,] { { 5, 4 }, { 3, 4 } };
            double[,] e = new double[,] { { 5, 4 }, { 3, 4 }, { 5, 4 } };
            double[,] c = new double[,] { { 5, 4, 2 }, { 3, 4, 1 }, { 5, 4, 3 } };
            double[,] d = new double[,] { { 5 } };



            Matrix m1 = new Matrix(a);
            Matrix m2 = new Matrix(b);
            Matrix m3 = new Matrix(c);
            Matrix m4 = new Matrix(d);

            Console.WriteLine(m1 + m2);
            Console.WriteLine(m1 - m2);
            Console.WriteLine(m1 * m2);
            Console.WriteLine(-m1);
            Console.WriteLine(m1 == m2);
            Console.WriteLine(m1 != m2);
            Console.WriteLine(m1.Determinant());
            Console.WriteLine(m3.Determinant());
            Console.WriteLine(m4.Determinant());
            Console.ReadLine();


        }
    }
}
