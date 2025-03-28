﻿using MyFirstTaskInOOP.Modeles;


namespace MyFirstTaskInOOP.Machines
{
    public class CoffeeMaсhine : AbstractVendingMachine
    {
        public double Water { get; set; }

        public double CoffeePowder { get; set; }

        public double Milk { get; set; }

        public int Cup { get; set; }

        public Dictionary<string, RecipeCoffeeDrinks> sampleCoffee { get; set; }

        public CoffeeMaсhine(int id, string name) : base(id, name)
        {
            Water = 0;
            CoffeePowder = 0;
            Milk = 0;
            Cup = 0;

            sampleCoffee = new Dictionary<string, RecipeCoffeeDrinks>()
            {
               {
                    "Latte",
                    new RecipeCoffeeDrinks ()
                    {
                        Water = 100,
                        CoffeePowder = 150,
                        Milk = 200,
                        Cup = 1,
                    }
               },
               {
                    "Cappuchino",
                    new RecipeCoffeeDrinks()
                    {
                        Water = 150,
                        CoffeePowder = 150,
                        Milk = 150,
                        Cup = 1,
                    }
               },
               {
                    "Americano",
                    new RecipeCoffeeDrinks()
                    {
                        Water = 400,
                        CoffeePowder = 150,
                        Cup = 1,
                    }
               },
            };
        }

        public override void GetDrink(string name)
        {
            if (sampleCoffee.ContainsKey(name))
            {
                RecipeCoffeeDrinks Drink = sampleCoffee[name];

                if (Water >= Drink.Water
                    && CoffeePowder >= Drink.CoffeePowder
                    && Milk >= Drink.Milk
                    && Cup >= Drink.Cup)
                {
                    Water -= Drink.Water;
                    CoffeePowder -= Drink.CoffeePowder;
                    Milk -= Drink.Milk;
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
            Cup = 1000;
        }
    }
}
