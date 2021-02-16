using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class Dictonary<T,Y>
    {
        T[] keys;
        Y[] values;
        T[] tempKeys;
        Y[] tempValues;

        public Dictonary()
        {
            keys = new T[0];
            values = new Y[0];
        }

        public void Add(T key, Y value)
        {
            tempKeys = keys;
            tempValues = values;

            keys = new T[keys.Length + 1];
            values = new Y[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

       

        public int Count
        {
            get { return values.Length; }
        }


    }
}
