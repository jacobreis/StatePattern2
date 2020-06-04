using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    class NoQuarterState : IState
    {
        GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        // Implementation of IState interface
        public void dispenseProduct()
        {
            Console.WriteLine("Please insert a quarter");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Please insert a quarter");
        }

        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter...");
            gumballMachine.setState(gumballMachine.getHasQuarterState());

        }

        public void turnCrank()
        {
            Console.WriteLine("Please insert a quarter");
        }
    }
}
