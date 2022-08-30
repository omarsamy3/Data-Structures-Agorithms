using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class HashTable
    {
        #region Notes
        /*
            Hash Tables or (Dictionaries) >> have (key, value) and don't accept dublicate keys.
            Sets >> have only keys and also don't accept dublicate keys.
            Hash Functions >> lets you validate the input in the table list as >> they put the input in the right index.
            Collisions >> It occurs when you try to put the input in a reserved place.
            Chaining >> to solve the collision by making a reference for an array to contain the input in the same index.
            Open Addressing (Linear Probing) to increase the index linearlly to put the input in a free index.
            Open Addressing (Quadratic Probing) to increase the index Quadraticlly to put the input in a free index.
            Open Addressing (Double Hashing) to increase the index with specific equation to put the input easily in the right free index.
         */
        #endregion


        #region Members And Constructor
        private class Entry
        {
            public int key;
            public string value;

            public Entry(int key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }
        private List<LinkedList<Entry>> list;
        private Entry[] array;
        private int index;
        private int[] keys;
        private int keysCount = 0;

        public HashTable(int capacity)
        {
            array = new Entry[capacity];
            keys = new int[capacity];
            list = new List<LinkedList<Entry>>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                list.Add(new LinkedList<Entry>());
            }
        }

        #endregion


        #region Public Methods

        public void put(int key, string value)
        {
            index = hash(key);
            Entry entry = new Entry(key, value);

            if (NotdublicatedOrFreeSpace(key)) addToTheHashTable(entry);
            else  addToTheChainLinkedList(entry);
        }

        public string get(int key)
        { int count = 0;
            foreach(var entry in array)
            {
                if(entry != null)
                if (entry.key == key) return entry.value;

                foreach(var list in list[count++])
                {
                    if(list.key == key) return list.value;
                }
            }
            return null;
        }

        public void remove(int key)
        {
            int count = 0;
            foreach (var entry in array)
            {
                if (entry.key == key)
                {
                    RemoveTheEntryFromTheEntries(entry);
                    break;
                }

                if (RemoveFromTheLinkedList(list[count], key)) break;
                count++;
            }
        }

        public void print()
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                printTheEntries(array[i]);

                printTheLinkedList(count++);
            }

        }

        #endregion


        #region Private Methods
        private bool ContainsKey(int key)
        {
            return keys.Contains(key);
        }

        private int hash(int key)
        {
            return key % array.Length;
        }

        private bool NotdublicatedOrFreeSpace(int key)
        {
            return (!this.ContainsKey(key) && keysCount < array.Length);
        }

        private void addToTheHashTable(Entry entry)
        {
            array[index] = entry;
            keys[index] = entry.key;
            keysCount++;
        }

        private void addToTheChainLinkedList(Entry entry)
        {
            index = hash(entry.key);
            if (list[index].Count == 0) list[index].AddLast(entry);
            else
                UpdateValueAndReturnIfDublicatedKeyOtherWiseAddEntry(entry, index);
        }

        private void UpdateValueAndReturnIfDublicatedKeyOtherWiseAddEntry(Entry entry, int index)
        {
            foreach (var item in list[index])
            {
                if (item.key == entry.key)
                {
                    item.value = entry.value;
                    return;
                }
            }
            list[index].AddLast(entry);
        }

        private void RemoveTheEntryFromTheEntries(Entry entry)
        {
            int index = 0;
            Entry[] arr = new Entry[array.Length];
            foreach (var item in array)
            {
                if (item == entry) continue;

                arr[index++] = item;
                keys[item.key % array.Length] = item.key;
            }
            array = arr;
        }

        private bool RemoveFromTheLinkedList(LinkedList<Entry> linkedlist, int key)
        {
            foreach (var item in linkedlist)
            {
                if (item.key == key)
                {
                    linkedlist.Remove(item);
                    return true;
                }
            }
            return false;
        }

        private void printTheLinkedList(int count)
        {
            Console.Write(" [");
            foreach (var list in list[count])
            {
                Console.Write($"({list.key}, {list.value}) ");
            }
            Console.WriteLine("]");
        }

        private void printTheEntries(Entry entry)
        {
            if (entry != null)
            {
                Console.Write($"({entry.key}, {entry.value})");
            }
            else Console.Write("( , )");
        }

        #endregion


    }
}
