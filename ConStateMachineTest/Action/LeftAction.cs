using System;
using System.Collections.Generic;
using System.Text;
using DGX.Action;

namespace ConStateMachineTest.Action
{
    public class LeftAction: ActionBase
    {
        public LeftAction(int id)
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
            Console.WriteLine("Vous avez tournez a gauche");
        }

        protected override void handleEnding()
        {
            base.handleEnding();
        }
    }
}
