using System;
using System.Collections.Generic;
using System.Text;

namespace Bitwise_Operator
{
    public class batch2 : batch1

    {
        private int ag;

        public int age
        {
            get { return ag; }
            set
            {
                if (value < 0)
                    ag = 0;
         
                ag = value;
            }

        }

        public override double discount()
        {
            //Console.WriteLine("the discount is {0}", price * 25 / 100);
            return price * 25 / 100;

        }





    }
}
