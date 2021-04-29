using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace firstApp.LISTS
{
    class STACKS
    {
        public void StacK()
        {
            Stack<int> i = new Stack<int>();
            i.Push(1);
            i.Push(2);
            i.Push(3);
            foreach(var j in i)
            {
                Console.WriteLine(j);
            }

            i.Pop();
            Console.WriteLine("***************After Pop*******************");
            foreach (var j in i)
            {
                Console.WriteLine(j);
            }
        }
        
        
        
        
    }
}
