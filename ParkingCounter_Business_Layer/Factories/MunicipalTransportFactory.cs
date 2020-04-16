using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    class MunicipalTransportFactory : CarFactory
    {
        public MunicipalTransportFactory(double value) : base(value)
        {
        }

        public override Car GetCar()
        {
            return new MunicipalTransport(this.factor);
        }
    }
}
