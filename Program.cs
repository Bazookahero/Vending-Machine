using Vending_Machine.Data;
using Vending_Machine.Model;

namespace Vending_Machine
{
    internal class Program : VendingMachine
    {
        static void Main(string[] args)
        {
            bool reset = false;
            VendingMachine v = new VendingMachine();
            VendingMachineServices b = new VendingMachineServices();
            Drink soda = new Drink(0, "soda", 20);
            Drink water = new Drink(1, "water", 30);
            Drink milk = new Drink(2, "milk", 45);
            Toy barbie = new Toy(3, "barbie", 70);
            Toy bear = new Toy(4, "bear", 55);
            Toy pokémon = new Toy(5, "pokémon", 100);
            Food apple = new Food(6, "apple", 15);
            Food sandwich = new Food(7, "sandwich", 35);
            Food energyBar = new Food(8, "energy bar", 22);
            Product[] prods = new Product[] { soda, water, milk, barbie, bear, pokémon, apple, sandwich, energyBar };
            
            try
            {
                while (reset == false)
                {
                    Console.Clear();
                    b.ShowMenu();
                    int userInput = int.Parse(Console.ReadLine());
                    int remainingSum;
                    switch (userInput)
                    {

                        case 1:
                            while (userInput != -1)
                            {
                                Console.Clear();
                                Console.WriteLine("insert money, type -1 to exit, inserted money: {0}", v.Money.Sum());
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput != -1 && v.MoneyDenom.Contains(userInput))
                                {
                                    v.InsertMoney(userInput);
                                }
                                else if (userInput != -1)
                                { Console.WriteLine("please insert a valid denomination"); }

                                Console.ReadKey();
                                
                            }
                            break;
                        case 2:
                            int inputVal;
                            remainingSum = v.Money.Sum();
                            do
                            {
                                Console.Clear();
                                foreach (Product p in prods)
                                    if(p != null)
                                {
                                        
                                        Console.WriteLine($"----- Info -----\nID:{p.productId}\nName: {p.productName} \nPrice: {p.productPrice}"); 
                                        
                                }
                                Console.WriteLine("\nChoose product by ID, you have {0} cash left. Type -1 to cash out", remainingSum);
                                inputVal = int.Parse(Console.ReadLine());
                                foreach (Product p in prods)
                                {
                                    if (inputVal == p.productId && v.Money.Sum() >= p.productPrice)
                                    {
                                        Console.WriteLine("here you go");
                                        Console.WriteLine(p.EssentialInfo());
                                        Console.ReadLine();
                                        remainingSum = remainingSum - p.productPrice;
                                        break;
                                    }
                                    else if (remainingSum < p.productPrice && inputVal != -1)
                                    {
                                        Console.WriteLine("not enough money");
                                        Console.ReadLine();
                                        break;
                                    }                                  
                                }

                            } while (inputVal != -1);
                            v.ReturnMoney(remainingSum);
                            Console.ReadKey();
                            break;
                        case 3:
                            
                            Console.ReadKey();
                            Environment.Exit(-1);
                            break;
                    }
                }   
            } 
            catch {
                Exception e = new Exception();
                Console.WriteLine(e.Message); }
        } 
    }
}