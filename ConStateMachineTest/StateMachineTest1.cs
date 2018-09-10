using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGX.Action;

namespace ConStateMachineTest
{
    class StateMachineTest1: DGX.Action.StateMachine
    {
        public StateMachineTest1()
            :base()
        {
            ActionBase action = new DGX.Action.ActionBase(0, true);
            //action.addTrigger
            addAction(action);
        }
    }
}
