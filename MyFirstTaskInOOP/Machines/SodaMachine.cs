namespace MyFirstTaskInOOP.Machines
{
    public class SodaMachine : AbstractVendingMachine
    {
        public Dictionary<string, int> SodaDrinks { get; private set; }

        List<String> sodaNames;

        public SodaMachine(int id, string name, List<String> sodaNames) : base(id, name)
        {
            SodaDrinks = new Dictionary<string, int>();

            foreach (string sodaName in sodaNames)
            {
                SodaDrinks.Add(sodaName, 0);
            }
        }

        public void Refresh(string name, int amount)
        {
            if (SodaDrinks.ContainsKey(name))
            {
                SodaDrinks[name] += amount;
            }
        }

        public override void GetDrink(string name)
        {
            if (SodaDrinks.ContainsKey(name) && SodaDrinks[name] > 0)
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
