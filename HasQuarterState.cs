using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    class HasQuarterState : IState
    {
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        // Implementation of IState interface
        public void dispenseProduct()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You ejected a quarter");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned...");
            gumballMachine.setState(gumballMachine.getSoldState());
        }
    }
}
