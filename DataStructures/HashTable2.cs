using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class HashTable2
    {
        private class Entry
        {
            public int key;
            public String value;

            public Entry(int key, String value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private LinkedList<Entry>[] entries = new LinkedList<Entry>[5];

        public void put(int key, String value)
        {
            var entry = getEntry(key);
            if (entry != null)
            {
                entry.value = value;
                return;
            }
            Entry e = new Entry(key, value);
            LinkedList<Entry>  bu =  getOrCreateBucket(key);
            bu.AddLast(e);
        }

        public String get(int key)
        {
            var entry = getEntry(key);

            return (entry == null) ? null : entry.value;
        }

        public void remove(int key)
        {
            var entry = getEntry(key);
            if (entry == null)
                throw new Exception("Null Exception");
            getBucket(key).Remove(entry);
        }

        private LinkedList<Entry> getBucket(int key)
        {
            return entries[hash(key)];
        }

        private LinkedList<Entry> getOrCreateBucket(int key)
        {
            var index = hash(key);
            var bucket = entries[index];
            if (bucket == null)
                entries[index] = new LinkedList<Entry>();

            return entries[index];
        }

        private Entry getEntry(int key)
        {
            var bucket = getBucket(key);
            if (bucket != null)
            {
                foreach (var entry in bucket)
                {
                    if (entry.key == key)
                        return entry;
                }
            }
            return null;
        }

        private int hash(int key)
        {
            return key % entries.Length;
        }

        public void print()
        {
            foreach(var bucket in entries)
            {
                Console.Write("[");
                foreach(Entry entry in bucket)
                {
                    Console.Write("(" + entry.key + ", " + entry.value + ")");
                }
                Console.WriteLine("]");
            }
        }
    }
}
