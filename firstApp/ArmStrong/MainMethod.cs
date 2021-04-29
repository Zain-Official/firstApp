using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.ArmStrong
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number");
            int num, temp, sum = 0, rem;
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num = num / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine("Number is ArmStrong:- "+temp);
            }
            else
            {
                Console.WriteLine("Number is Not ArmStrong:- "+temp);
            }
        }
    }
}
