using Vending_Machine.Data;
using Vending_Machine.Model;

namespace Vending_Machine
{
    internal class Program : VendingMachine
    {
        static void Main(string[] args)
        {
            VendingMachine v = new VendingMachine();
            v.StartUp();
        } 
    }
}