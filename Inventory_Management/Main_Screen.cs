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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

            // initialize base lists of parts and products

            Inventory.InitializeProductsAndParts();

            // bind base list of parts and products to dataGridView

            MainParts_GridView.DataSource = Inventory.Parts;
            MainProducts_GridView.DataSource = Inventory.Products;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Main_Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Parts_Search_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Main_Parts_Add_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Add part screen
            new AddPartForm().ShowDialog();
        }

        private void Main_Parts_Modify_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Modfy part screen with instance of user type selected by row
            if (MainParts_GridView.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                Inhouse inhousePart = (Inhouse)MainParts_GridView.CurrentRow.DataBoundItem;
                new ModifyPartForm(inhousePart).ShowDialog();
            }
            else if (MainParts_GridView.CurrentRow.DataBoundItem.GetType() == typeof(Outsourced))
            {
                Outsourced outsourcedPart = (Outsourced)MainParts_GridView.CurrentRow.DataBoundItem;
                new ModifyPartForm(outsourcedPart).ShowDialog();
            }  
        }

        private void Main_Parts_Delete_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Main_Products_Search_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Main_Products_Add_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Add product screen
            new AddProductForm().ShowDialog();
        }

        private void Main_Products_Modify_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Modfy product screen
            new ModifyProductForm().ShowDialog();
        }

        private void Main_Products_Delete_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
