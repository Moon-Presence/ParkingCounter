using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    class MunicipalTransport : Car
    {
        public MunicipalTransport(double value) : base(value)
        {
        }
        public override double Bill(double rentTax, double hours)
        {
            return rentTax * hours * this.factor;
        }
    }
}
