using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    class Counter
    {
        //Import from DTO
        private string type;
        private double hours;
        private double factor;
        private double rentTax;
        //
        private CarFactory factory;
        private Car car;

        public Counter(RequestDTO DTO)
        {
            this.type = DTO.type;
            this.hours = DTO.hours;
            this.factor = DTO.factor;
            this.rentTax = DTO.rentTax;
            switch (type)
            {
                case "RegularCar": factory = new RegularCarFactory(); break;
                case "Truck": factory = new TruckFactory(factor); break;
                case "MunicipalTransport": factory = new MunicipalTransportFactory(factor); break;
            }
        }

        public double Count() {
            car = factory.GetCar();
            return car.Bill(rentTax, hours);
        }
    }
}
