using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Array
{
    public class _Array
    {
        private int[] items;
        private static int Count;

        public _Array()
        {
            items = new int[10];
            Count = 0;
        }
        public _Array(int length)
        {
            items = new int[length];
            Count = 0;
        }


        public void Insert(int item)
        {
            //Check if the array is full, resize it.
            if (Count < items.Length) //Not full
            {
                items[Count] = item;
                Count++;
            }
            //Full
            else
            {
                //Make a new array to copy items and swap again.
                int[] newItems = new int[Count * 2];
                for (int i = 0; i < Count; i++)
                {
                    newItems[i] = items[i];
                }
                newItems[Count] = item;
                items = newItems; //Swap
                Count++;
            }

        }

        public void RemoveAt(int index)
        {
            //Validate the index.
            if (index < Count && index >= 0)
            {
                for (int i = index; i < Count; i++)
                    items[i] = items[i + 1]; //Shift the elements
                Count--;
            }
            else
            {
                Console.WriteLine("The item is out of the range");
            }

        }

        public int ItemAt(int index)
        {
            if (index < Count)
            {
                Console.WriteLine("*****************");
                Console.Write($"items[{index}]: ");
                return items[index];
            }
            else
            {
                Console.WriteLine("*****************");
                Console.WriteLine("Our of Range");
                return -1;
            }
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == item)
                {
                    Console.WriteLine("*****************");
                    Console.Write($"IndexOf[{item}]: ");
                    return i;
                }
            }
            Console.WriteLine("*****************");
            Console.WriteLine("Our of Range");
            return -1;
        }
        public void Print()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
