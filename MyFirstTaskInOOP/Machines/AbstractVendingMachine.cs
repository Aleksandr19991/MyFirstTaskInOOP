namespace MyFirstTaskInOOP.Machines
{
    public abstract class AbstractVendingMachine
    {
        public string Name { get; set; }

        protected int Id { get; private set; }

        public AbstractVendingMachine(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void GetDrink(string name);
    }
}
