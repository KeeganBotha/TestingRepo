using System;
using System.Collections.Generic;

namespace Grade_Book_Project
{
	class Program
	{
		static void Main(string[] args)
		{
			var grades = new List<double>() { 12.7, 10.3, 6.11 };
			grades.Add(56.1);
			var result = 0.0;
			foreach (var item in grades) 
			{
				result += item;
			}
			result /= grades.Count;

			Console.WriteLine($"The average grade is {result:N1}");
		}
	}
}
