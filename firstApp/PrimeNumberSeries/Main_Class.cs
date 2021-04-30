using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.PrimeNumberSeries
{
    class Main_Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number");
            int g = Convert.ToInt32(Console.ReadLine());
            Condition_Class c = new Condition_Class();
            c.Prime(g);
        }
    }
}
