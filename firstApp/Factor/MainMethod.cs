using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.Factor
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            int num, fact = 1;
            Console.WriteLine("Enter Any Number");
            num = Convert.ToInt32(Console.ReadLine());
            
            for(int i=1; i<=num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);

            Console.WriteLine("***********************");
            Console.WriteLine("");
            SET_Condtion s = new SET_Condtion();
            s.Factorial(num);

        }
       
        
    }
}
