using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataParser p = new DataParser(args);
            if (p.status)
                Console.WriteLine(new Counter(p.Parse()).Count());
        }
        public static double Count(RequestDTO DTO)
        {
            if (!DataParser.DataCheck(DTO)) return 0;
            return new Counter(DTO).Count();
        }        
        public static List<string> MakeListOfCars()
        {
            return TypeParser.carsTypeListCreator();
        }
        public class RequestDTO
        {
            public string type;
            public double hours;
            public double factor;
            public double rentCost;
        }
    }
}
