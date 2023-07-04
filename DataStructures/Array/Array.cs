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
        private static int count;

        public _Array()
        {
            items = new int[10];
            count = 0;
        }
        public _Array(int length)
        {
            items = new int[length];
            count = 0;
        }


        public void Insert(int item)
        {
            if (count == items.Length) //Full Array, resize.
            {
                int[] newItems = new int[count * 2];

                for (int i = 0; i < count; i++) //Refilling.
                    newItems[i] = items[i];
                
                items = newItems; //Swapping
            }

            items[count++] = item;
        }

        public void RemoveAt(int index)
        {
            //Validate the index.
            if (index > count && index <= 0)
				throw new ArgumentOutOfRangeException
                    ("The item is out of the range");
			
			for (int i = index; i < count; i++)
                items[i] = items[i + 1]; //Shift the elements

            count--;
        }

        public int ItemAt(int index)
        {
            if (index < count)
            {
                Console.Write($"items[{index}]: ");
                return items[index];
            }
            else
            {
                Console.WriteLine("Our of Range");
                return -1;
            }
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == item)
                {
                    Console.Write($"IndexOf[{item}]: ");
                    return i;
                }
            }
            Console.WriteLine("Our of Range");
            return -1;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
