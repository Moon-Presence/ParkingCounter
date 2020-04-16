using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCounter
{
    public partial class Form1 : Form
    {
        ParkingCounter_Business_Layer.RequestDTO DTO = new ParkingCounter_Business_Layer.RequestDTO();
        public Form1()
        {
            InitializeComponent();
            DTO.type = "RegularCar";
            DTO.hours = 12;
            DTO.rentTax = 2.5;
            DTO.factor = 0;                    
            this.Text= ""+ParkingCounter_Business_Layer.Program.Count(DTO);
        }
    }
}
