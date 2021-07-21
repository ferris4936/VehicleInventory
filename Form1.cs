using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleInventory
{
    public partial class VehicleInventoryForm : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

       
        public VehicleInventoryForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "Sedan")
            {
                Sedan sedan = new Sedan();
                sedan.LicensePlate = tbLicense.Text;
                sedan.VIN = tbVIN.Text;
                vehicles.Add(sedan);
                //Refresh the list box
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                tbResults.Text = "Successfuly added sedan";
            }
            else if (cbType.Text == "Truck")
            {
                Truck truck = new Truck(tbVIN.Text, tbLicense.Text);
                vehicles.Add(truck);
                //Refresh the list box
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                tbResults.Text = "Successfuly added truck";
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbLicense_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbType_Click(object sender, EventArgs e)
        {

        }

        private void lbInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Vehicle vehicle = (Vehicle)lbInventory.SelectedItem;
            tbSummary.Text = vehicle.GetDescription();
        }
    }
}
