using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook 
{
	class Book 
	{
		public Book(string name) 
		{
			grades = new List<double>();
			this.name = name;
		}

		public void AddGrade(double grade) 
		{
			highestGrade = Math.Max(grade, highestGrade);
			lowestGrade = Math.Min(grade, lowestGrade);
			grades.Add(grade);
		}
		public void ComputeStatistics() 
		{
			HighestGrade();
			LowestGrade();
			GradeAverage();
		}

		private void HighestGrade()
		{
			if (highestGrade > 0.0)
			{
				Console.WriteLine($"The highest grade is {highestGrade:N1}");
			}
			else
			{
				Console.WriteLine("You have not yet entered a grade into the grade book.");
			}
		}
		private void LowestGrade()
		{
			if (lowestGrade <= 100)
			{
				Console.WriteLine($"The lowest grade is {lowestGrade:N1}");
			}
			else
			{
				Console.WriteLine("You have not yet entered a grade into the grade book.");
			}
		}
		private void GradeAverage() 
		{
			Console.WriteLine($"The average grade is {(grades.Sum() / grades.Count):N1}");
		}

		private List<double> grades;
		private string name;
		private double highestGrade = 0.0;
		private double lowestGrade = 101.0;
	}
}