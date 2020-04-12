using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    public abstract class Car
    {
        protected double factor = 0;
        public abstract double Bill(double rentTax, double hours);
        public Car() { }
        public Car(double value) {
            factor = value;
        }
    }
}
