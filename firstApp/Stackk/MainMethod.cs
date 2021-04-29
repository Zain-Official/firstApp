using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.Stackk
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("*******************Reference Type****************");

            SET_Condition s = new SET_Condition();
            s.Package = 25000;
            s.Life = 35;

            SET_Condition s1 = s;
            SET_Condition s2 = s;
            s.Life = 25;
            Console.WriteLine(s1.Package);
            Console.WriteLine(s2.Life);          
            Console.WriteLine(s.Life);

            Console.WriteLine("");
            Console.WriteLine("*******************Value Type****************");
            Employee e = new Employee();
            e.Income = 200;
            e.Old = 12;

            Employee e1 = e;
            Employee e2 = e;

            e.Income = 5000;
            Console.WriteLine(e.Income);
            Console.WriteLine(e1.Old);
            Console.WriteLine(e2.Income);

            Console.ReadKey();

        }
    }
}
