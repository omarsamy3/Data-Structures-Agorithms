using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Stack
    {
        private int[] stack = new int[10]; 
        private int Index = 0;

        public void push(int item)
        {
            if (isFull()) stack[Index++] = item;
            else throw new StackOverflowException();
        }

        public int pop()
        {
            if (isEmpty()) throw new Exception("The stack is empty");
            int temp = stack[Index];
            stack[--Index] = 0;
            return temp;
        }

        public int peek()
        {
            if (isEmpty()) throw new Exception("The stack is empty");
            return stack[Index - 1];
        }

        public bool isEmpty()
        {
            return Index == 0;
        }

        private bool isFull()
        {
            return (Index == stack.Length) ; // True if is full
        }

        public void print()
        {
            if (isEmpty()) Console.WriteLine("The stack is empty");
            for(int i = 0; i < Index; i++)
            Console.WriteLine(stack[Index -  1 - i]);
        }
    }
}
