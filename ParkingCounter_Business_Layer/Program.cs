using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCounter_Business_Layer
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser p = new Parser(args);
            if (p.status) 
                Console.WriteLine(new Counter(p.Parse()).Count());
        }
    }
}
