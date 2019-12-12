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
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
            InhouseRadio.Checked = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InhouseChecked(object sender, EventArgs e)
        {
            IdentifierLabel.Text = "Machine ID";
        }

        private void OutsourceChecked(object sender, EventArgs e)
        {
            IdentifierLabel.Text = "Company Name";
        }
    }
}
