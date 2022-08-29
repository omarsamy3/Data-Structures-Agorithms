 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class PriorityQueue
    {
        private int[] items;
        private int count = 0;

        public PriorityQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void enqueue(int item)
        {
            if (isFull()) throw new Exception("The queue is full");
            if (isEmpty())
            {
                items[count++] = item;
                return;
            }

            if (item < items[count - 1])
            {
                ShiftItemsToSort(item);
                    count++;
            } 
            else items[count++] = item;  
         }

        //Another factoring implementaion of the enqueue method
        public void add(int item)
        {
            if (isFull()) throw new Exception("The queue is full");
            int i;
            ShiftingItems(item);
            items[i + 1] = item;
            count++;
         }

        public void dequeue()
        {
            if (isEmpty()) throw new Exception("The queue is empty");

            items[--count] = 0;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public bool isFull()
        {
            return count == items.Length;
        }

        public string toString()
        {
            string result = "";
            foreach(var item in items)
            {
                result += item + " ";
            }
            return result;
        }

        private void ShiftItemsToSort(int item)
        {
            for (int i = count - 1; i >= 0; i--)
            {
                if (items[i] > item)
                {
                    int temp = items[i];
                    items[i] = item;
                    items[i + 1] = temp;
                }
            }
        }

        private void ShiftingItems(int item)
        {
            int i;
            for (i = count - 1; i >= 0; i--)
            {
                if (items[i] > item) items[i + 1] = items[i];
                else break;
            }
        }
    }
}
