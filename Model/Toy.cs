using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Model
{
    public class Toy : Product
    {
        public string description { get; set; }
        public Toy(int productId, string productName, int productPrice, string description) : base(productId, productName, productPrice)
        {
            this.description = description;
        }
        public override string GetDescription()
        {
            return description;
        }
        public override string EssentialInfo()
        {
            return "play with me";
        }
    }
}
