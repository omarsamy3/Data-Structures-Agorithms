using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
	public static class StackOperations
	{
		#region Fields
		private static char[] leftBrackets = new char[] { '(', '[', '{', '<' };
		private static char[] rightBrackets = new char[] { ')', ']', '}', '>' };
		#endregion

		public static string reverse(string input)
		{
			if (input == null) throw new ArgumentNullException(input);
			if (input == "" || input.Length == 1) return input;

			var result = new StringBuilder();
			var stack = new Stack<char>();

			foreach (var item in input)
			{
				stack.Push(item);
			}

			for (int i = 0; i < input.Length; i++)
			{
				result.Append(stack.Pop());
			}

			return result.ToString();
		}

		public static bool isBalanced(string input)
		{
			var stack = new Stack<char>();
			int count = 0;
			foreach (var c in input)
			{
				if (isLeftBracket(c))
					stack.Push(c);

				else if (isRightBracket(c))
				{
					if (stack.Count == 0)
						return false;

					var top = stack.Pop();
					if (!isBracketsMatch(c, top)) return false;
				}

			}
			return stack.Count == 0;
		}


		#region Private Methods

		private static bool isLeftBracket(char c)
		{
			return leftBrackets.Contains(c);
		}
		
		private static bool isRightBracket(char c)
		{
			return rightBrackets.Contains(c);
		}
		private static bool isBracketsMatch(char c, char top)
		{
			return indexOf(c, rightBrackets) == indexOf(top, leftBrackets);
		}

		private static int indexOf(char c, char[] arr)
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
