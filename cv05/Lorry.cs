using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Lorry : Car
    {

        public double MaxLoad { get; private set; }

        public double TransportedLoad { get; set; }

        public Lorry(double sizeOfTank, double stateOfTank, TypeOfFuel fuel , double maxLoad, double transportedLoad) 
            : base(sizeOfTank,stateOfTank,fuel)
        {
            MaxLoad = maxLoad;
            TransportedLoad = transportedLoad;
        }

        }
}
