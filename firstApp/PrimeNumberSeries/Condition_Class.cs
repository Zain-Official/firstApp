using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.PrimeNumberSeries
{
    class Condition_Class
    {
        public void Prime(int x)
        {
            for(int i = 2; i<=x; i++)
            {
                int Divisor = 0;
                for(int j=1; j<=i; j++)
                {
                    if(i%j == 0)
                    {
                        Divisor++;
                    }
                }
                if(Divisor == 2)
                {
                    Console.WriteLine("{0} is Prime ",i);
                }
                else
                {
                    Console.WriteLine("{0} is Not Prime ", i);
                }

            }
        }
    }
}
