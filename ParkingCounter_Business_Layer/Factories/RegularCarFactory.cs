using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    class RegularCarFactory : CarFactory
    {
        public RegularCarFactory(double value) : base(value)
        {
        }
        public override Car GetCar()
        {
            return new RegularCar(this.factor);
        }
    }
}
