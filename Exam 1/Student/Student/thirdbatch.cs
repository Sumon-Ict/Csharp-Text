using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
     public  class thirdbatch: firstbatch
    {
        public long session { get; set; }

        public override double discount()
        {
            return price * 70 / 100;

        }

    }
}
