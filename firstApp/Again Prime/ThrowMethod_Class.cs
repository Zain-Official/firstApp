using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp.Again_Prime
{
    class ThrowMethod_Class
    {
        public void MaxAge(int y)
        {
            
            if(y <= 18)
            {
                throw new Throw_Exception("Age is not Valid ......");
            }
           
        }
    }
}
