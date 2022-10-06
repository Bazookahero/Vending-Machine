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
        public int recommendedAge { get; set; }
        public Toy(int productId, string productName, int productPrice, string description, int recommendedAge) : base(productId, productName, productPrice)
        {
            this.description = description;
            this.recommendedAge = recommendedAge;
        }
        public override string GetDescription()
        {
            return description;
        }
        public int GetRecommendedAge()
        {
            return recommendedAge;
        }
        public override string EssentialInfo()
        {
            return "play with me";
        }
        public override string Info()
        {
            return $"----- {this.GetType().Name} Info -----\nName: {productName} \nPrice: {productPrice}\nDescription: {GetDescription()}\nRecommended Age: {recommendedAge}";
        }
    }
}
