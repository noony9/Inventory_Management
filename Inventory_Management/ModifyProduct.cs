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
    public partial class ModifyProductForm : Form
    {
        public ModifyProductForm(Product product)
        {
            InitializeComponent();

            IDTextBox.Text = Convert.ToString(product.ProductID);
            NameTextBox.Text = product.Name;
            InventoryTextBox.Text = Convert.ToString(product.InStock);
            PriceTextBox.Text = Convert.ToString(product.Price);
            MinTextBox.Text = Convert.ToString(product.Min);
            MaxTextBox.Text = Convert.ToString(product.Max);

            ModifyProduct_CandidateParts_GridView.DataSource = Inventory.Parts;
            ModifyProduct_PartsAssociated_GridView.DataSource = product.AssociatedParts;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            Product product = new Product(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text));
            Inventory.UpdateProduct(int.Parse(IDTextBox.Text), product);
            Inventory.RefreshLists();
            this.Close();
        }

        private void ModifyProduct_Search_Btn_Click(object sender, EventArgs e)
        {
            if (ModifyProduct_Search_TextBox.TextLength < 0)
            {
                return;
            }
            else
            {

                foreach (DataGridViewRow row in ModifyProduct_CandidateParts_GridView.Rows)
                {
                    Product product = (Product)row.DataBoundItem;
                    Product userEntry = Inventory.LookupProduct(Convert.ToInt32(ModifyProduct_CandidateParts_GridView.Text));

                    if (userEntry.ProductID == product.ProductID)
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
    }
}
