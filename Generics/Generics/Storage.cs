using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
   public class Storage<T>
    {

        private T[] items;

        public Storage(int size)
        {
            items = new T[size];

        }

        public void putitems(int index,T itemvalue)
        {
            items[index] = itemvalue;
        }


        public T getitem(int index)
        {
            return items[index];

        }

            

    }
}
