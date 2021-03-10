using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    class Lorry : Car
    {
        public double transportedLoad;

        public double MaxLoad { get; private set; }

        public double TransportedLoad {
            get { return this.transportedLoad; }
            set
            {
                this.transportedLoad = this.CheckTransportedLoad(value);
            }
        }

        public Lorry(double sizeOfTank, double stateOfTank, TypeOfFuel fuel , double maxLoad, double transportedLoad = 0) 
            : base(sizeOfTank,stateOfTank,fuel)
        {
            MaxLoad = maxLoad;
            TransportedLoad = transportedLoad;
        }
        private double CheckTransportedLoad(double load)
        {
            if (load <= this.MaxLoad)
            {
                return load;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Over limit load");
            }
        }

    }
}
