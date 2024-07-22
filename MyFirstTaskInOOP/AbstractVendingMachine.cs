using MyFirstTaskInOOP.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTaskInOOP
{
    public abstract class AbstractVendingMachine
    {
        protected int Id { get; private set; }

        public AbstractVendingMachine(int id) 
        {
            Id = id;    
        }

        public abstract void GetDrink(string name);

        public virtual void Reloading() {}

        public virtual void Refresh(string name, int amount) {}

        public virtual void Refresh(int orangeAmount) {}

    }




    
}
