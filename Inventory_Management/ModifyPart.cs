using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class ModifyPartForm : Form
    {
        public ModifyPartForm()
        {
            InitializeComponent();
        }

        public ModifyPartForm(Inhouse inhouse)
        {
            InitializeComponent();
            
            this.IDTextBox.Text = Convert.ToString(inhouse.PartID);
            this.NameTextBox.Text = inhouse.Name;
            this.InventoryTextBox.Text = Convert.ToString(inhouse.InStock);
            this.PriceCostTextBox.Text = Convert.ToString(inhouse.Price);
            this.MinTextBox.Text = Convert.ToString(inhouse.Min);
            this.MaxTextBox.Text = Convert.ToString(inhouse.Max);
            this.MachineIDTextBox.Text = Convert.ToString(inhouse.MachineID);
          
        }

        public ModifyPartForm(Outsourced outsourced)
        {
            InitializeComponent();

            this.IDTextBox.Text = Convert.ToString(outsourced.PartID);
            this.NameTextBox.Text = outsourced.Name;
            this.InventoryTextBox.Text = Convert.ToString(outsourced.InStock);
            this.PriceCostTextBox.Text = Convert.ToString(outsourced.Price);
            this.MinTextBox.Text = Convert.ToString(outsourced.Min);
            this.MaxTextBox.Text = Convert.ToString(outsourced.Max);
            this.MachineIDTextBox.Text = Convert.ToString(outsourced.CompanyName);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Min_Click(object sender, EventArgs e)
        {

        }

        private void MachineID_Click(object sender, EventArgs e)
        {

        }

        private void Max_Click(object sender, EventArgs e)
        {

        }

        private void PriceCost_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void OutsourcedPart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InHousePart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
