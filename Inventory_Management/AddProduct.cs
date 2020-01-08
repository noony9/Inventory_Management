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
    public partial class AddProductForm : Form
    {
        Product product = new Product();

        public AddProductForm()
        {
            InitializeComponent();
            AddProduct_CandidateParts_GridView.DataSource = Inventory.Parts;
            AddProduct_PartsAssociated_GridView.DataSource = product.AssociatedParts;
        }

        private void Add_Product_Form_Load(object sender, EventArgs e)
        {

        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // verify fields are not null
            if (String.IsNullOrWhiteSpace(IDTextBox.Text) || String.IsNullOrWhiteSpace(NameTextBox.Text) || String.IsNullOrWhiteSpace(PriceTextBox.Text) || String.IsNullOrWhiteSpace(InventoryTextBox.Text) || String.IsNullOrWhiteSpace(MinTextBox.Text) || String.IsNullOrWhiteSpace(MaxTextBox.Text))
            {
                MessageBox.Show("Fields cannot be empty");
                return;
            }
            // verify integer fields are of the appropriate type
            if (int.Parse(IDTextBox.Text).GetType() != typeof(int) || int.Parse(InventoryTextBox.Text).GetType() != typeof(int) || int.Parse(MaxTextBox.Text).GetType() != typeof(int) || int.Parse(MaxTextBox.Text).GetType() != typeof(int))
            {
                MessageBox.Show("Ensure fields that require integers contain integers");
                return;
            }
            // verify decimal field is of the appropriate type
            if (decimal.Parse(PriceTextBox.Text).GetType() != typeof(decimal))
            {
                MessageBox.Show("Ensure Price field entry is in decimal format. Example: 0.00");
                return;
            }
            // verify inventory level does not exceed max
            if (int.Parse(InventoryTextBox.Text) > int.Parse(MaxTextBox.Text))
            {
                MessageBox.Show("Inventory stock level cannot exceed Maximum permitted stock level");
                return;
            }
            // verify that minimum level does not exceed max
            if (int.Parse(MinTextBox.Text) > int.Parse(MaxTextBox.Text))
            {
                MessageBox.Show("Minimum permitted stock level cannot exceed Maximum permitted stock level");
                return;
            }
            else
            {
                // throw exception
                try
                {
                    Product product = new Product(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text));
                    try
                    {
                        foreach (DataGridViewRow row in AddProduct_PartsAssociated_GridView.Rows)
                        {
                            Part associatedPart = (Part)row.DataBoundItem;
                            product.AssociatedParts.Add(associatedPart);
                        }
                    }
                    catch { }
                    Inventory.AddProduct(product);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                    throw;
                }
                this.Close();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (AddProduct_Search_TextBox.TextLength < 0)
            {
                return;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in AddProduct_CandidateParts_GridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        Part userEntry = Inventory.LookupPart(Convert.ToInt32(AddProduct_Search_TextBox.Text));

                        if (userEntry.PartID == part?.PartID) // Exception Handling: return null instead of throwing NullReferenceException if user searches for value that does not exist
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
                catch { }             
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            // add the part to it's AssociatedPart list
            Part part = (Part)AddProduct_CandidateParts_GridView.CurrentRow.DataBoundItem;
            product.AddAssociatedPart(part);
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
        private void ResetFields_Btn_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }
    }
}
