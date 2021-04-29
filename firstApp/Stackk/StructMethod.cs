using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.Stackk
{

    struct Employee
    {
        private int Salary;
        private int Age;

        public int Income
        {
            get { return Salary; }
            set { Salary = value; }
        }

        public int Old
        {
            get { return Age; }
            set { Age = value; }
        }

    }
}
