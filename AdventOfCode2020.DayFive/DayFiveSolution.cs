using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.DayFive
{
	public class DayFiveSolution
	{
		public int CalculateBinaryPartition(string input, int count, char highCharacter, char lowCharacter)
		{
			highCharacter = char.ToUpper(highCharacter);
			lowCharacter = char.ToUpper(lowCharacter);
			var lowest = 0;
			var highest = count;
			foreach (var character in input.ToUpper())
			{
				if (character == highCharacter)
				{
					if (highest - lowest == 1)
					{
						return highest;
					}
					lowest += (highest + 1 - lowest) / 2;
					continue;
				}

				if (character == lowCharacter)
				{
					if (highest - lowest == 1)
					{
						return lowest;
					}
					highest -= (highest + 1 - lowest) / 2;
					continue;
				}

				throw new ArgumentOutOfRangeException(nameof(character));
			}
			throw new Exception();
		}

		public int CalculateHighestId(List<string> input)
		{
			return input.Max(e => CalculateSeatId(e));
		}

		public int CalculateSeatId(string input)
		{
			var row = CalculateBinaryPartition(input[..7], 127, 'B', 'F');
			var column = CalculateBinaryPartition(input[^3..], 7, 'R', 'L');
			return (row * 8) + column;
		}

		public int FindMissingId(List<string> input)
		{
			var sortedIds = input.Select(e => CalculateSeatId(e)).OrderBy(e => e).ToList();
			var previousId = sortedIds[0];
			foreach (var id in sortedIds.GetRange(1, sortedIds.Count - 1))
			{
				if (id - 1 != previousId)
				{
					return id - 1;
				}
				previousId = id;
			}
			throw new Exception();
		}
	}
}
