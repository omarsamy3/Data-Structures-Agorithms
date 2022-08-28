using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
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
            if(Stack2.Count == 0)
            {
                while(Stack1.Count != 0)
                {
                    Stack2.Push(Stack1.Pop());
                }
            }
                return Stack2.Pop();
        }
    }
}
