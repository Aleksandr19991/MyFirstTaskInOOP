using MyFirstTaskInOOP.Machines;

namespace MyFirstTaskInOOP
{
    public class VendingMachineService
    {
        public List<AbstractVendingMachine> VendingMachines { get; private set; }

        public VendingMachineService()
        {
            VendingMachines = new List<AbstractVendingMachine>();
        }

        public VendingMachineService(List<AbstractVendingMachine> vendingMachines)
        {
            VendingMachines = new List<AbstractVendingMachine>(vendingMachines);
        }

        public AbstractVendingMachine? GetAbstractVendingMachine(string name)
        {
            AbstractVendingMachine result = null;

            foreach (AbstractVendingMachine v in VendingMachines)
            {
                if (v.Name == name)
                {
                    result = v;
                    break;
                }
            }
            return result;
        }

        public void AddVendingMachine(AbstractVendingMachine v)
        {
            VendingMachines.Add(v);
        }

        public void RemoveVendingMachine(AbstractVendingMachine v)
        {
            VendingMachines.Remove(v);
        }
    }
}
