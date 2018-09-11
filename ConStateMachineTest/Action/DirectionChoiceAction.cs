using System;
using System.Collections.Generic;
using System.Text;
using DGX.Action;

namespace ConStateMachineTest.Action
{
    public class DirectionChoiceAction: ActionBase
    {
        public enum DIRECTION
        {
            right,
            left
        };

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
                setTrigger((int)DIRECTION.right);
            }
            else if (s == "left")
            {
                setTrigger((int)DIRECTION.left);
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
