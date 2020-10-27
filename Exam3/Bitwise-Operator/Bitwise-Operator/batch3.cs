using System;
using System.Collections.Generic;
using System.Text;

namespace Bitwise_Operator
{
    public class batch3:batch1
    {

        public int roll;

        public override double discount()
        {
            return price * 50 / 100;
           // Console.WriteLine("the discount is {0}", price * 50 / 100);

        }

    }
}
