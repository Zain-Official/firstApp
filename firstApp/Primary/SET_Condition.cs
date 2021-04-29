using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.Primary
{
    class SET_Condition
    {
        public void PRIME(int x)
        {
           
            for (int i=1; i<=x; i++)
            {
                int Divisor = 0;
                for (int j=1; j<=i; j++)
                {
                    if(i%j == 0)
                    {
                        Divisor++;
                    }
                }
                if (Divisor == 2)
                {
                    Console.WriteLine("The Number is Prime " + i);
                }
                else
                {
                    Console.WriteLine("The NUmber is Not Prime " + i);
                }

            }
           
        }
    }
}
