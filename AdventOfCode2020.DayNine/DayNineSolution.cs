using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.DayNine
{
	public class DayNineSolution
	{
		private readonly List<long> _input;
		private readonly int _preamble;

		public DayNineSolution(string input, int preamble)
		{
			_input = input
				.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)
				.Select(e => long.Parse(e))
				.ToList();
			_preamble = preamble;
		}

		public long FindEncryptionWeakness()
		{
			var numberToSum = FindFirstNonMatchingNumber();
			for (var i = 0; i < _input.Count - 1; i++)
			{
				for (var j = 1; j < _input.Count - i; j++)
				{
					var range = _input.GetRange(i, j);
					if (range.Sum() == numberToSum)
					{
						return range.Min() + range.Max();
					}
				}
			}
			throw new Exception();
		}

		public long FindFirstNonMatchingNumber()
		{
			for (var i = _preamble; i < _input.Count; i++)
			{
				var value = _input[i];
				var list = _input.GetRange(i - _preamble, _preamble);
				var doesAdd = false;
				for (var j = 0; j < list.Count - 1 && !doesAdd; j++)
				{
					for (var k = j + 1; k < list.Count && !doesAdd; k++)
					{
						var one = list[j];
						var two = list[k];
						if (one + two == value)
						{
							doesAdd = true;
						}
					}
				}
				if (!doesAdd)
				{
					return value;
				}
			}
			throw new Exception();
		}
	}
}
