
using MyFirstTaskInOOP.Machines;

namespace MyFirstTaskInOOPTests
{
    public class CoffeeMa�hineTests
    {
        [TestCase("������", 1000, 1000, 1000, 1000, 250, 150, 200, 1)]

        public void GetDrinkTest(string name, int water, int coffePowder, int milk, int cup, int expectedWater, int expectedCoffeePowder, int expectedMilk, int expectedCup)
        {
            CoffeeMa�hine ma�hine = new CoffeeMa�hine(122, "������")
            {
                Water = 250,
                CoffeePowder = 150,
                Milk = 200,
                Cup = 1,
            };

            ma�hine.GetDrink(name);

            CoffeeMa�hine expected = new CoffeeMa�hine(122, "������")
            {
                Water = expectedWater,
                CoffeePowder = expectedCoffeePowder,
                Milk = expectedMilk,
                Cup = expectedCup,
            };

            CoffeeMa�hine actual = ma�hine;

            Assert.DoesNotThrow(() => ma�hine.GetDrink(name));
            Assert.AreEqual(expected.Water, actual.Water);
            Assert.AreEqual(expected.CoffeePowder, actual.CoffeePowder);
        }
    }
}