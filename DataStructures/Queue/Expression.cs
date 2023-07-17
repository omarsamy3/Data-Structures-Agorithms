using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    internal class Expression
    {
        public void reverseQueue(Queue<int> queue)
        {
            if (queue.Count == 0) return;

            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
                stack.Push(queue.Dequeue());

            while (stack.Count > 0)
                queue.Enqueue(stack.Pop());
        }

        public static char GetFirstRepeatingChar(string input)
        {
            HashSet<char> chars = new HashSet<char>();
            char result = 'c';
            foreach (var item in input)
            {
                if (chars.Contains(item))
                {
                    result = item;
                    break;
                }
                chars.Add(item);

            }
            return result;
        }

    }
}
