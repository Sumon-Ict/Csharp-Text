using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Student : Worker
    {

        public double workhour { get; set; }

        public Student(double wh,string s,int age):
            base(s,age)
        {
            workhour = wh;


        }

        public Student()
        {

        }
        public Student(double wh,string str,int j,double d):
            base(str,j,d)
        {
            workhour = wh;
        }


        public double  salary()
        {
            return workhour * 20;
        }

        public override string detail()
        {
            return name;

        }


    }
}
