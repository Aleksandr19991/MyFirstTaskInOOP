using MyFirstTaskInOOP.Machines;
using MyFirstTaskInOOP.Storage;
using MyFirstTaskInOOP.Modeles;

namespace MyFirstTaskInOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeDrinksStorage coffeeDrinksStorage = new CoffeeDrinksStorage();
            coffeeDrinksStorage.AddDrink(new RecipeCoffeeDrinks()
            {
                Name = "ecspresso",
                CoffeePowder = 150,
                Water = 100,
                Milk = 10,
                Cup = 1,
            });

            VendingMachineService machine = new VendingMachineService();
        }
    }
}
