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
            if (Main_Parts_Search_TextBox.TextLength < 0)
            {
                return;
            }
            else
            {
                Part part = Inventory.LookupPart(Convert.ToInt32(Main_Parts_Search_TextBox.Text));
                foreach (DataGridViewRow row in MainParts_GridView.Rows)
                {
                    Part p = (Part)row.DataBoundItem;
                    if (p.PartID == part.PartID)
                    {
                        row.Selected = true;
                        return;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
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
            var rowIndex = MainParts_GridView.CurrentCell.RowIndex;
            MainParts_GridView.Rows.RemoveAt(rowIndex);
        }

        private void Main_Products_Search_Btn_Click(object sender, EventArgs e)
        {

            if (Main_Products_Search_TextBox.TextLength < 0)
            {
                return;
            }
            else
            {
                Product product = Inventory.LookupProduct(Convert.ToInt32(Main_Parts_Search_TextBox.Text));
                foreach (DataGridViewRow row in MainProducts_GridView.Rows)
                {
                    Product prod = (Product)row.DataBoundItem;
                    if (prod.ProductID == product.ProductID)
                    {
                        row.Selected = true;
                        return;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
        }

        private void Main_Products_Add_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Add product screen
            new AddProductForm().ShowDialog();
        }

        private void Main_Products_Modify_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Modfy product screen
            Product product = (Product)MainProducts_GridView.CurrentRow.DataBoundItem;
            new ModifyProductForm(product).ShowDialog();
        }

        private void Main_Products_Delete_Btn_Click(object sender, EventArgs e)
        {
            Product product = (Product)MainProducts_GridView.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot delete a product that has associated parts.  Remove assosicated parts prior to attempting to remove a product.");
            }
            else
            {
                var rowIndex = MainProducts_GridView.CurrentCell.RowIndex;
                MainProducts_GridView.Rows.RemoveAt(rowIndex);
            }
        }

    }
}
