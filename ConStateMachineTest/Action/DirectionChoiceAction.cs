using System;
using System.Collections.Generic;
using System.Text;
using DGX.Action;
using ConStateMachineTest.Machine;

namespace ConStateMachineTest.Action
{
    public class DirectionChoiceAction: ActionBase
    {
        public DirectionChoiceAction(int id)
            : base(id, true)
        {

        }

        protected override void handleInit()
        {
            base.handleInit();
        }

        protected override void handleRun()
        {
            base.handleRun();
            Console.WriteLine("left or right?");
            string s = Console.ReadLine();
            if (s == "right")
            {
                setTrigger((int)StateMachineTest1.ACTION.right);
            }
            else if (s == "left")
            {
                setTrigger((int)StateMachineTest1.ACTION.left);
            }
            else
            {
                Console.WriteLine("Mauvaise entré");
            }
        }

        protected override void handleEnding()
        {
            base.handleEnding();
        }
    }
}
