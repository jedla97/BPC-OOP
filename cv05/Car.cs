using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Car
    {


        public double SizeOfTank { get; protected set; }

        public double StateOfTank { get; set; }

        public TypeOfFuel Fuel { get; set; }


        public enum TypeOfFuel {
            petrol, diesel
        }

        public Car(double sizeOfTank, double stateOfTank, TypeOfFuel fuel)
        {
            SizeOfTank = sizeOfTank;
            StateOfTank = stateOfTank;
            Fuel = fuel;
        }

        public void refuel(TypeOfFuel fuel, double amount)
        {
            if (fuel != Fuel)
            {
                throw new Exception("Not same type of fuel");
            }
            if (amount + StateOfTank > SizeOfTank)
            {
                throw new Exception("Tank was over floaded");
            }
            else
            {
                StateOfTank = StateOfTank + amount;
            }
    }
}
