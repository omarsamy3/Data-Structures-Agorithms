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

        /// <summary>
        /// put a new entry if the <paramref name="key"/> is new, and update the <paramref name="value"/> if exists.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
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

        /// <summary>
        /// Get the required entity at <paramref name="key"/>
        /// </summary>
        /// <param name="key"></param>
        /// <returns>The entity at <paramref name="key"/> if exists, or null if not.</returns>
        public String get(int key)
        {
            var entry = getEntry(key);

            return (entry == null) ? null : entry.value;
        }

        /// <summary>
        /// Remove the entity if exist, or throw a Null exception if not exists.
        /// </summary>
        /// <param name="key"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void remove(int key)
        {
            var entry = getEntry(key);
            if (entry == null)
                throw new Exception("Null Exception");
            getBucket(key).Remove(entry);
        }

        /// <summary>
        /// For getting the comming bucket as a linkedlist of entries.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>The required bucket by its <paramref name="key"/> </returns>
        private LinkedList<Entry> getBucket(int key)
        {
            return entries[hash(key)];
        }

        /// <summary>
        /// Get the required bucket at the given <paramref name="key"/>
        /// </summary>
        /// <param name="key"></param>
        /// <returns>The bucket at <paramref name="key"/>, or create a new one and return.</returns>
        private LinkedList<Entry> getOrCreateBucket(int key)
        {
            var index = hash(key);
            var bucket = entries[index];
            if (bucket == null)
                entries[index] = new LinkedList<Entry>();

            return entries[index];
        }

        /// <summary>
        /// Get an entry from the entries bucket.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>The required entity of the <paramref name="key"/> if found, and null if not found</returns>
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

		/// <summary>
		/// Get the index of the entries depending on the <paramref name="key"/> value
		/// </summary>
		/// <param name="key"></param>
		/// <returns>the index of the comming entry, from this formula <paramref name="key"/> % entries.Length</returns>
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
