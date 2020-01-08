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
    public class Inventory
    {
        Main_Form mainScreen = new Main_Form();

        // Properties
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();

        //--------------------Product Methods---------------------//

        // add new products
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // iterate through Products list and remove products if the productID is a match
        public static bool RemoveProduct(int productID) // bind to remove button
        {
            bool check = false;
            foreach (Product p in Products)
            {
                if (productID == p.ProductID)
                {
                    Products.Remove(p);
                    check = true;
                }
                else
                {
                    MessageBox.Show("Product does not Exist");
                    check = false;
                }
            }
            return check;
        }

        // iterate through Products list and return it if found, else display not found
        public static Product LookupProduct(int productID)  //bind to search button
        {
            foreach (Product p in Products)
            {
                if (p.ProductID == productID)
                {
                    return p;
                }
            }
            return null;
        }
        
        // iterate through Products list and update Product fields with user arguments
        public static void UpdateProduct(int productID, Product product) // bind to save button
        {
            foreach(Product p in Products)
            {
                if (productID == p.ProductID)
                {
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.InStock = product.InStock;
                    p.Min = product.Min;
                    p.Max = product.Max;
                    return;
                }
            }
        }
        //--------------------Part Methods---------------------//

        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

        // iterate through Parts list and remove products if the partID is a match
        public static bool DeletePart(Part part) // bind to remove button
        {
            bool check = false;
            foreach (Part p in Parts)
            {
                if (p.PartID == part.PartID)
                {
                    Parts.Remove(p);
                    check = true;
                }
                else
                {
                    MessageBox.Show("Part does not Exist");
                    check = false;
                }
            }
            return check;
        }

        // iterate through Parts list and return it if found, else display not found
        public static Part LookupPart(int partID)  //bind to search button
        {
            foreach (Part p in Parts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }
            }
            return null;
        }

        // iterate through Parts list and update Part fields with user arguments
        public static void UpdatePart(int partID, Part part) // bind to save button
        {
            foreach (Part p in Parts)
            {
                if (p.PartID == partID)
                {
                    p.PartID = part.PartID;
                    p.Name = part.Name;
                    p.Price = part.Price;
                    p.InStock = part.InStock;
                    p.Min = part.Min;
                    p.Max = part.Max;
                    return;
                }
            }
        }
    }
}
