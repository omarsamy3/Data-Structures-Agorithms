using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree
{
	public class BinaryNode
	{
		public int value;
		public BinaryNode leftChild;
		public BinaryNode rightChild;

		public BinaryNode(int value)
		{
			this.value = value;
		}

		public override string ToString()
		{
			return "Node " + value;
		}
	}
}
