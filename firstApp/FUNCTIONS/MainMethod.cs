using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.FUNCTIONS
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            SET_Condition s = new SET_Condition();
            s.M1();
            Parameters p = new Parameters();
            int result = p.Sum(7, 10);

            Console.WriteLine(result);
        }
    }
}
