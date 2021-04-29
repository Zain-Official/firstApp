using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.LISTS
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            SET_Condition s = new SET_Condition();
            s.LisTs();

            Console.WriteLine("");
            Console.WriteLine("*****************STACK *****************");
            STACKS sk = new STACKS();
            sk.StacK();

            Console.WriteLine("");
            Console.WriteLine("***************** Queue *****************");
            QUEUES q = new QUEUES();
            q.Queue();

            Console.ReadKey();
        }
    }
}
