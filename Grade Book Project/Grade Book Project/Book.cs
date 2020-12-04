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
			if (grade <= 100.00 && grade >= 0.00)
			{
				grades.Add(grade);
			}
			else 
			{
				throw new ArgumentException($"Invalid {nameof(grade)}");
			}
		}
		public void AddLetterGrade(char letter)
		{
			switch(letter) 
			{
				case 'A':
					AddGrade(90);
					break;
				case 'B':
					AddGrade(80);
					break;
				case 'C':
					AddGrade(70);
					break;
				case 'D':
					AddGrade(60);
					break;
				default:
					AddGrade(0);
					break;
			}
		}
		public Statistics ComputeStatistics() 
		{
			var result = new Statistics();
			result.Average = 0.0;
			result.High = double.MinValue;
			result.Low = double.MaxValue;

			for(int index = 0; index < grades.Count; index ++)
			{
				if (grades[index] == 42.1)
				{
					continue;
				}

				result.High = Math.Max(grades[index], result.High);
				result.Low = Math.Min(grades[index], result.Low);
				result.Average += grades[index];
			} 

			result.Average /= grades.Count;

			switch (result.Average) 
			{
				case var d when d >= 90.00:
					result.Letter = 'A';
					break;
				case var d when d >= 80.00:
					result.Letter = 'B';
					break;
				case var d when d >= 70.00:
					result.Letter = 'C';
					break;
				default:
					result.Letter = 'F';
					break;
			}
			return result;
		}

		private double GradeAverage()
		{
			return (grades.Sum() / grades.Count);
		}

		private List<double> grades;
		public string Name;
	

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