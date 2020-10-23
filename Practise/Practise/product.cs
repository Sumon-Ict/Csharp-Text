using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Practise
{
    public class product
    {

        public string name { get; set; }
        public string description { get; set; }

        private int age;

        public int A
        {
            get { return age; }

            set
            {
                if (value < 0)
                    age = 0;
                else
                    age = value;

            }
        }

 
        //public double price { get; set; }

        private double P;

        public double price
        {
            get { return P; }

            set
            {
                if (value < 0)
                { P = 0; }

                else
                    P = value;

            }

        }

        public string formateprice()
        {
            return $"taka :  {P.ToString("0.000")}";

        }

    }
}
