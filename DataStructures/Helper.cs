using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
	internal class Helper
	{
		public static void print(string title)
		{
			Console.WriteLine($"{new string('-', title.Length * 3)}");
			Console.WriteLine($"{new string(' ', title.Length - 2)}|{title}|");
			Console.WriteLine($"{new string('-', title.Length * 3)}");
		}

		public static void print(string title, string description)
		{
			Console.WriteLine($"{new string('-', description.Length * 2)}");
			Console.WriteLine($"{new string(' ', (description.Length - (title.Length + 2) / 2))}|{title}|");
			Console.WriteLine($"{new string(' ', description.Length / 2)}{description}");
			Console.WriteLine($"{new string('-', description.Length * 2)}\n");
		}

		public static void PrintList<T>(List<T> list)
		{
			Console.Write("[ ");
			foreach (T item in list)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine("]");
		}
	}
}
