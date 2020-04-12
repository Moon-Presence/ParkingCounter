using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    abstract class CarFactory
    {
        protected double factor;
        public CarFactory(double value) {
            this.factor = value;
        }
        public CarFactory() { }
        public abstract Car GetCar();
    }
}
