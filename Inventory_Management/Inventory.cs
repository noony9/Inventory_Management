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
        // Properties
        BindingList<Product> Products { get; set; }
        BindingList<Part> Parts { get; set; }

        // Method to create a base inventory of products/parts, populate the binding list Products, Parts and AssociatedParts
        public void InitializeProductsAndParts()
        {
            // Create products
            Product product1 = new Product(001, "Yellow Card", 99.00m, 5, 1, 10);
            Product product2 = new Product(002, "Green Card", 82.00m, 15, 1, 10);
            Product product3 = new Product(003, "Blue Card", 54.10m, 28, 1, 10);
            Product product4 = new Product(004, "Purple Card", 78.25m, 17, 1, 10);
            Product product5 = new Product(005, "Red Card", 20.05m, 5, 1, 10);

            // Create inhouse parts
            Part inhouse1 = new Inhouse(001, "Card Holder", 10.00m, 115, 1, 10, 7777);
            Part inhouse2 = new Inhouse(001, "Magnet", 8.00m, 430, 1, 10, 7778);
            Part inhouse3 = new Inhouse(001, "Wallet", 16.00m, 66, 1, 10, 7779);

            // Create outsourced parts
            Part outsourced1 = new Outsourced(001, "Glue", 10.00m, 115, 1, 10, "Company A");
            Part outsourced2 = new Outsourced(001, "Thread", 10.00m, 115, 1, 10, "Company B");
            Part outsourced3 = new Outsourced(001, "Leather Straps", 10.00m, 115, 1, 10, "Company B");

            // Add products to Products list

            Products.Add(product1);
            Products.Add(product2);
            Products.Add(product3);
            Products.Add(product4);
            Products.Add(product5);

            // Add parts to Parts list
            Parts.Add(inhouse1);
            Parts.Add(inhouse2);
            Parts.Add(inhouse3);
            Parts.Add(outsourced1);
            Parts.Add(outsourced2);
            Parts.Add(outsourced3);

            // Add parts to products associated list

            // product1 associated parts
            product1.AssociatedParts.Add(inhouse1);
            product1.AssociatedParts.Add(inhouse2);
            product1.AssociatedParts.Add(inhouse3);
            product1.AssociatedParts.Add(outsourced1);
            product1.AssociatedParts.Add(outsourced2);
            product1.AssociatedParts.Add(outsourced3);

            // product2 associated parts
            product2.AssociatedParts.Add(inhouse1);
            product2.AssociatedParts.Add(outsourced3);

            // product3 associated parts
            product3.AssociatedParts.Add(inhouse2);

            // product4 associated parts
            product4.AssociatedParts.Add(inhouse1);
            product4.AssociatedParts.Add(outsourced3);

            // product5 associated parts
            product5.AssociatedParts.Add(inhouse3);
            product5.AssociatedParts.Add(outsourced1);
            product5.AssociatedParts.Add(outsourced3);


        }
        //--------------------Product Methods---------------------//
        // add new products
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // iterate through Products list and remove products if the productID is a match
        public bool RemoveProduct(Product productID) // bind to remove button
        {
            bool check = false;
            foreach (Product p in Products)
            {
                if (productID == p)
                {
                    Products.Remove(p);
                    check = true;
                }
                else MessageBox.Show("Product does not Exist");
                check = false;
            }
            return check;
        }

        // iterate through Products list and return it if found, else display not found
        public Product LookupProduct(int productID)  //bind to search button
        {
            foreach (Product p in Products)
            {
                if (productID == p.ProductID)
                {
                    return p;
                }
                else MessageBox.Show("Product not found");
            }
            return null;
        }
        
        // iterate through Products list and update Product fields with user arguments
        public void UpdateProduct(int productID, Product product) // bind to save button
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
                }
                else MessageBox.Show("Product not found");
            }
        }
        //--------------------Part Methods---------------------//
        public void AddPart(Part part)
        {
            Parts.Add(part);
        }

        // iterate through Parts list and remove products if the partID is a match
        public bool RemovePart(Part partID) // bind to remove button
        {
            bool check = false;
            foreach (Part p in Parts)
            {
                if (partID == p)
                {
                    Parts.Remove(p);
                    check = true;
                }
                else MessageBox.Show("Part does not Exist");
                check = false;
            }
            return check;
        }

        // iterate through Parts list and return it if found, else display not found
        public Part LookupPart(int partID)  //bind to search button
        {
            foreach (Part p in Parts)
            {
                if (partID == p.PartID)
                {
                    return p;
                }
                else MessageBox.Show("Part not found");
            }
            return null;
        }

        // iterate through Parts list and update Part fields with user arguments
        public void UpdatePart(int partID, Part part) // bind to save button
        {
            foreach (Part p in Parts)
            {
                if (partID == p.PartID)
                {
                    p.Name = part.Name;
                    p.Price = part.Price;
                    p.InStock = part.InStock;
                    p.Min = part.Min;
                    p.Max = part.Max;
                }
                else MessageBox.Show("Part not found");
            }
        }
    }
}
