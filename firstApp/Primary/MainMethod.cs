using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.Primary
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number");
            int z = Convert.ToInt32(Console.ReadLine());

            int Divisor = 0;
            for (int i = 1; i <= z; i++)
            { 
              if(z%i == 0)
                {
                    Divisor++;
                }
            }
            if(Divisor == 2)
            {
                Console.WriteLine("Number is Prime" + z);
            }
            else
            {
                Console.WriteLine("Number is Not Prime " + z);
            }

            Console.WriteLine("");
            Console.WriteLine("********** Number Series ************");
            SET_Condition s = new SET_Condition();
            s.PRIME(z);
            

        }
    }
}
