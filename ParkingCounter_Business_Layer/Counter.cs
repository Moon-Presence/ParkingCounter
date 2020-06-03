using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        private double rentCost;
        //
        private CarFactory factory;
        private Car car;

        public Counter(Program.RequestDTO DTO)
        {
            this.type = DTO.type;
            this.hours = DTO.hours;
            this.factor = DTO.factor;
            this.rentCost = DTO.rentCost;
            factory = TypeParser.GetFactory(DTO.type, DTO.factor);
        }

        
        public double Count() {
            car = factory.GetCar();
            return car.Bill(rentCost, hours);
        }
    }
}
