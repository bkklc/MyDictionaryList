using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryList
{
    public class DictionaryList<Key, Value>
    {
        
        Key[] keys;
        Value[] values;

        // constructor - yapıcı metot
        public DictionaryList()
        {
            
            keys = new Key[0]; // 0 elemalı bir array oluşturuluyor
            values = new Value[0]; // 0 elemalı bir array oluşturuluyor
        }

        public void Add(Key key, Value value)
        {
            Key[] tempKeys = keys; // keys önceki değerlerini (referansını) tempKeys tutuyoruz.
            Value[] tempValues = values; // values önceki değerlerini (referansını) tempValues tutuyoruz.

            keys = new Key[keys.Length + 1]; // keysin eleman sayısını artırıyoruz.
            values = new Value[values.Length + 1]; // valuesin eleman sayısını artırıyoruz.

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
                
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;                     
        }

        public int Length
        {
            get { return keys.Length; }

        }

        public Key[] _Keys
        {
            get { return keys; }
        }

        public Value[] _Values
        {
            get { return values; }
        }



    }
}
