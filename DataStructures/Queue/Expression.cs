using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    internal class Expression
    {
        #region Fields
        private char[] leftBrackets = new char[] { '(', '[', '{', '<' };
        private char[] rightBrackets = new char[] { ')', ']', '}', '>' };
        #endregion

        #region Public Methods
        public string reverse(string input)
        {
            StringBuilder reversed = new StringBuilder();
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                s.Push(input[i]);
            }
            for (int j = 0; j < input.Length; j++)
            {
                reversed.Append(s.Pop());
            }
            foreach (char c in input.ToCharArray())
                s.Push(c);
            return reversed.ToString();
        }

        public bool isBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();
            int count = 0;
            foreach (char c in input.ToCharArray())
            {
                if (isLeftBracket(c))
                {
                    stack.Push(c);
                    count++;
                }
                if (count > 0)
                {
                    if (isRightEqualBracket(c, stack.Peek()))
                    {
                        stack.Pop();
                        count--;
                    }
                }
                else count--;
            }
            return count == 0;
        }

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

        #endregion

        #region Private Methods
        private bool isLeftBracket(char c)
        {
            return leftBrackets.Contains(c);
        }
        private bool isRightEqualBracket(char c, char top)
        {
            return indexOf(c, rightBrackets) == indexOf(top, leftBrackets);
        }
        private int indexOf(char c, char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == c) return i;
            }
            return -1;
        }

        #endregion

    }
}
