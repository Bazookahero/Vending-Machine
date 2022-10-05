using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Model
{
    public class Toy : Product
    {

        public Toy(int productId, string productName, int productPrice) : base(productId, productName, productPrice)
        {
        }
        public override string EssentialInfo()
        {
            return "play with me";
        }
    }
}
