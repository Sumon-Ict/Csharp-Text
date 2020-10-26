using System;
using System.Collections.Generic;
using System.Text;

namespace ModelTest
{
   public  class Test2:Test1
    {
        public string bookname { get; set; }

        public override double discount()
        {
            return pricevalue* 30 / 100;
        }


    }
}
