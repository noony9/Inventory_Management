using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Inventory_Management
{
    public class Outsourced : Part
    {
        // Fields
        private string companyName;

        // Properties
        public string CompanyName { get; set; }

        // Constructor
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
        {
            this.PartID = partID;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.Max = max;
            this.CompanyName = companyName;
        }
    }
}
