using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConStateMachineTest.Action;

namespace ConStateMachineTest.Machine
{
    class StateMachineTest1: DGX.Action.StateMachine
    {
        public StateMachineTest1()
            :base()
        {
            BonjourAction bonjourAction = new BonjourAction(0);
            DirectionChoiceAction choices = new DirectionChoiceAction(1);
            LeftAction la = new LeftAction(2);
            RightAction ra = new RightAction(3);

            //trigger
            bonjourAction.DEFAULT_NEXT_ACTION = choices;
            choices.addTrigger((int)DirectionChoiceAction.DIRECTION.left, la);
            choices.addTrigger((int)DirectionChoiceAction.DIRECTION.right, ra);
            
            //action.addTrigger
            addAction(bonjourAction);
            addAction(choices);
            addAction(la);
            addAction(ra);
            startNewAction(bonjourAction.ID, false);
        }
    }
}
