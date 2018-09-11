using System;
using System.Collections.Generic;
using System.Text;
using DGX.Action;

namespace ConStateMachineTest.Action
{
    public class BonjourAction: ActionBase
    {
        public BonjourAction(int id)
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
            Console.WriteLine("Bonjour!");
        }

        protected override void handleEnding()
        {
            base.handleEnding();
        }
    }
}
