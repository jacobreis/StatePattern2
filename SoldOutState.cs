using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    class SoldOutState : IState
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        // Implementation of IState interface
        public void dispenseProduct()
        {
            Console.WriteLine("Sorry, we are out of gumballs");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Sorry, we are out of gumballs");
        }

        public void insertQuarter()
        {
            Console.WriteLine("Sorry, we are out of gumballs");
        }

        public void turnCrank()
        {
            Console.WriteLine("Sorry, we are out of gumballs");
        }
    }
}
