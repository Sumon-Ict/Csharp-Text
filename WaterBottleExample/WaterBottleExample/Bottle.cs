using System;
using System.Collections.Generic;
using System.Text;

namespace WaterBottleExample
{
    public abstract class Bottle
    {
        public int Capacity { get; }
        public string Color { get; }

        public int CurrentAmount { get;  set; }


        public Bottle(int capacity,string color,int amount )
        {
            Capacity = capacity;
            Color = color;
            amount = 0;

        }
        public Bottle(int capacity,string color)
        {
            Capacity = capacity;
            Color = color;

        }


        public void AddElement(int amount,int threshold)
        {
            if (amount > Capacity)
            {
                CurrentAmount = Capacity - threshold;

            }
            else
                CurrentAmount = amount - threshold;
        }

        public void RemoveElement(int amount,int threshold)
        {
            if (amount > CurrentAmount)
                CurrentAmount = 0;
            else
                CurrentAmount = amount - threshold;
            
        }
    }
}
