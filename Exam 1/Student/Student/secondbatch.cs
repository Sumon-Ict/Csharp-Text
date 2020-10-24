using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    public class secondbatch:firstbatch
    {

        public int roll { get; set; }
        public override double discount()
        {
            return price * 50 / 100;

        }


    }
}
