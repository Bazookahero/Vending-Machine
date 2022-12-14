using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Vending_Machine.Data;

namespace Vending_Machine.Model
{
    public abstract class Product : VendingMachine
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
        public int productId { get; private set; }
        public Product(int productId, string productName, int productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productId = productId;
        }
        public abstract string EssentialInfo();
        public abstract string GetDescription();
        public abstract string Info();

        
        //public override string ToString()
        //{
        //    return
        //        "" + productId + " " + productName + " " + productPrice;
        //}
    }
}
