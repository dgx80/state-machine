using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConStateMachineTest.Action;

namespace ConStateMachineTest.Machine
{
    public class StateMachineTest1: DGX.Action.StateMachine
    {
        public enum ACTION
        {
            bonjour,
            choices,
            left,
            right
        }
        public StateMachineTest1()
            :base()
        {
            BonjourAction bonjourAction = new BonjourAction((int)ACTION.bonjour);
            DirectionChoiceAction choices = new DirectionChoiceAction((int)ACTION.choices);
            LeftAction la = new LeftAction((int)ACTION.left);
            RightAction ra = new RightAction((int)ACTION.right);

            //trigger
            bonjourAction.DEFAULT_NEXT_ACTION = choices;
            addTrigger(choices, ra);
            addTrigger(choices, la);

            //action.addTrigger
            addAction(bonjourAction);
            addAction(choices);
            addAction(la);
            addAction(ra);
            startNewAction(bonjourAction.ID, false);
        }
    }
}
