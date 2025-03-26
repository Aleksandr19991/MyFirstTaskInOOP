namespace MyFirstTaskInOOP.Machines
{
    public class OrangeJuiceMachine : AbstractVendingMachine
    {
        public int OrangeAmount { get; private set; }

        public int LastRefresh { get; private set; }

        public string _name = "Апельсиновый сок";

        public OrangeJuiceMachine(int id, string name) : base(id, name)
        {
            OrangeAmount = 0;
            LastRefresh = DateTime.Now.DayOfYear;
        }

        public void Refresh(int orangeAmount)
        {
            OrangeAmount = orangeAmount;
            LastRefresh = DateTime.Now.DayOfYear;
        }

        public override void GetDrink(string name)
        {
            if (OrangeAmount >= 3)
            {
                OrangeAmount -= 3;
                Console.WriteLine($"Возьмите Ваш {_name}!");
            }
            else
            {
                Console.WriteLine($"{Id}: Напиток недоступен");
            }
        }
    }
}
