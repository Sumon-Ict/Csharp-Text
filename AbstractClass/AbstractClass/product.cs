using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
   public  class product
    {

        public string productname { get; set; }
        public  double price { get; set; }

        public virtual double discount()
        {
            return price * 10 / 100.0;

        }



    }
}
