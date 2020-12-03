using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
	public class Book 
	{
		public Book(string name) 
		{
			grades = new List<double>();
			Name = name;
		}

		public void AddGrade(double grade) 
		{
			highestGrade = Math.Max(grade, highestGrade);
			lowestGrade = Math.Min(grade, lowestGrade);
			grades.Add(grade);
		}
		public Statistics ComputeStatistics() 
		{
			var result = new Statistics();
			result.Average = GradeAverage();
			result.High = highestGrade;
			result.Low = lowestGrade;

			return result;
		}

		private double GradeAverage()
		{
			return (grades.Sum() / grades.Count);
		}

		private List<double> grades;
		public string Name;
		private double highestGrade = double.MinValue;
		private double lowestGrade = double.MaxValue;

		//private double HighestGrade()
		//{
		//	return highestGrade;
		//}
		//private double LowestGrade()
		//{
		//	return lowestGrade;
		//}
	}
}