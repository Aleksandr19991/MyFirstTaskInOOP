using System.Text.Json;

namespace MyFirstTaskInOOP.Storage
{
    public class SodaStorage
    {
        private const string _filePathSoda = "C:\\Users\\Александр\\Desktop\\failik.json";

        public List<string> GetAllDrinksSoda()
        {
            List<string> result;

            using (StreamReader streamReader = new StreamReader(_filePathSoda))
            {
                string json = streamReader.ReadToEnd();

                if (json != "")
                {
                    result = JsonSerializer.Deserialize<List<string>>(json);
                }
                else
                {
                    result = new List<string>();
                }
            }

            return result;
        }

        public void SaveDrinks(List<string> drinks)
        {
            using (StreamWriter streamWriter = new StreamWriter(_filePathSoda, false))
            {
                string json = JsonSerializer.Serialize<List<string>>(drinks);
                streamWriter.Write(json);
            }
        }

        public void AddDrink(string coffeeDrinks)
        {
            List<string> drinks = GetAllDrinksSoda();
            drinks.Add(coffeeDrinks);
            SaveDrinks(drinks);
        }

        public void RemoveDrink(string coffeeDrinks)
        {
            List<string> drinks = GetAllDrinksSoda();
            drinks.Remove(coffeeDrinks);
            SaveDrinks(drinks);
        }
    }
}
