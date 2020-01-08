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
        Product product = new Product();
        public Main_Form()
        {
            InitializeComponent();
            InitializeProductsAndParts();
            RefreshGridViews();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGridViews();
        }

        public void InitializeProductsAndParts() // initialize base lists of parts and products
        {
            // Create products
            Inventory.Products.Add(new Product(001, "Yellow Figurine", 99.00m, 55, 0, 100));
            Inventory.Products.Add(new Product(002, "Green Figurine", 82.00m, 29, 0, 100));
            Inventory.Products.Add(new Product(003, "Blue Figurine", 54.10m, 28, 0, 100));
            Inventory.Products.Add(new Product(004, "Purple Figurine", 78.25m, 17, 0, 100));
            Inventory.Products.Add(new Product(005, "Red Figurine", 20.05m, 5, 0, 100));

            // Create inhouse parts
            Inventory.Parts.Add(new Inhouse(111, "Helmet", 10.00m, 80, 0, 100, 7777));
            Inventory.Parts.Add(new Inhouse(112, "Cape", 8.00m, 60, 0, 100, 7778));
            Inventory.Parts.Add(new Inhouse(113, "Bo Staff", 16.00m, 61, 0, 100, 7779));

            // Create outsourced parts
            Inventory.Parts.Add(new Outsourced(211, "Gloves", 17.00m, 43, 0, 100, "Company A"));
            Inventory.Parts.Add(new Outsourced(212, "Suit", 21.20m, 28, 0, 100, "Company B"));
            Inventory.Parts.Add(new Outsourced(213, "Boots", 36.99m, 87, 0, 100, "Company B"));

            // add associated parts to product 001
            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(111));
            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(112));
            Inventory.LookupProduct(001).AddAssociatedPart(Inventory.LookupPart(113));

            // add associated parts to product 002
            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(111));
            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(112));
            Inventory.LookupProduct(002).AddAssociatedPart(Inventory.LookupPart(113));

            // add associated parts to product 003
            Inventory.LookupProduct(003).AddAssociatedPart(Inventory.LookupPart(112));
            Inventory.LookupProduct(003).AddAssociatedPart(Inventory.LookupPart(211));

            // add associated parts to product 004
            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(113));
            Inventory.LookupProduct(004).AddAssociatedPart(Inventory.LookupPart(212));

            // add associated parts to product 005
            Inventory.LookupProduct(005).AddAssociatedPart(Inventory.LookupPart(112));
            Inventory.LookupProduct(005).AddAssociatedPart(Inventory.LookupPart(213));
        }
        public void RefreshGridViews()
        {
           // MainParts_GridView.AutoGenerateColumns = false;
            MainParts_GridView.DataSource = Inventory.Parts;
            MainParts_GridView.ClearSelection();

           // MainProducts_GridView.AutoGenerateColumns = false;
            MainProducts_GridView.DataSource = Inventory.Products;
            MainProducts_GridView.ClearSelection();
        }

        private void Main_Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ---------------Part methods------------------//

        private void Main_Parts_Search_Btn_Click(object sender, EventArgs e)
        {
            if (Main_Parts_Search_TextBox.TextLength < 0)
            {
                return;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in MainParts_GridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        Part userEntry = Inventory.LookupPart(Convert.ToInt32(Main_Parts_Search_TextBox.Text));

                        if (userEntry.PartID == part?.PartID) // Exception Handling: return null instead of throwing NullReferenceException if user searches for value that does not exist
                        {
                            row.Selected = true;
                            MainParts_GridView.CurrentCell = row.Cells[0];
                            return;
                        }
                        else
                        {
                            row.Selected = false;
                        }
                    }
                }
                catch { }
            }
        }

        private void Main_Parts_Add_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Add part screen
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.Show();
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
            DialogResult confirm = MessageBox.Show("Please confirm that you wish to remove this item", "Delete?", MessageBoxButtons.OKCancel);
            {

                if (confirm == DialogResult.OK)
                {
                    // Part part = (Part)MainParts_GridView.CurrentRow.DataBoundItem;
                    //  Inventory.DeletePart(part);
                    var rowIndex = MainParts_GridView.CurrentCell.RowIndex;
                    MainParts_GridView.Rows.RemoveAt(rowIndex);
                    if (MainParts_GridView.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
                    {
                        Inhouse inhousePart = (Inhouse)MainParts_GridView.CurrentRow.DataBoundItem;
                        product.RemoveAssociatedPart(rowIndex);
                    }
                    else if (MainParts_GridView.CurrentRow.DataBoundItem.GetType() == typeof(Outsourced))
                    {
                        Outsourced outsourcedPart = (Outsourced)MainParts_GridView.CurrentRow.DataBoundItem;
                        product.RemoveAssociatedPart(rowIndex);

                    }
                }
                else return;
            }

        }

        // ---------------Product methods------------------//
        private void Main_Products_Search_Btn_Click(object sender, EventArgs e)
        {

            if (Main_Products_Search_TextBox.TextLength < 0)
            {
                return;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in MainProducts_GridView.Rows)
                    {
                        Product product = (Product)row.DataBoundItem;
                        Product userEntry = Inventory.LookupProduct(Convert.ToInt32(Main_Products_Search_TextBox.Text));

                        if (userEntry.ProductID == product?.ProductID) // Exception Handling: return null instead of throwing NullReferenceException if user searches for value that does not exist
                        {
                            row.Selected = true;
                            MainProducts_GridView.CurrentCell = row.Cells[0];
                            return;
                        }
                        else
                        {
                            row.Selected = false;
                        }
                    }
                }
                catch { } 
            }
        }

        private void Main_Products_Add_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Add product screen
            new AddProductForm().ShowDialog();
        }

        private void Main_Products_Modify_Btn_Click(object sender, EventArgs e)
        {
            // bring up instance of Modfy product screen and product
            Product product = (Product)MainProducts_GridView.CurrentRow.DataBoundItem;
            new ModifyProductForm(product).ShowDialog();
        }

        private void Main_Products_Delete_Btn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Please confirm that you wish to remove this item", "Delete?", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
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
            else return;

            
        }

    }
}
