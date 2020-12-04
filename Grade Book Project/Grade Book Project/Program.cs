using GradeBook;
using System;
using System.Collections.Generic;

namespace GradeBook
{
	class Program
	{
		static void Main(string[] args)
		{
			var book = new Book("Book One");

			do
			{
				var input = Console.ReadLine();
				if (input == "q" || input == "Q")
				{
					break;
				}
				try
				{
					var grade = double.Parse(input);
					book.AddGrade(grade);
				}
				catch(Exception err)
				{
					Console.WriteLine(err.Message);
				}
				
			} while(1 < 100);

			var stats = book.ComputeStatistics();

			Console.WriteLine($"The lowest grade is {stats.Low}");
			Console.WriteLine($"The highest grade is {stats.High}");
			Console.WriteLine($"The average grade is {stats.Average:N1}");
			Console.WriteLine($"The letter grade is {stats.Letter}");
		}
	}
}
