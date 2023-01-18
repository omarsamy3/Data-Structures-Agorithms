using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DataStructures.LinkedList
{
    public class LinkedList
    {
        #region Members
        private class Node
        {
            public int value;
            public Node next;


            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;
        private int size;

        #endregion

        #region Public Methods
        public void addLast(int item)
        {
            var node = new Node(item);

            if (isEmpty()) first = last = node;
            else
            {
                last.next = node;
                last = node;
            }
            size++;
        }

        public void addFirst(int item)
        {
            var node = new Node(item);
            if (isEmpty()) first = last = node;
            else
            {
                first.next = node;
                first = node;
            }
            size++;
        }

        public int indexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current != null)
                if (current.value == item) return index;
                else
                {
                    current = current.next;
                    index++;
                }

            return -1;
        }

        public bool contains(int item)
        {
            return indexOf(item) >= 0;
        }

        public void removeFirst()
        {
            var temp = first;
            first = null;
            first = temp.next;
            size--;
        }

        public void removeLast()
        {
            if (isEmpty()) { Console.WriteLine("The list is empty"); return; }
            else if (first.next == null)
            {
                first = last = null;
                Console.WriteLine("The list became empty");
            }
            else
            {
                var previous = getPrevious(last);
                last = previous;
                last.next = null;
            }
            size--;
        }

        public int Size()
        {
            return size;
        }

        public int[] toArray()
        {
            int[] arr = new int[size];
            var current = first;
            int index = 0;
            while (current != null)
            {
                arr[index] = current.value;
                index++;
                current = current.next;
            }
            return arr;
        }

        public void print()
        {
            if (first == null) Console.WriteLine("The linked list is empty");
            else
            {
                var array = toArray();
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < array.Length - 1)
                        Console.Write(array[i] + ", ");
                    else
                        Console.Write(array[i]);

                }
                Console.WriteLine("]");
            }
        }

        public void reverse()
        {
            if (isEmpty()) return;
            var previous = first;
            var current = first.next;
            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            first.next = null;
            last = first;
            first = previous;

        }

        public int getKthFromTheEnd(int k)
        {
            var target = first;
            var position = first;
            if (isEmpty() || k <= 0 || k > size) throw new Exception("Unvalid Input");
            else
            {
                var index = size;
                for (int i = 0; i < k - 1; i++)
                {
                    position = position.next;
                }

                while (position != null)
                {
                    if (index == k) break;
                    position = position.next;
                    target = target.next;
                    index--;
                }
                return target.value;
            }
        }

        public void printMiddle()
        {
            var target = first;
            var position = first;
            while (position != last && position.next != last)
            {
                position = position.next.next;
                target = target.next;
            }

            if (position == last)
                Console.WriteLine(target.value);
            else
                Console.WriteLine(target.value + ", " + target.next.value);
        }

        //Floyd's Cycle-finding Algorithm.
        public bool hasLoop()
        {
            //Not Implemented yet.
            return last.next != null;
        }
        #endregion

        #region Private Methods
        private Node getPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node) return current;
                current = current.next;
            }
            return null;
        }

        private bool isEmpty()
        {
            return first == null;
        }
        #endregion


    }
}
