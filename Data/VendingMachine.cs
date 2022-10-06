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
    }
}
