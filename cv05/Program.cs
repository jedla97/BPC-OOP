﻿using System;
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
               // PassengerCar p = new PassengerCar(5, 18, Car.TypeOfFuel.diesel, 5, 4);
               // Console.WriteLine(p.TransportedPersons);
               // p.TransportedPersons = 2;
               // Console.WriteLine(p.TransportedPersons);
                Console.WriteLine(c.Fuel + "   " + c.StateOfTank);
           
            Console.ReadLine();

        }
    }
}
