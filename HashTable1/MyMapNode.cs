using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable1
{
    public class MyMapNode<K, V>
    {
        public readonly int size;
        private readonly LinkedList<KeyValuePair<K, V>>[] items;
        public readonly V[] array;
        public MyMapNode(int Size)
        {
            size = Size;
            items = new LinkedList<KeyValuePair<K, V>>[Size];
            array = new V[Size];
        }
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public void Add(K key, V value)
        {
            int index = GetArrayPosition(key);
            if (items[index] == null)
            {
                items[index] = new LinkedList<KeyValuePair<K, V>>();
                items[index].AddLast(new KeyValuePair<K, V>(key, value));
            }
            else
            {
                Console.WriteLine($"Key ='{key}' and Value = '{value}' is not added in HashTable ");
            }
        }
        public void Get(K key)
        {
            int index = GetArrayPosition(key);
            bool Exist = false;
            foreach (KeyValuePair<K, V> items in items[index])
            {
                if (items.Key.Equals(key))
                {
                    Exist = true;
                    array[index] = items.Value;
                }
            }
            if (!Exist)
            {
                Console.WriteLine($"key = '{key}' Doesn,t Exist in Hash Table");
            }
        }
        public void FrequencyOfWords(V[] arr, int arrLength)
        {
            bool[] visited = new bool[arrLength];
            int countWords = 0;
            for (int i = 0; i < arrLength; i++)
            {
                countWords++;
                if (visited[i] == true)
                {
                    continue;
                }
                int count = 1;
                for (int j = i + 1; j < arrLength; j++)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine($"'arr[i]' is Repeated {count} Times");
            }
            Console.Write($"Total Words are {countWords}");
        }

        public void Remove(K key)
        {
            int index = GetArrayPosition(key);
            KeyValuePair<K, V> foundItem = default(KeyValuePair<K, V>);
            foreach (KeyValuePair<K, V> item in items[index])
            {
                if (item.Key.Equals(key))
                {
                    items[index].Remove(item);
                    break;
                }
            }
        }
    }
    public struct KeyValue<K,V>
    {
        public K Key { get; set; }  
        public V Value { get; set; }
    }
}