using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
  public   class Book:product
    {
        public string bookagent { get; set; }

        public string author { get; set; }


        public override double discount()
        {
            return price * 25 / 100;

        }


    }
}
