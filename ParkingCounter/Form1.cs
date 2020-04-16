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
        ParkingCounter_Business_Layer.Program.RequestDTO DTO = new ParkingCounter_Business_Layer.Program.RequestDTO();
        public Form1()
        {
            InitializeComponent();
            foreach(string s in ParkingCounter_Business_Layer.Program.MakeListOfCars())
                comboBoxCarType.Items.Add(s);
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DTO.type = comboBoxCarType.Text;
            try
            {
                DTO.hours = Convert.ToDouble(textBoxHours.Text);
                DTO.factor = Convert.ToDouble(textBoxFactor.Text);
                DTO.rentCost = Convert.ToDouble(textBoxRentCost.Text);
            }
            catch (FormatException ex) {
                MessageBox.Show("Something goes wrong. Please, try again!", "!!Error!!", MessageBoxButtons.OK);
                return;
            }
            labelBill.Text= "Bill: "+ParkingCounter_Business_Layer.Program.Count(DTO);   
        }
    }
}
