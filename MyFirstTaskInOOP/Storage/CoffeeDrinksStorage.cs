using MyFirstTaskInOOP.Modeles;
using System.Text.Json;

namespace MyFirstTaskInOOP.Storage
{
    public class CoffeeDrinksStorage
    {
        private const string _filePath = "C:\\Users\\Александр\\Desktop\\failik.json";

        public List<RecipeCoffeeDrinks> GetAllDrinks()
        {
            List<RecipeCoffeeDrinks> result;

            using (StreamReader streamReader = new StreamReader(_filePath))
            {
                string json = streamReader.ReadToEnd();

                if (json != "")
                {
                    result = JsonSerializer.Deserialize<List<RecipeCoffeeDrinks>>(json);
                }
                else
                {
                    result = new List<RecipeCoffeeDrinks>();
                }
            }

            return result;
        }

        public void SaveDrinks(List<RecipeCoffeeDrinks> drinks)
        {
            using (StreamWriter streamWriter = new StreamWriter(_filePath, false))
            {
                string json = JsonSerializer.Serialize<List<RecipeCoffeeDrinks>>(drinks);
                streamWriter.Write(json);
            }
        }

        public void AddDrink(RecipeCoffeeDrinks coffeeDrinks)
        {
            List<RecipeCoffeeDrinks> drinks = GetAllDrinks();
            drinks.Add(coffeeDrinks);
            SaveDrinks(drinks);
        }

        public void RemoveDrink(RecipeCoffeeDrinks coffeeDrinks)
        {
            List<RecipeCoffeeDrinks> drinks = GetAllDrinks();
            drinks.Remove(coffeeDrinks);
            SaveDrinks(drinks);
        }
    }
}
