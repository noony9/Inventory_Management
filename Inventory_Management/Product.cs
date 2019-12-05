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
    public class Product
    {
        // Fields
        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        // Constructor
        public Product() { }

        // Overload Constructor
        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            this.productID = productID;
            this.name = name;
            this.price = price;
            this.inStock = inStock;
            this.min = min;
            this.max = max;
        }

        // Properties
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
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
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int partID)
        {
            bool check = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return check = true;
                }
                else check = false;
            }
            return check;
        }
        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
