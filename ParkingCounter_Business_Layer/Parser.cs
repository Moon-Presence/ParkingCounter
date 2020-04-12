using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    class Parser
    {
        private RequestDTO DTO;
        public bool status= false;

        public Parser(string[] args) {
            status = slaughter(args); 
        }

        private bool slaughter(string[] args) {
            if (args.Length != 4) return false;

            IEnumerable<Type> bufList = Assembly.GetAssembly(typeof(Car)).GetTypes().Where(type => type.IsSubclassOf(typeof(Car)));
            List<string> typeList = new List<string>();
            foreach (Type t in bufList)
            {
                typeList.Add(t.ToString());
            }
            if (!typeList.Contains(args[0])) return false;

            DTO.type = args[0];

            try
            {
                DTO.hours = Convert.ToDouble(args[1]);
                DTO.factor = Convert.ToDouble(args[2]);
                DTO.rentTax = Convert.ToDouble(args[3]);                
            }
            catch (FormatException e) { return false; }

            if (DTO.hours <= 0 || DTO.factor <= 0 || DTO.rentTax <= 0) return false;

            return true;
        }

        public RequestDTO Parse() {
            return DTO;
        }
    }
}
