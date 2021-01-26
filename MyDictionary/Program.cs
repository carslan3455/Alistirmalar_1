using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciNoAd = new MyDictionary<int, string>();
            ogrenciNoAd.Add(1, "Sinem");
            ogrenciNoAd.Add(2, "Ihsan");
            ogrenciNoAd.Add(3, "Es");
            ogrenciNoAd.Add(4, "Oz");

            ogrenciNoAd.Print(ogrenciNoAd);

        }
    }

    class MyDictionary<K, V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];

            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public void Print(MyDictionary<K, V> myDictionary)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("[" + keys[i] + "," + values[i] + "]");

            }
        }

    }
}
