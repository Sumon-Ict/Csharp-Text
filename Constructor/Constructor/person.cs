using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
   public  class person
    {

        public string name { get; set; }
        public double weight { get; set; }
        private int roll { get; set; }      

       public int Roll
        {
            get { return roll; }
            set
            {
                if (value <= 0)
                    roll = 1;
                else
                    roll = value;
            }
        }

        public virtual double multiply()
        {
            var r = weight * Roll;
            return r;
        }
        public person()
        {

        }       
        public person(string str,double d,int r)
        {
            name = str;
            weight = d;
            Roll = r;
        }

        
        
    }
}
