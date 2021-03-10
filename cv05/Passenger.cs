using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class PassengerCar : Car
    {
        public double MaxPersons { get; private set; }

        public double TransportedPersons { get; set; }

        public PassengerCar(double sizeOfTank, double stateOfTank, TypeOfFuel fuel, double maxPersons, double transportedPersons)
            : base(sizeOfTank, stateOfTank, fuel)
        {
            MaxPersons = maxPersons;
            TransportedPersons = transportedPersons;
        }
    }
}
