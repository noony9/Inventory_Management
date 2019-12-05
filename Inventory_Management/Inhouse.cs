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
    public class Inhouse : Part
    {
        // Fields
        private int machineID;

        // Properties
        public int MachineID { get; set; }

        // Constructor

        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        {
            this.PartID = partID;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.Max = max;
            this.MachineID = machineID;
        }


        
    }
}
