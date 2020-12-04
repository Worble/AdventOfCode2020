using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AdventOfCode2020.DayThree
{
	public class DayThreeSolution
	{
		private readonly char[,] _map;

		public DayThreeSolution(string mapString)
		{
			var split = mapString
				.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None)
				.Where(e => !string.IsNullOrWhiteSpace(e))
				.Select(e => e.Trim())
				.ToList();
			_map = new char[split.Count, split[0].Length];
			for (var y = 0; y < split.Count; y++)
			{
				var line = split[y];
				for (var x = 0; x < line.Length; x++)
				{
					_map[y, x] = line[x];
				}
			}
		}

		public int CalculateTreeEncounters(Point movementDirection)
		{
			var encounters = 0;
			var currentPosition = new Point(0, 0);
			while (true)
			{
				var newY = currentPosition.Y + movementDirection.Y;
				if (newY >= _map.GetLength(0))
				{
					break;
				}
				currentPosition.Y = newY;

				currentPosition.X = CalculateX(movementDirection.X, currentPosition.X);

				if (HitTree(currentPosition))
				{
					encounters++;
				}
			}
			return encounters;
		}

		public int MultiplyDifferentRuns(List<Point> directions)
		{
			return directions
				.Select(direction => CalculateTreeEncounters(direction))
				.Aggregate((first, second) => first * second);
		}

		private int CalculateX(int x, int currX)
		{
			var newX = currX + x;
			var xLength = _map.GetLength(1);
			if (newX >= xLength)
			{
				return newX % xLength;
			}
			else
			{
				return newX;
			}
		}

		private bool HitTree(Point position)
		{
			return (_map[position.Y, position.X]) switch
			{
				'#' => true,
				_ => false,
			};
		}
	}
}
