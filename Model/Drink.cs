using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Model
{
    public class Drink : Product
    {
        public string description { get; set; }
        public bool isCarbonated { get; set; }
        public Drink(int productId, string productName, int productPrice, string description, bool isCarbonated) : base(productId, productName, productPrice)
        {
            this.description = description;
            this.isCarbonated = isCarbonated;
        }
        public override string GetDescription()
        {
            return description;
        }
        public bool IsCarbonated()
        {
            return isCarbonated;
        }
        public override string EssentialInfo()
        {
            return "drink me";
        }
        public override string Info()
        {
            return $"----- {this.GetType().Name} Info -----\nName: {productName} \nPrice: {productPrice}\nDescription: {GetDescription()}\nIs Carbonated: {isCarbonated}";
        }
    }
}
