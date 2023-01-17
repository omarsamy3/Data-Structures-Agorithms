﻿using DataStructures;
using System;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
		{
			#region TryHash
			TryHashTable();
			#endregion


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