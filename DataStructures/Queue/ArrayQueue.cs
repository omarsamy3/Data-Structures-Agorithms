using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    internal class ArrayQueue
    {
        private int[] array;
        private int first = 0;
        private int rear = 0;
        private int count = 0;


        public ArrayQueue(int capacity)
        {
            array = new int[capacity];
        }
        public void enqueue(int item)
        {
            if (!isFull())
            {
                array[rear] = item;
                rear = (rear + 1) % array.Length;
                count++;
            }
            else Console.WriteLine("The queue is full");
        }

        public int dequeue()
        {
            if (!isEmpty())
            {
                var temp = array[first];
                array[first] = 0;
                first = (first + 1) % array.Length;
                count--;
                return temp;
            }
            else throw new Exception("The queue is empty");
        }

        public int peek()
        {
            if (isEmpty()) throw new Exception("Empty queue");
            return array[first];
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public bool isFull()
        {
            return count == array.Length;
        }

        public void print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
