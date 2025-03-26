using MyFirstTaskInOOP.Modeles;
using System.Text.Json;

namespace MyFirstTaskInOOP.Storage
{
    public class CoffeeTeaStorage
    {
        private const string _filePathTea = "C:\\Users\\Александр\\Desktop\\failik.json";

        public List<RecipeCoffeeTeaDrinks> GetAllDrinksTea()
        {
            List<RecipeCoffeeTeaDrinks> result;

            using (StreamReader streamReader = new StreamReader(_filePathTea))
            {
                string json = streamReader.ReadToEnd();

                if (json != "")
                {
                    result = JsonSerializer.Deserialize<List<RecipeCoffeeTeaDrinks>>(json);
                }
                else
                {
                    result = new List<RecipeCoffeeTeaDrinks>();
                }
            }

            return result;
        }

        public void SaveDrinks(List<RecipeCoffeeTeaDrinks> drinks)
        {
            using (StreamWriter streamWriter = new StreamWriter(_filePathTea, false))
            {
                string json = JsonSerializer.Serialize<List<RecipeCoffeeTeaDrinks>>(drinks);
                streamWriter.Write(json);
            }
        }

        public void AddDrink(RecipeCoffeeTeaDrinks coffeeDrinks)
        {
            List<RecipeCoffeeTeaDrinks> drinks = GetAllDrinksTea();
            drinks.Add(coffeeDrinks);
            SaveDrinks(drinks);
        }

        public void RemoveDrink(RecipeCoffeeTeaDrinks coffeeDrinks)
        {
            List<RecipeCoffeeTeaDrinks> drinks = GetAllDrinksTea();
            drinks.Remove(coffeeDrinks);
            SaveDrinks(drinks);
        }
    }
}
