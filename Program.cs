// Written by Jake Reis

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new gumball machine with a reference to all the states
            GumballMachine gumballMachine = new GumballMachine("Seattle", 4);

            // A couple methods to show the machine in action
            gumballMachine.insertQuarter();
            gumballMachine.ejectQuarter();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            // A new monitor created to display the gumball machine's information
            GumballMonitor monitor = new GumballMonitor(gumballMachine);
            monitor.Report();

            Console.Read();

            /* 
             * Possible Further Improvements: Add getCount() method to NoQuarterState to prevent a quarter from being
             * inserted when there are no balls left
             */

        }
    }
}
