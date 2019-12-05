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
    public abstract class Part
    {
        // Fields
        private int partID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        // Properties
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price
        {
            get { return price; }
            set
            {
                price = (decimal)value;
            }
        }
        public int InStock { get; set; }
        public int Min
        {
            get { return min; }
            set
            {
                if (value > max)
                {
                    MessageBox.Show("Value cannot exceed Max");
                }
                else min = value;
            }
        }
        public int Max
        {
            get { return max; }
            set
            {
                if (value < min)
                {
                    MessageBox.Show("Value cannot be lower than Min");
                }
                else max = value;
            }
        }
    }
}
