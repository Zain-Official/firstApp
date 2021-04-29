using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.Factor
{
    class SET_Condtion
    {
        public void Factorial(int n)
        {
            int fact = 1;
            for(int i=1; i<=n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The Factorial of "+n+" = "+fact);
        }
    }
}
