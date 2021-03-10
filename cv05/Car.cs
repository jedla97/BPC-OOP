using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    public class Car
    {

        private Radio radio = new Radio();

        public double SizeOfTank { get; protected set; }

        public double StateOfTank { get; set; }

        public TypeOfFuel Fuel { get; set; }


        public enum TypeOfFuel
        {
            petrol, diesel
        }

        public Car(double sizeOfTank, TypeOfFuel fuel, double stateOfTank = 0)
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

        //radio section

        public double GetRadioFrequency()
        {
            return radio.Frequency;
        }

        public bool RadioIsTurnOn()
        {
            return radio.TurnOn;
        }

        public void SetElementOfPreset(int index, double frequency)
        {
            radio.AddToPreset(index, frequency);
        }
    }
};
