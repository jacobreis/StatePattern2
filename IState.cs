using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern2
{
    interface IState
    {
        void insertQuarter();
        void ejectQuarter();
        void turnCrank();
        void dispenseProduct();

    }
}
