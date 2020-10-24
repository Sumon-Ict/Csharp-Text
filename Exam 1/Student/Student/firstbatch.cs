using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Student
{
  public   class firstbatch
    {


        public double price { get; set; }


        public virtual double discount()
        {
            return  price * 20 / 100;

        }




        private string name;

        public string address { get; set; }

       public  double weight { get; set; }

     public float age { get; set; }


        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public  string formateage()
        {
            return $"age ={age.ToString("0.0")}";

        }


    }
}
