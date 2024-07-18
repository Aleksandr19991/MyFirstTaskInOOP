
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstTaskInOOP.Machines;
using MyFirstTaskInOOP.Modeles;

namespace MyFirstTaskInOOP.Machines
{
    internal class CoffeeTeaMachine
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        public double Water { get; set; }

        public double CoffeePowder { get; set; }

        public double Milk { get; set; }

        public int Tea { get; set; }

        public int Cup { get; set; }

        public Dictionary<string, RecipeCoffeeTeaDrinks> sampleCoffeeTea { get; set; }

        public CoffeeTeaMachine(int id)
        {
            Water = 0;
            CoffeePowder = 0;
            Milk = 0;
            Tea = 0;
            Cup = 0;
            Id = id;

            sampleCoffeeTea = new Dictionary<string, RecipeCoffeeTeaDrinks>()
            {
               {
                    "Latte",
                    new RecipeCoffeeTeaDrinks ()
                    {
                        Water = 100,
                        CoffeePowder = 150,
                        Milk = 200,
                        Cup = 1,
                    }
               },
               {
                    "Cappuchino",
                    new RecipeCoffeeTeaDrinks()
                    {
                        Water = 150,
                        CoffeePowder = 150,
                        Milk = 150,
                        Cup = 1,
                    }
               },
               {
                    "Americano",
                    new RecipeCoffeeTeaDrinks()
                    {
                        Water = 400,
                        CoffeePowder = 150,
                        Cup = 1,
                    }
               },
               {
                    "Tea",
                    new RecipeCoffeeTeaDrinks()
                    {
                        Water = 400,
                        Tea = 1,
                        Cup = 1,
                    }
               },
            };
        }

        public void GetDrink(string name)
        {
            if (sampleCoffeeTea.ContainsKey(name))
            {
                RecipeCoffeeTeaDrinks Drink = sampleCoffeeTea[name];

                if (Water >= Drink.Water
                    && CoffeePowder >= Drink.CoffeePowder
                    && Milk >= Drink.Milk
                    && Tea >= Drink.Tea
                    && Cup >= Drink.Cup)
                {
                    Water -= Drink.Water;
                    CoffeePowder -= Drink.CoffeePowder;
                    Milk -= Drink.Milk;
                    Tea -= Drink.Tea;
                    Cup -= Drink.Cup;

                    Console.WriteLine($"Получите Ваш {Drink}");
                }
                else
                {
                    Console.WriteLine("Не хватает игредиентов для создания напитка");
                }
            }
            else
            {
                Console.WriteLine("Такого напитка нет!");
            }
        }

        public void Reloading()
        {
            Water = 4000;
            CoffeePowder = 1000;
            Milk = 1500;
            Tea = 800;
            Cup = 1000;
        }
    }
}

