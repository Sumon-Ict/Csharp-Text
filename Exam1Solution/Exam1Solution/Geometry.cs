using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Exam1Solution
{
   public  class Geometry
    {

     public double   CalculateArea(Shape shape)
        {
            if (shape is Circle)
            {
                var circle = shape as Circle;

                return Math.PI * circle.Radius * circle.Radius;
            }

            else if (shape is Rectangle)
            {
                var rectangle = shape as Rectangle;

                return rectangle.Height * rectangle.Width;
            }
            else if (shape is Triangle)
            {
                var triangle = shape as Triangle;

                var s = (triangle.Side1 + triangle.Side2 + triangle.Side3) / 2.0;

                return Math.Sqrt(s * (s - triangle.Side1) * (s - triangle.Side2) * (s - triangle.Side3));

            }
            else
                throw new InvalidOperationException("shape does not suported");

        }


        public double CalculatePerimeter(Shape shape)
        {
            if(shape is Circle)
            {
                var C = shape as Circle;

                return 2 * Math.PI * C.Radius;
            }
            else if(shape is Rectangle)
            {
                var R = shape as Rectangle;

                return 2 * (R.Height + R.Width);

            }
            else if(shape is Triangle)
            {
                var T = shape as Triangle;

                return T.Side1 + T.Side2 + T.Side3;

            }
            else
                throw new InvalidOperationException("shape does not suported");
        }

    }
}
