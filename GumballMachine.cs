using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    class GumballMachine
    {
        // Possible machine states
        IState soldOutState;
        IState noQuarterState;
        IState hasQuarterState;
        IState soldState;

        // Class variables
        IState state;
        int count = 0;
        string location;

        public GumballMachine(String location, int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);

            this.count = numberGumballs;
            this.location = location;

            if (numberGumballs > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }

        // Actions performed on Gumball Machine
        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispenseProduct();
        }

        // Methods start here
        public void setState(IState state)
        {
            this.state = state;
        }

        public IState getState()
        {
            return this.state;
        }

        public string getLocation()
        {
            return this.location;
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count != 0)
            {
                count = count - 1;
            }
        }

        // Getter methods
        public IState getSoldOutState() { return soldOutState; }
        public IState getNoQuarterState() { return noQuarterState; }
        public IState getHasQuarterState() { return hasQuarterState; }
        public IState getSoldState() { return soldState; }
        public int getCount() { return count; }


    }
}
