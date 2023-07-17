using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public static class Stack
    {
        private static int[] stack = new int[10];
        private static int Index = 0;

		public static void push(int item)
        {
            if (!isFull()) stack[Index++] = item;
            else throw new StackOverflowException();
        }

        public static int pop()
        {
            if (isEmpty()) throw new Exception("The stack is empty");
            return stack[--Index];
        }

        public static int peek()
        {
            if (isEmpty()) throw new Exception("The stack is empty");
            return stack[Index - 1];
        }

        private static bool isEmpty()
        {
            return Index == 0;
        }

        private static bool isFull()
        {
            return Index == stack.Length; // True if is full
        }

        public static void print()
        {
            if (isEmpty()) Console.WriteLine("The stack is empty");
            for (int i = 0; i < Index; i++)
                Console.WriteLine(stack[Index - 1 - i]);
        }
    }
}
