using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    internal class QueueWithTwoStacks
    {
        private Stack<int> Stack1 = new Stack<int>();
        private Stack<int> Stack2 = new Stack<int>();

        public void enqueue(int item)
        {
            Stack1.Push(item);
        }

        public int dequeue()
        {
            if (isEmpty()) throw new Exception("The Queue Is Empty");

            MoveStack1ToStack2();
            return Stack2.Pop();
        }

        public int peek()
        {
            if (isEmpty()) throw new Exception("The Queue Is Empty");

            MoveStack1ToStack2();
            return Stack2.Peek();
        }

        public bool isEmpty()
        {
            return Stack1.Count == 0 && Stack2.Count == 0;
        }

        private void MoveStack1ToStack2()
        {
            if (Stack2.Count == 0)
                while (Stack1.Count != 0)
                    Stack2.Push(Stack1.Pop());
        }
    }
}
