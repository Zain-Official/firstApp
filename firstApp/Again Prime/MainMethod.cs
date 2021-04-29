using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.Again_Prime
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            int Divisor = 0;
            for(int i=1; i<=num; i++)
            {
                if(num%i == 0)
                {
                    Divisor++;
                }
            }
            if(Divisor == 2)
            {
                Console.WriteLine("Number is Prime " +num);
            }
            else
            {
                Console.WriteLine("Number is not prime " +num);
            }

            Console.WriteLine("");
            SET_Condition s = new SET_Condition();
            s.Exception(num);

            ThrowMethod_Class t = new ThrowMethod_Class();
            try
            {
                t.MaxAge(num);
            }catch(Throw_Exception e)
            {
                Console.WriteLine(e);
            }
           


        }
    }
}
