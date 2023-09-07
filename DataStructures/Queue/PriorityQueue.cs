using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
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

            if (item < items[count - 1])
            {
                ShiftItemsToSort(item);
                count++;
            }
            else items[count++] = item;
        }

        //Another factoring implementation of the enqueue method
        public void add(int item)
        {
            if (isFull()) throw new Exception("The queue is full");

            int i = ShiftingItemsToInsert(item); 
            items[i] = item;
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

        public void print()
        {
            foreach (var item in items)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        private void ShiftItemsToSort(int item)
        {
            int i;
            for (i = count - 1; i >= 0; i--)
            {
                if (items[i] > item)
                {
                    int temp = items[i];
                    items[i] = item;
                    items[i + 1] = temp;
                }
            }
        }

        private int ShiftingItemsToInsert(int item)
        {
            int i;
            for (i = count - 1; i >= 0; i--)
            {
                if (items[i] > item) items[i + 1] = items[i];
                else break;
            }
            return i + 1;
        }

        
    }
}
