using System;
using System.Collections.Generic;
using System.Text;

namespace WaterBottleExample
{
   public  class JuiceBottle:Bottle
    {

        public const int v = 6;
        private string pipe { get; set; }
        private string belt { get; set; }

        public JuiceBottle(int capacity,string color,int amount)
            :base(capacity,color,amount)
        {

        }
        public JuiceBottle(int capacity,string color)
            :this(capacity,color,v)
        {

        }
        
    }
}
