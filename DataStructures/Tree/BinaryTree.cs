using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
 

namespace DataStructures.Tree
{
	/// <summary>
	/// Binary Tree is a non-linear data structure, with O(log(n)) complexity.
	/// </summary>
	public class BinaryTree
	{
		private BinaryNode root;

		public BinaryNode Root { get { return root; } }

		/// <summary>
		/// Insert a node with <paramref name="value"/> to the its right place in the Binary Tree.
		/// </summary>
		/// <param name="value"></param>
		public void insert(int value)
		{
			var newNode = new BinaryNode(value);
			if (root == null)
			{
				root = newNode;
				return;
			}
			var current = root;
			while (true)
			{
				if (value == current.value) break;
				else if (value < current.value)
				{
					if (current.leftChild == null)
					{
						current.leftChild = newNode;
						break;
					}
					current = current.leftChild;

				}
				else if (value > current.value)
				{
					if (current.rightChild == null)
					{
						current.rightChild = newNode;
						break;
					}
					current = current.rightChild;
				}
			}
		}

		/// <summary>
		/// Find the node with this <paramref name="value"/> in the Binary Tree.
		/// </summary>
		/// <param name="value"></param>
		/// <returns>True, if able to find this <paramref name="value"/>, and false, if not.</returns>
		public bool find(int value)
		{
			var current = root;
			while (current != null)
			{
				if (value == current.value) return true;
				else if (value < current.value) current = current.leftChild;
				else if (value > current.value) current = current.rightChild;
			}
			return false;
		}

		public void Pre_Order_Traverse()
		{
			Pre_Order_Traverse(Root);
			Console.WriteLine();
		}
		public void In_Order_Traverse()
		{
			In_Order_Traverse(Root);
			Console.WriteLine();
		}
		public void Post_Order_Traverse()
		{
			Post_Order_Traverse(Root);
			Console.WriteLine();
		}
		private void Pre_Order_Traverse(BinaryNode root)
		{
			if (root == null) return; //The base condition.
			Console.Write(root.value + " ");
			this.Pre_Order_Traverse(root.leftChild);
			this.Pre_Order_Traverse(root.rightChild);
		}
		private void In_Order_Traverse(BinaryNode root)
		{
			if (root == null) return; //The base condition.
			this.In_Order_Traverse(root.leftChild);
			Console.Write(root.value + " ");
			this.In_Order_Traverse(root.rightChild);
		}

		private void Post_Order_Traverse(BinaryNode root)
		{
			if (root == null) return; //The base condition.
			this.Post_Order_Traverse(root.leftChild);
			this.Post_Order_Traverse(root.rightChild);
			Console.Write(root.value + " ");
		}


		public void print()
		{
			Root.Print(5, 5);
		}		

	}
}
