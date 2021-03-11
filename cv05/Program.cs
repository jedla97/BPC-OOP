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
            Car c = new Car(28, Car.TypeOfFuel.petrol);
            PassengerCar p = new PassengerCar(5, Car.TypeOfFuel.diesel, 5, 18, 4);
            // Console.WriteLine(p.TransportedPersons);
            // p.TransportedPersons = 2;
            Console.WriteLine(p);
            Console.WriteLine(c.Fuel + "   " + c.StateOfTank);
            c.TurnRadio(true);
            Console.WriteLine(c);

            Console.ReadLine();

        }
    }
}
