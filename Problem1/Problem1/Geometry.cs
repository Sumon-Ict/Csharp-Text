using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
   public  class Geometry
    {

        public double CalculateArea(Shape shape)
        {
            if(shape is Circle)
            {
                var C = shape as Circle;

                return Math.PI * C.Radius * C.Radius; 
            }

            if(shape is Rectangle)
            {
                var R = shape as Rectangle;

                return R.Height * R.Width;

            }
           if(shape is Triangle)
            {
                var T = shape as Triangle;

                var s = (T.Side1 + T.Side2 + T.Side3) / 2.0;

                return Math.Sqrt(s * (s - T.Side1) * (s - T.Side2) * (s - T.Side3));

            }
           else
            {
                throw new InvalidOperationException("shape is not supported");

            }
        }
    }
}
