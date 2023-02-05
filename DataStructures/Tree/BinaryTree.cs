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

		/// <summary>
		/// Traverse the tree and print nodes with pre_order approach.
		/// </summary>
		public void Pre_Order_Traverse()
		{
			Pre_Order_Traverse(Root);
			Console.WriteLine();
		}

		/// <summary>
		/// Traverse the tree and print nodes with in_order approach.
		/// </summary>
		public void In_Order_Traverse()
		{
			In_Order_Traverse(Root);
			Console.WriteLine();
		}

		/// <summary>
		/// Traverse the tree and print nodes with post_order approach.
		/// </summary>
		public void Post_Order_Traverse()
		{
			Post_Order_Traverse(Root);
			Console.WriteLine();
		}

		/// <summary>
		/// Get the max height of the tree.
		/// </summary>
		/// <param name="root"></param>
		/// <returns>The hight of the tree.</returns>
		public int height()
		{
			return height(Root);
		}

		public int MinValue()
		{
			return MinValue(root);
		}
		public int MaxValue()
		{
			return MaxValue(root);
		}

		public int MinValueBST()
		{
			if(root == null) throw new NullReferenceException();

			var current = root;
			var last = current;
			
			while(current != null)
			{
				last = current;
				current = current.leftChild;
			}
			return last.value;
		}
		public int MaxValueBST()
		{
			if (root == null) throw new NullReferenceException();

			var current = root;
			var last = current;

			while (current != null)
			{
				last = current;
				current = current.rightChild;
			}
			return last.value;
		}

		#region Private Methods
		private bool IsLeaf(BinaryNode root)
		{			
			return root.leftChild == null && root.rightChild == null;
		}
			
		/// <summary>
		/// Find the minimun value in the tree.
		/// </summary>
		/// <param name="root"></param>
		/// <returns>The minimum value.</returns>
		private int MinValue(BinaryNode root)
		{
			if (root == null) return 1000 ;
			if (IsLeaf(root)) return root.value;
			var MinLeft = MinValue(root.leftChild);
			var MinRight = MinValue(root.rightChild);
			int LeftRightMin = Math.Min(MinLeft, MinRight);
			return Math.Min(LeftRightMin, root.value);
		}

		/// <summary>
		/// Find the maximum value in the tree.
		/// </summary>
		/// <param name="root"></param>
		/// <returns>The maximum value.</returns>
		private int MaxValue(BinaryNode root)
		{
			if (root == null) return -1;
			if (IsLeaf(root)) return root.value;
			var MaxLeft = MaxValue(root.leftChild);
			var MaxRight = MaxValue(root.rightChild);
			int LeftRightMax = Math.Max(MaxLeft, MaxRight);
			return Math.Max(LeftRightMax, root.value);
		}
		/// <summary>
		/// Get the max height of the tree.
		/// </summary>
		/// <param name="root"></param>
		/// <returns>The hight of the tree.</returns>
		private int height(BinaryNode root)
		{
			if (root == null) return -1;
			if (IsLeaf(root)) return 0;
				
			return 1 + Math.Max(
								height(root.leftChild),
								height(root.rightChild));
		}

		/// <summary>
		/// Traverse the tree and print nodes with pre_order approach,
		/// By dealing with the root field to start traversing.
		/// </summary>
		private void Pre_Order_Traverse(BinaryNode root)
		{
			if (root == null) return; //The base condition.
			Console.Write(root.value + " ");
			this.Pre_Order_Traverse(root.leftChild);
			this.Pre_Order_Traverse(root.rightChild);
		}

		/// <summary>
		/// Traverse the tree and print nodes with in_order approach,
		/// By dealing with the root field to start traversing.
		/// </summary>
		private void In_Order_Traverse(BinaryNode root)
		{
			if (root == null) return; //The base condition.
			this.In_Order_Traverse(root.leftChild);
			Console.Write(root.value + " ");
			this.In_Order_Traverse(root.rightChild);
		}

		/// <summary>
		/// Traverse the tree and print nodes with post_order approach,
		/// By dealing with the root field to start traversing.
		/// </summary>
		private void Post_Order_Traverse(BinaryNode root)
		{
			if (root == null) return; //The base condition.
			this.Post_Order_Traverse(root.leftChild);
			this.Post_Order_Traverse(root.rightChild);
			Console.Write(root.value + " ");
		} 
		#endregion


		/// <summary>
		/// Print the tree in a nice graphical shape.
		/// </summary>
		public void print()
		{
			Root.Print(5, 5);
		}		

	}
}
