using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
  public  class electronics:product
    {

        public string Brandname { get; set; }

        public int warranty { get; set; }

        public override double discount()
        {
            return price * 50 / 100;

        }

    }
}
