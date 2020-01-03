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
            
            IDTextBox.Text = Convert.ToString(inhouse.PartID);
            NameTextBox.Text = inhouse.Name;
            InventoryTextBox.Text = Convert.ToString(inhouse.InStock);
            PriceCostTextBox.Text = Convert.ToString(inhouse.Price);
            MinTextBox.Text = Convert.ToString(inhouse.Min);
            MaxTextBox.Text = Convert.ToString(inhouse.Max);
            IdentifierLabelTextBox.Text = Convert.ToString(inhouse.MachineID);
            IdentifierLabel.Text = "Machine ID";
            InhouseRadio.Checked = true;
        }

        public ModifyPartForm(Outsourced outsourced)
        {
            InitializeComponent();

            IDTextBox.Text = Convert.ToString(outsourced.PartID);
            NameTextBox.Text = outsourced.Name;
            InventoryTextBox.Text = Convert.ToString(outsourced.InStock);
            PriceCostTextBox.Text = Convert.ToString(outsourced.Price);
            MinTextBox.Text = Convert.ToString(outsourced.Min);
            MaxTextBox.Text = Convert.ToString(outsourced.Max); 
            IdentifierLabelTextBox.Text = Convert.ToString(outsourced.CompanyName);
            IdentifierLabel.Text = "Company Name";
            OutsourcedRadio.Checked = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
   
            if (InhouseRadio.Checked)
            {
              
                InhouseRadio.Checked = true;
                Inhouse inhousePart = new Inhouse(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), int.Parse(IdentifierLabelTextBox.Text));
                Inventory.UpdatePart(int.Parse(IDTextBox.Text), inhousePart);
            }  
            else
            {
                OutsourcedRadio.Checked = true;
                Outsourced outsourcedPart = new Outsourced(int.Parse(IDTextBox.Text), NameTextBox.Text, decimal.Parse(PriceCostTextBox.Text), int.Parse(InventoryTextBox.Text), int.Parse(MinTextBox.Text), int.Parse(MaxTextBox.Text), IdentifierLabelTextBox.Text);
                Inventory.UpdatePart(int.Parse(IDTextBox.Text), outsourcedPart);
            }
            Close();
   
        }

        private void InhouseChecked(object sender, EventArgs e)
        {
            IdentifierLabel.Text = "Machine ID";
        }

        private void OutsourcedChecked(object sender, EventArgs e)
        {
            IdentifierLabel.Text = "Company Name";
        }
    }
}
