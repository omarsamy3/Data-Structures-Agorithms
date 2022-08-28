using DataStructures;
using System;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Commented
            //_Array array1 = new _Array(3);

            //array1.Insert(1);
            //array1.Insert(3);
            // array1.Insert(2);
            //array1.Insert(4);
            //array1.Insert(5);
            //array1.Insert(6);
            //array1.Insert(7);

            //array1.RemoveAt(6);
            //array1.RemoveAt(5);
            //array1.RemoveAt(4);

            //array1.Insert(10);

            //array1.RemoveAt(0);
            //array1.RemoveAt(2);

            // array1.Insert(4);
            //array1.Insert(5);

            //array1.Print();

            //Console.WriteLine(array1.ItemAt(2)); 
            //Console.WriteLine(array1.ItemAt(4)); 

            //Console.WriteLine(array1.IndexOf(2)); 
            //Console.WriteLine(array1.IndexOf(4)); 

            //LinkedList myList = new LinkedList();
            //myList.addLast(10);
            //myList.addLast(20);
            //myList.addLast(30);
            //myList.addLast(40);
            //myList.addLast(50);
            //myList.addLast(60);

            //var empty = new LinkedList();
            //Console.WriteLine("\n *******************************");
            //int[] arr = myList.toArray();
            //foreach (var item in arr)
            //{
            //    Console.Write(item+" ");
            //}
            //Console.WriteLine("\n *******************************");
            //myList.print();
            //myList.printMiddle();
            //Console.WriteLine("***************kth****************");
            //Console.WriteLine(myList.getKthFromTheEnd(2)); 
            //Console.WriteLine("*******************************");
            //myList.reverse();
            //myList.print();
            // Console.WriteLine(empty.getKthFromTheEnd(2));
            //myList.printMiddle();
            //Console.WriteLine(myList.hasLoop());
            //Expression e = new Expression();
            //string s = "ABCDEFG";
            //string output = e.reverse(s);
            ////Console.WriteLine(output);


            //s = "[<(ab + cd)>]";
            //bool result = e.isBalanced(s);
            //Console.WriteLine(result);


            //Stack stack = new Stack();

            //stack.push(10);
            //stack.push(20);
            //stack.push(30);
            //stack.push(40);


            //stack.print();
            //Console.Write("Peak: ");
            //Console.WriteLine(stack.peek());
            //Console.Write("IsEmpty: ");
            //Console.WriteLine(stack.isEmpty());
            //Console.WriteLine("*************************************");

            //stack.pop();
            //stack.print();
            //Console.Write("Peak: ");
            //Console.WriteLine(stack.peek());
            //Console.Write("IsEmpty: ");
            //Console.WriteLine(stack.isEmpty());
            //Console.WriteLine("*************************************");

            //stack.pop();
            //stack.print();
            //Console.Write("Peak: ");
            //Console.WriteLine(stack.peek());
            //Console.Write("IsEmpty: ");
            //Console.WriteLine(stack.isEmpty());
            //Console.WriteLine("*************************************");

            //stack.pop();
            //stack.print();
            //Console.Write("Peak: ");
            //Console.WriteLine(stack.peek());
            //Console.Write("IsEmpty: ");
            //Console.WriteLine(stack.isEmpty());
            //Console.WriteLine("*************************************");

            //stack.pop();
            //stack.print();
            //Console.Write("IsEmpty: ");
            //Console.WriteLine(stack.isEmpty());
            //Console.Write("Peak: ");
            //Console.WriteLine(stack.peek());
            //Console.WriteLine("*************************************");
            #endregion

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Console.WriteLine("Before reversing(1-2-3), and the peek will be 1");
            //Console.WriteLine(queue.Peek());
            //Expression e = new Expression();
            //e.reverseQueue(queue);
            //Console.WriteLine("After reversing(3-2-1), and the peek will be 3");
            //Console.WriteLine(queue.Peek());

            //ArrayQueue queue = new ArrayQueue(5);

            //queue.print();
            //Console.WriteLine("Is the queue empty: ");
            //Console.WriteLine(queue.isEmpty());
            //Console.WriteLine("Peek");
            ////Console.WriteLine(queue.peek());
            //Console.WriteLine("Is the queue full: ");
            //Console.WriteLine(queue.isFull());
            //queue.enqueue(10);
            //queue.enqueue(20);
            //queue.enqueue(30);
            //queue.enqueue(40);
            //queue.enqueue(50);
            //queue.dequeue();
            //queue.dequeue();
            //queue.dequeue();
            //queue.enqueue(60);
            //queue.print();
            //queue.enqueue(70);
            //Console.WriteLine("Is the queue full: ");
            //Console.WriteLine(queue.isFull());
            //Console.WriteLine("Peek");
            //Console.WriteLine(queue.peek());

            //queue.print();
            //Console.WriteLine("Is the queue empty: ");
            //Console.WriteLine(queue.isEmpty());
            //queue.dequeue(); //Remove 10
            //queue.dequeue(); //Remove 20 
            //queue.dequeue(); //Remove 30
            //Console.WriteLine("Peek 40");
            //Console.WriteLine(queue.peek());
            //queue.dequeue(); //Remove 40
            //queue.dequeue(); //Remove 50
            //queue.dequeue(); //The queue is empty
            //Console.WriteLine("Is the queue empty: ");
            //Console.WriteLine(queue.isEmpty());
            //Console.WriteLine("Is the queue full: ");
            //Console.WriteLine(queue.isFull());

            //queue.print();

            QueueWithTwoStacks queue = new QueueWithTwoStacks();

            queue.enqueue(10);
            queue.enqueue(20);
            queue.enqueue(30);

            var first = queue.dequeue();
            Console.WriteLine(first);
        } 
    }
}