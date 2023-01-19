using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
 

namespace DataStructures.Tree
{	
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
				if (value == current.value)  return true;
				else if (value <  current.value)  current = current.leftChild;
				else if (value >  current.value)  current = current.rightChild;
			}
			return false;
		}

		public void print()
		{
			Root.Print(5, 5);
		}		


	}
}
