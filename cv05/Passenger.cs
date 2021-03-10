using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class PassengerCar : Car
    {
        private int transportedPersons;
        public int MaxPersons { get; private set; }

        public int TransportedPersons
        {
            get { return this.transportedPersons; }
            set
            {
                this.transportedPersons = this.CheckTransportedPersons(value);
            }
        }

        public PassengerCar(double sizeOfTank, double stateOfTank, TypeOfFuel fuel, int maxPersons, int transportedPersons = 0)
            : base(sizeOfTank, stateOfTank, fuel)
        {
            MaxPersons = maxPersons;
            TransportedPersons = transportedPersons;
        }

        private int CheckTransportedPersons(int numberOfPersons)
        {
            if (numberOfPersons <= this.MaxPersons)
            {
                return numberOfPersons;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Persons out of limit");
            }
        }
    }
}
