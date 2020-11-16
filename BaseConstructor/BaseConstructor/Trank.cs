using System;
using System.Collections.Generic;
using System.Text;

namespace BaseConstructor
{
   public  class Trank:Bottle
    {

        public double length { get; }

        public string name { get; }

        

        public Trank(double l,double h,double w)
            :base(h,w)
        {

            length = l;

        }
        public Trank(double h,double w, double r, int c )
            :base(h,w,c)
        {
            length = r;

        }
        public Trank(string s,double l,double h,double w,int r)
            :base(h,w,r)
        {
            name = s;
            length = l;
        }



        public override double area()
        {
            return Height * Width;
        }
        public double Area()
        {
            return Height * Width * Radius;

        }

        public override void datails()
        {
            Console.WriteLine("my name is sumon");

        }



    }
}
