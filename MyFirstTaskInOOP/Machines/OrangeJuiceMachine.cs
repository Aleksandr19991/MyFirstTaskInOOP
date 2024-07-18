using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTaskInOOP.Machines
{
    internal class OrangeJuiceMachine
    {
        public int Id { get; private set; }

        public int OrangeAmount { get; private set; }

        public int LastRefresh { get; private set; }

        public OrangeJuiceMachine (int id)
        {
            Id=id;
            OrangeAmount = 0;
            LastRefresh = DateTime.Now.DayOfYear;
        }

        public void Refresh(int orangeAmount)
        {
            OrangeAmount = orangeAmount;
            LastRefresh = DateTime.Now.DayOfYear;
        }

        public void GetDrink()
        {
            if (OrangeAmount >= 3) 
            {
                OrangeAmount -= 3;
                Console.WriteLine("Возьмите Ваш сок!");
            }
            else 
            {
                Console.WriteLine($"{Id}: Напиток недоступен");
            }
        }
    }
}
