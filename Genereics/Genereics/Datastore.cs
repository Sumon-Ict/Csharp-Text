using System;
using System.Collections.Generic;
using System.Text;

namespace Genereics
{
    public class Datastore<T>
    {
        private T[] element;

        public Datastore(int size)
        {
            element =new  T[size];

        }

        public void putelement(int  index,T value)
        {
            element[index] = value;

        }

        public T getelement(int index)
        {
            return element[index];

        }

       
    }
}
