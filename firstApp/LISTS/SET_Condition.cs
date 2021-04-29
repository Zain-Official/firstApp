using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.LISTS
{
    class SET_Condition
    {
        public void LisTs()
        {
            var student = new List<string>();
            student.Add("Zain");
            student.Add("hasi");
            student.Add("Attullah");
            student.Add("Mashori");
            student.Add("Pakistan");

            foreach(var sname in student)
            {
                Console.WriteLine(sname);
            }

            Console.WriteLine("");
            Console.WriteLine("*******************");
            

        }
    }
}
