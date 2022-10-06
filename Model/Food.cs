using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Model
{
    public class Food : Product
    {
        public string description { get; set; }
        public bool isVegan { get; set; }
        public Food(int productId, string productName, int productPrice, string description, bool isVegan) : base(productId, productName, productPrice)
        {
            this.description = description;
            this.isVegan = isVegan;
        }
        public override string GetDescription()
        {
            return description;
        }
        public bool GetIsVegan()
        {
            return isVegan;
        }
        public override string EssentialInfo()
        {
            return "eat me";
        }
        public override string Info()
        {
            return $"----- {this.GetType().Name} Info -----\nName: {productName} \nPrice: {productPrice}\nDescription: {GetDescription()}\nVegan: {isVegan}";
        }
    }
}
