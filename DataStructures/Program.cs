using DataStructures;
using DataStructures.HashTable;
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
			BinaryTree tree = new BinaryTree();
			tree.insert(5);
			tree.insert(3);
			tree.insert(4);
			tree.insert(2);
			tree.insert(1);
			tree.insert(7);
			tree.insert(6);
			tree.insert(9);
			tree.insert(8);
			tree.insert(10);

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
		}

		private static void TryHashTable()
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
	}
}