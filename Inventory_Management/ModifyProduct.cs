﻿using System;
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
        Product product = new Product();
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
           // Main_Form mainForm = new Main_Form();
           // mainForm.ShowDialog();
            this.Close();


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            Product product = new Product(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text));
            Inventory.UpdateProduct(int.Parse(IDTextBox.Text), product);
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
                    Part part = (Part)row.DataBoundItem;
                    Part userEntry = Inventory.LookupPart(Convert.ToInt32(ModifyProduct_Search_TextBox.Text));

                    if (userEntry.PartID == part.PartID)
                    {
                        row.Selected = true;
                        ModifyProduct_CandidateParts_GridView.CurrentCell = row.Cells[0];
                        return;
                    }
                    else
                    {
                        row.Selected = false;
                    }

                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Please confirm that you wish to remove this item", "Delete?", MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {
                    var rowIndex = ModifyProduct_PartsAssociated_GridView.CurrentCell.RowIndex;
                    ModifyProduct_PartsAssociated_GridView.Rows.RemoveAt(rowIndex);
                }
                else return;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // add the part to it's AssociatedPart list

                int partID = Convert.ToInt32(ModifyProduct_CandidateParts_GridView.Rows[ModifyProduct_CandidateParts_GridView.CurrentCell.RowIndex].Cells[0].Value);
                product.AddAssociatedPart(Inventory.LookupPart(partID));
               // ModifyProduct_PartsAssociated_GridView.DataSource = product.AssociatedParts;
                

        }
    }
}
