using System;
using System.Collections.Generic;
using System.Text;

namespace Bitwise_Operator
{
    public class batch1
    {

        public string name { get; set; }

        public double weight { get; set; }

        public double price { get; set; }


        public string formte()
        {

            return $"the price  taka {price.ToString("0.00")}";

        }


        public virtual double discount()
        {
            return price * 15 / 100;

        }






    }
}
