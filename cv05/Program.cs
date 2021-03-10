using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(28,18,Car.TypeOfFuel.petrol);
            Console.WriteLine(c.Fuel + "   " + c.SizeOfTank);
            Console.ReadLine();
        }
    }
}
