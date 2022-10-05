using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Vending_Machine.Data;

namespace Vending_Machine.Model
{
    public class VendingMachineServices : VendingMachine
    {
        private Product[] products = new Product[9];
        public Product[]? Products { get { return products; } }
        
        


        //public Product[] NewDrink(int productId, string productName, int productPrice)
        //{
        //    Product p = new Drink(productId, productName, productPrice);
        //    products[productId] = p;
        //    return products;
        //}
        //public Product[] GetItems()
        //{
        //    return products;
        //}

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"1.Insert money\n2.Show list of products\n3.Exit");
        }
        //public void Info()
        //{
        //    foreach (Product p in products)
        //    {
        //        Console.WriteLine($"----- {this.GetType().Name} Info -----\nID:{p.productId}\nName: {p.productName} \nPrice: {p.productPrice}");
        //    }
            
        //}
    }
}

