namespace _03.BiDictionary
{
    using System;
    using System.Collections.Generic;

    public class BiDictionary<T, K, V>
    {
        private Dictionary<T, V> firstKeyCollection;
        private Dictionary<K, V> secondCollection;

        public BiDictionary()
        {
            this.firstKeyCollection = new Dictionary<T, V>();
            this.secondCollection = new Dictionary<K, V>();
        }

        public bool Contains(object key)
        {
            if(key is T && key is K)
            {
                var firstResult = firstKeyCollection.ContainsKey((T)key);
                var secondResult = secondCollection.ContainsKey((K)key);

                return firstResult || secondResult;
            }
            else if(key is T)
            {
                return firstKeyCollection.ContainsKey((T)key);
            }
            else if (key is K)
            {
                return secondCollection.ContainsKey((K)key);
            }
            else
            {
                throw new ArgumentException("invalid type of argument");
            }
        }

        public bool Add(T firstKey, K secondKey, V value)
        {
            if (!this.secondCollection.ContainsKey(secondKey) && !this.firstKeyCollection.ContainsKey(firstKey))
            {
                this.firstKeyCollection.Add(firstKey, value);
                this.secondCollection.Add(secondKey, value);

                return true;
            }

            return false;
        }

        public V GetValue(object key)
        {
            if (key is T && key is K)
            {
                if (this.firstKeyCollection.ContainsKey((T)key))
                {
                    return firstKeyCollection[(T)key];
                }
                else if (this.secondCollection.ContainsKey((K)key))
                {
                    return secondCollection[(K)key];
                }
            }
            if (key is T)
            {
                return firstKeyCollection[(T)key];
            }
            else if (key is K)
            {
                return secondCollection[(K)key];
            }
            else
            {
                throw new ArgumentException("invalid type of argument");
            }
        }
    }
}
