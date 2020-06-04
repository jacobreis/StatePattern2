using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    class SoldState : IState
    {
        GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        // Implementation of IState interface
        public void dispenseProduct()
        {
            gumballMachine.releaseBall();
            if(gumballMachine.getCount() > 0)
            {
                gumballMachine.setState(gumballMachine.getNoQuarterState());
            }
            else
            {
                Console.WriteLine("We are out of gumballs");
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void insertQuarter()
        {
            Console.WriteLine("Please wait for the gumball to be dispensed");
        }

        public void turnCrank()
        {
            Console.WriteLine("Turning twice won't get you another gumball!");
        }
    }
}
