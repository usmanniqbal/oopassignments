using System;

namespace OOPAssignments
{
	class Program
	{
		static void Main(string[] args)
		{
			new MovieData("Inception", "Christopher Nolan", 2010, 120, "1 Million", "2 Millions").Display();
			Console.WriteLine();
			new MovieData("Pursuit of Happyness", "Christopher Nolan", 2010, 120, "1 Million", "2 Millions").Display();
			Console.ReadLine();
		}
	}

	public class MovieData
	{
		private readonly string _title;
		private readonly string _director;
		private readonly int _yearReleased;
		private readonly int _runningTime;
		private readonly string _productionCost;
		private readonly string _firstYearRevenue;
		public MovieData(string title, string director, int yearReleased, int runningTime, string productionCost, string firstYearRevenue)
		{
			_title = title;
			_director = director;
			_yearReleased = yearReleased;
			_runningTime = runningTime;
			_productionCost = productionCost;
			_firstYearRevenue = firstYearRevenue;
		}

		public void Display()
		{
			Console.WriteLine("Title: {0}", _title);
			Console.WriteLine("Director: {0}", _director);
			Console.WriteLine("Year Released: {0}", _yearReleased);
			Console.WriteLine("Running Time: {0}", _runningTime);
			Console.WriteLine("Production Cost: {0}", _productionCost);
			Console.WriteLine("First Year Revenue: {0}", _firstYearRevenue);
		}
	}
}
