using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class VendingMachine : IVending
    {
        readonly int[] moneyDenom = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
        public int[] MoneyDenom { get { return moneyDenom; } }
        public int insertCounter = 0;
        private int[] money = new int[0];
        public int[] Money { get { return money; } }

        public int[] InsertMoney(int mon)
        {
            if (moneyDenom.Contains(mon))
            {
                Array.Resize(ref money, money.Length + 1);
                money[insertCounter] = mon;
                insertCounter++;
            }
            return money;
        }

        public void ReturnMoney(int money)
        {
            int payChange = money;
            int payAntal;
            int payMod;
            while (payChange > 0)
                if (payChange >= 1000)
                {
                    payAntal = payChange / MoneyDenom[0];
                    Console.WriteLine("tusenlappar: " + payAntal);
                    payChange = payChange - (payAntal * MoneyDenom[0]);
                }
                else if (payChange >= 500)
                {
                    payAntal = payChange / MoneyDenom[1];
                    Console.WriteLine("femhundralappar: " + payChange / MoneyDenom[1]);
                    payMod = payChange % MoneyDenom[1];
                    payChange = payChange - (payAntal * MoneyDenom[1]);
                }
                else if (payChange >= 100)
                {
                    payAntal = payChange / MoneyDenom[2];
                    Console.WriteLine("hundralappar: " + payChange / MoneyDenom[2]);
                    payChange = payChange - (payAntal * MoneyDenom[2]);
                }
                else if (payChange >= 50)
                {
                    payAntal = payChange / MoneyDenom[3];
                    Console.WriteLine("femtiolappar: " + payChange / MoneyDenom[3]);
                    payChange = payChange - (payAntal * MoneyDenom[3]);
                }
                else if (payChange >= 20)
                {
                    payAntal = payChange / MoneyDenom[4];
                    Console.WriteLine("tjugolappar: " + payChange / MoneyDenom[4]);
                    payChange = payChange - (payAntal * MoneyDenom[4]);
                }
                else if (payChange >= 10)
                {
                    payAntal = payChange / MoneyDenom[5];
                    Console.WriteLine("tior: " + payChange / MoneyDenom[5]);
                    payChange = payChange - (payAntal * MoneyDenom[5]);
                }
                else if (payChange >= 5)
                {
                    payAntal = payChange / MoneyDenom[6];
                    Console.WriteLine("Femkronor: " + payChange / MoneyDenom[6]);
                    payChange = payChange - (payAntal * MoneyDenom[6]);
                }
                else if (payChange >= 1)
                {
                    payAntal = payChange / MoneyDenom[7];
                    Console.WriteLine("enkronor: " + payChange / MoneyDenom[7]);
                    payChange = payChange - (payAntal * MoneyDenom[7]);
                }
        }
        public void StartUp()
        {
            bool reset = false;
            VendingMachine v = new VendingMachine();
            VendingMachineServices b = new VendingMachineServices();
            Drink soda = new Drink(0, "soda", 20, "sugarfree soda", true);
            Drink water = new Drink(1, "water", 30, "ordinary water", false);
            Drink milk = new Drink(2, "milk", 45, "fresh milk", false);
            Toy barbie = new Toy(3, "barbie", 70, "barbie doll", 3);
            Toy bear = new Toy(4, "bear", 55, "stuffed bear", 0);
            Toy pokémon = new Toy(5, "pokémon", 100, "mewtwo", 10);
            Food apple = new Food(6, "apple", 15, "red apple", true);
            Food sandwich = new Food(7, "sandwich", 35, "ham and cheese", false);
            Food energyBar = new Food(8, "energy bar", 22, "chocolate taste", false);
            Product[] prods = new Product[] { soda, water, milk, barbie, bear, pokémon, apple, sandwich, energyBar };
            try
            {
                while (reset == false)
                {
                    Console.Clear();
                    b.ShowMenu();
                    int userInput = int.Parse(Console.ReadLine());
                    int remainingSum = 0;
                    switch (userInput)
                    {
                        case 1:
                            while (userInput != -1)
                            {
                                Console.Clear();
                                Console.WriteLine("insert money, type -1 to exit");
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
                                    if (p != null)
                                    {
                                        Console.WriteLine($"----- Info -----\nID:{p.productId}\nName: {p.productName} \nPrice: {p.productPrice}");
                                    }
                                Console.WriteLine("\nChoose product by ID, you have {0} cash left. Type -1 to cash out", remainingSum);
                                inputVal = int.Parse(Console.ReadLine());
                                foreach (Product p in prods)
                                {
                                    if (inputVal == p.productId && remainingSum >= p.productPrice)
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
                            Console.WriteLine("pengar tillbaka:");
                            v.ReturnMoney(remainingSum);
                            remainingSum = 0;
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            foreach (Product p in prods)
                                Console.WriteLine(p.Info());
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("exiting");
                            Console.ReadKey();
                            Environment.Exit(-1);
                            break;
                    }
                }
            }
            catch
            {
                Exception e = new Exception();
                Console.WriteLine(e.Message);
            }
        }
    }
}
