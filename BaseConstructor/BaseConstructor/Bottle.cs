using System;
using System.Collections.Generic;
using System.Text;

namespace BaseConstructor
{
   public abstract class Bottle
    {



        public abstract void datails();


        public double Height { get; }
        public double Width { get; }

        public int Radius { get; }


        public Bottle()
        {

        }

        public Bottle(double h,double w)
        {
            Height = h;
            Width = w;
        }

        public Bottle(double h,double w,int  r)
        {

            Height = h;
            Width = w;
            Radius = r;
        }



        public abstract double area();

       






    }
}
