using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTaskInOOP.Machines
{
    internal class SodaMachine: AbstractVendingMachine
    {
        public Dictionary<string, int> SodaDrinks { get; private set; }

        public SodaMachine(int id, List<String> sodaNames): base(id)
        {  

            SodaDrinks = new Dictionary<string, int>();

            foreach (string sodaName in sodaNames) 
            {
                SodaDrinks.Add(sodaName, 0);
            }
        }

        public override void Refresh(string name, int amount)
        {
            if (SodaDrinks.ContainsKey(name))
            {
                SodaDrinks[name] += amount;
            }
        }

        public override void GetDrink(string name)
        {
            if (SodaDrinks.ContainsKey(name) && SodaDrinks[name]>0) 
            {
                SodaDrinks[name]--;
                Console.WriteLine($"{Id}: Получите Ваш {name}!");
            }
            else 
            {
                Console.WriteLine($"Такого напитка нет!");
            }
        }
    }
}
