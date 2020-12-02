using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2020.Con.DayOneCon;

namespace AdventOfCode2020.Con
{
	internal static class Program
	{
		private static bool ExitCommand(string? input)
		{
			var exitCodes = new List<string> { "quit", "exit", "x", "q" };
			return exitCodes.Contains(input.ToLower());
		}

		private static void Main()
		{
			Console.WriteLine("#######################");
			Console.WriteLine("#                     #");
			Console.WriteLine("# ADVENT OF CODE 2020 #");
			Console.WriteLine("#                     #");
			Console.WriteLine("#######################");
			Console.WriteLine();
			var run = true;
			while (run)
			{
				Console.WriteLine("Please input a day, or type quit to exit.");
				var input = Console.ReadLine();
				if (input == null)
				{
					continue;
				}
				if (ExitCommand(input))
				{
					run = false;
					continue;
				}
				if (!int.TryParse(input, out var day))
				{
					continue;
				}
				switch (day)
				{
					case 1:
						PrintTitle(day);
						DayOneConsole.Run();
						continue;
					default:
						run = true;
						Console.WriteLine("Day not yet complete");
						continue;
				}
			}
		}

		private static void PrintTitle(int day)
		{
			var dayString = day.ToString();
			var sb = new StringBuilder("########");
			for (var i = 0; i < dayString.Length; i++)
			{
				sb.Append('#');
			}
			var hashes = sb.ToString();
			Console.WriteLine(hashes);
			Console.WriteLine($"# DAY {dayString} #");
			Console.WriteLine(hashes);
		}
	}
}
