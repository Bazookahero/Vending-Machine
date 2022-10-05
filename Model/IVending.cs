using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.Model
{
    interface IVending
    {
        //void ShowMenu();
        //string EssentialInfo();
        void ReturnMoney(int money);
        int[] InsertMoney(int mon);
    }
}
