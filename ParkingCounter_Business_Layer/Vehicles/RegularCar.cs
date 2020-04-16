using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    class RegularCar : Car
    {

        public RegularCar(double value) : base(value)
        {
        }

        public override double Bill(double rentTax, double hours)
        {
            return rentTax * hours;
        }
    }
}
