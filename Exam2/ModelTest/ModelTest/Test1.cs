using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ModelTest
{
  public  class Test1
    {

        public string productname { get; set; }

        private double price;

        public double pricevalue
        {

            get{ return price; }

            set
            {
                if (value < 0)
                    price = 0;
                price=value;
            }
        }

        public virtual double discount()
        {
            return price*20/100;

        }




    }
}
