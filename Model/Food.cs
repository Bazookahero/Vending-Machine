using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Model
{
    public class Food : Product
    {

        public Food(int productId, string productName, int productPrice) : base(productId, productName, productPrice)
        {
        }
        public override string EssentialInfo()
        {
            return "eat me";
        }
    }
}
