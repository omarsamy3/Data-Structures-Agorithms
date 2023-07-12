using DataStructures;
using DataStructures.Array;
using DataStructures.HashTable;
using DataStructures.LinkedList;
using DataStructures.Tree;
using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
		{
			//TryArray();
			TryLinkedList();
			//TryHashTable();
			//TryBinaryTree();

		}
		static void TryBinaryTree()
			{
				BinaryTree tree = new BinaryTree();
				tree.insert(5);
				tree.insert(3);
				tree.insert(4);
				tree.insert(2);
				tree.insert(7);
				tree.insert(1);
				tree.insert(6);
				tree.insert(9);
				tree.insert(8);
				tree.insert(10);

				BinaryTree treeToCompare = new BinaryTree();
				treeToCompare.insert(5);
				treeToCompare.insert(3);
				treeToCompare.insert(4);
				treeToCompare.insert(2);
				treeToCompare.insert(7);
				treeToCompare.insert(1);
				treeToCompare.insert(6);
				treeToCompare.insert(9);
				treeToCompare.insert(8);
				treeToCompare.insert(10);

				Helper.print("Insert nodes", "Print the tree after inserting the numbers 1-10 in different orders");
				tree.Root.Print();

				Helper.print("Find a node", "Try to find 5, 1, 10, 11, which should return true, true, true, flase");
				Console.WriteLine(tree.find(5));
				Console.WriteLine(tree.find(1));
				Console.WriteLine(tree.find(10));
				Console.WriteLine(tree.find(11));

				Helper.print("Depth First Traverse", "Traverse throght the tree, Pre_Order appreach");
				tree.Pre_Order_Traverse();

				Helper.print("Depth First Traverse", "Traverse throght the tree, In_Order appreach");
				tree.In_Order_Traverse();

				Helper.print("Depth First Traverse", "Traverse throght the tree, Post_Order appreach");
				tree.Post_Order_Traverse();

				Helper.print("Height Nodes", "Get the Height of the tree, which is the longest node.");
				Console.WriteLine(tree.height());

				Helper.print("Minimum value", "Get the minimum value in the tree.");
				Console.WriteLine(tree.MinValue());
				
				Helper.print("Maximum value", "Get the Maximum value in the tree.");
				Console.WriteLine(tree.MaxValue());

				Helper.print("Equality", "Check the equality for two trees.");
				tree.Root.Print();
				treeToCompare.Root.Print();
				Console.WriteLine(tree.equals(treeToCompare));
			}

		static void TryHashTable()
		{
			HashTable2 hash = new HashTable2();

			hash.put(1, "Omar");
			hash.put(2, "Ahmed");
			hash.put(3, "Mohammed");
			hash.put(4, "Said");
			hash.put(5, "Hany");
			hash.put(6, "Ramy");
			hash.put(7, "Hossam");
			hash.put(8, "Ali");
			hash.put(9, "Abdo");
			hash.put(10, "Body");
			hash.put(11, "Yassin");
			hash.put(12, "Tarek");
			hash.put(12, "Essam");

			hash.remove(1);
			Console.WriteLine("The value at key 5 is: " + hash.get(5));
			hash.print();
		}

		static void TryArray()
		{
			var array = new _Array();
			array.Insert(10);
			array.Insert(20);
			array.Insert(30);
			array.Insert(40);
			Helper.print("Array First Test", "This array should have elements 10 - 20 - 30 - 40");
			array.Print();
			array.RemoveAt(2);
			Helper.print("Array Second Test", "This array should have elements 10 - 20 - 40");
			array.Print();
			Helper.print("Array Third Test", "Index of 40 should be 2");
			Console.WriteLine(array.IndexOf(40));
			
		}

		static void TryLinkedList()
		{
			var linkedList = new LinkedList();

			linkedList.addLast(10);
			linkedList.addLast(20);
			linkedList.addLast(30);
			linkedList.addLast(40);
			Helper.print("LinkedList First Test", "Should be: [10, 20, 30, 40]");
			linkedList.print();
			Helper.print("LinkedList Second Test", "Should be: [0, 10, 20, 30, 40]");
			linkedList.addFirst(0);
			linkedList.print();
			Helper.print("LinkedList Third Test", "Should be: 1, true, false, 5");
            Console.WriteLine(linkedList.indexOf(10));
            Console.WriteLine(linkedList.contains(20));
            Console.WriteLine(linkedList.contains(50));
            Console.WriteLine(linkedList.Size());
			linkedList.print();
			Helper.print("LinkedList Forth Test", "Should be: [10, 20, 30, 40]");
			linkedList.removeFirst();
			linkedList.print();
		}
	}
}