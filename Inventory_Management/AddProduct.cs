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
    public partial class AddProductForm : Form
    {
        Product product = new Product();

        public AddProductForm()
        {
            InitializeComponent();
   
        }

        private void Add_Product_Form_Load(object sender, EventArgs e)
        {
       
            // bind base list of parts to DataGridView using a DataSource intermediary
            var bsPart = new BindingSource();
            bsPart.DataSource = Inventory.Parts;
            AddProduct_CandidateParts_GridView.DataSource = bsPart;

            bsPart.DataSource = null;
            bsPart.DataSource = Inventory.Parts;


            // bind base list of AssociatedParts to DataGridView using a DataSource intermediary
            var bsProduct = new BindingSource();
            var product = new Product();
            bsProduct.DataSource = product.AssociatedParts;
            AddProduct_PartsAssociated_GridView.DataSource = bsProduct;

            bsProduct.DataSource = null;
            bsProduct.DataSource = product.AssociatedParts;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text));
//FIXME: associated products
            Inventory.AddProduct(product);
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (AddProduct_Search_TextBox.TextLength < 0)
            {
                return;
            }
            else
            {

                foreach (DataGridViewRow row in AddProduct_CandidateParts_GridView.Rows)
                {
                    Part part = (Part)row.DataBoundItem;
                    Part userEntry = Inventory.LookupPart(Convert.ToInt32(AddProduct_Search_TextBox.Text));

                    if (userEntry.PartID == part.PartID)
                    {
                        row.Selected = true;
                        AddProduct_CandidateParts_GridView.CurrentCell = row.Cells[0];
                        return;
                    }
                    else
                    {
                        row.Selected = false;
                    }

                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            // add the part to it's AssociatedPart list
            if (AddProduct_CandidateParts_GridView.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                product.AddAssociatedPart((Inhouse)AddProduct_CandidateParts_GridView.CurrentRow.DataBoundItem);
                AddProduct_PartsAssociated_GridView.DataSource = product.AssociatedParts;
            }
            else
            {
                product.AddAssociatedPart((Outsourced)AddProduct_CandidateParts_GridView.CurrentRow.DataBoundItem);
                AddProduct_PartsAssociated_GridView.DataSource = product.AssociatedParts;
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Please confirm that you wish to remove this item", "Delete?", MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {
                    var rowIndex = AddProduct_PartsAssociated_GridView.CurrentCell.RowIndex;
                    AddProduct_PartsAssociated_GridView.Rows.RemoveAt(rowIndex);
                }
                else return;
            }
        }
    }
}
