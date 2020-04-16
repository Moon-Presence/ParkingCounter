using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    class RegularCarFactory : CarFactory
    {
        public RegularCarFactory() : base()
        {
        }
        public override Car GetCar()
        {
            return new RegularCar();
        }
    }
}
