using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.Again_Prime
{
    class SET_Condition
    {
        public void Exception(int x)
        {
            int i = 10;
            int result = 0;
            try
            {
                result = i / x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Divided By Zero is not allowed");
            }
            finally
            {
                Console.WriteLine("Welcome To Finally Catch");
            }
        }
    }
}
