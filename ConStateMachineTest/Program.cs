using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConStateMachineTest
{
    class Program
    {
        static void Main(string[] args)
        {   
            test1();
        }

        static void test1()
        {
            Machine.StateMachineTest1 m = new Machine.StateMachineTest1();
            
            while (true)
            {
                m.handleUpdate();
            }
        }
    }
}
