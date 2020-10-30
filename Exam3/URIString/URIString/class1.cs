using System;
using System.Collections.Generic;
using System.Text;

namespace URIString
{
    public class class1
    {  
        public string name { get; set; }


        public double price { get; set; }



        public string formate()
        {

            return $"price taka : {price.ToString("0.00")}";

        }

    }
}
