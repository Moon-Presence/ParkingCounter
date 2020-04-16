using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    class DataParser
    {
        private Program.RequestDTO DTO = new Program.RequestDTO();
        public bool status= false;
        public DataParser(string[] args) {
            status = slaughter(args); 
        }
        private bool slaughter(string[] args) {
            if (args.Length != 4) return false;

            List<string> typeList = TypeParser.carsTypeListCreator();
            if (!typeList.Contains(args[0])) return false;
            DTO.type = args[0];

            try
            {
                DTO.hours = Convert.ToDouble(args[1]);
                DTO.factor = Convert.ToDouble(args[2]);
                DTO.rentCost = Convert.ToDouble(args[3]);                
            }
            catch (FormatException e) { return false; }

            return DataCheck(DTO);
        }
        public static bool DataCheck(Program.RequestDTO DTO) {
            if (DTO.hours <= 0 || DTO.factor <= 0 || DTO.rentCost <= 0) return false;
            return true;
        }
        public Program.RequestDTO Parse() {
            return DTO;
        }        
    }
}
