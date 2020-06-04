using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    class GumballMonitor
    {
        GumballMachine machine;

        public GumballMonitor(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void Report()
        {
            Console.WriteLine("Gumball Machine: " + machine.getLocation());
            Console.WriteLine("Current inventory: " + machine.getCount() + " gumballs");
            Console.WriteLine("Current state " + machine.getState());
        }
    }
}
