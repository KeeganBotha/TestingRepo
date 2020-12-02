using GradeBook;
using System;
using System.Collections.Generic;

namespace Grade_Book_Project
{
	class Program
	{
		static void Main(string[] args)
		{
			var book = new Book("Book One");
			book.AddGrade(79.1);
			book.AddGrade(89.1);
			book.AddGrade(99.1);

			book.ComputeStatistics();
		}
	}
}
