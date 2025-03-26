
using MyFirstTaskInOOP.Machines;

namespace MyFirstTaskInOOPTests
{
    public class CoffeeMañhineTests
    {
        [TestCase("Êîôååê", 1000, 1000, 1000, 1000, 250, 150, 200, 1)]

        public void GetDrinkTest(string name, int water, int coffePowder, int milk, int cup, int expectedWater, int expectedCoffeePowder, int expectedMilk, int expectedCup)
        {
            CoffeeMañhine mañhine = new CoffeeMañhine(122, "Êîôååê")
            {
                Water = 250,
                CoffeePowder = 150,
                Milk = 200,
                Cup = 1,
            };

            mañhine.GetDrink(name);

            CoffeeMañhine expected = new CoffeeMañhine(122, "Êîôååê")
            {
                Water = expectedWater,
                CoffeePowder = expectedCoffeePowder,
                Milk = expectedMilk,
                Cup = expectedCup,
            };

            CoffeeMañhine actual = mañhine;

            Assert.DoesNotThrow(() => mañhine.GetDrink(name));
            Assert.AreEqual(expected.Water, actual.Water);
            Assert.AreEqual(expected.CoffeePowder, actual.CoffeePowder);
        }
    }
}