using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    class TypeParser
    {
        public static List<string> carsTypeListCreator()
        {
            IEnumerable<Type> bufList = Assembly.GetAssembly(typeof(Car)).GetTypes().Where(type => type.IsSubclassOf(typeof(Car)));
            List<string> typeList = new List<string>();
            foreach (Type t in bufList)
            {
                typeList.Add(t.Name);
            }
            return typeList;
        }
        private static IEnumerable<Type> factoriesTypeListCreator() {
            return Assembly.GetAssembly(typeof(CarFactory)).GetTypes().Where(type => type.IsSubclassOf(typeof(CarFactory)));
        }
        public static SortedDictionary<string, Type> CarFactoryMap() {
            SortedDictionary<string, Type> map = new SortedDictionary<string, Type>();
            List<string> cars = carsTypeListCreator();
            IEnumerable<Type> factories = factoriesTypeListCreator();
            foreach (string car in cars)
                foreach (Type factory in factories)
                    if (factory.Name.Contains(car))
                        map.Add(car, factory);
            return map;
        }
    }
}
