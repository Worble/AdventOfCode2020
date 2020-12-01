using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.DayOne
{
	public class DayOne
	{
		private readonly List<int> _expenseReport;

		public DayOne(List<int> expenseReport)
		{
			_expenseReport = expenseReport;
		}

		public int MultiplyValuesFromSumTarget(int sumTarget, int amountToSum)
		{
			var multiply = Loop(sumTarget, 0, _expenseReport.Count - amountToSum + 1, amountToSum, new List<int>());
			if (!multiply.HasValue)
			{
				throw new Exception("No numbers matched sum target.");
			}
			return multiply.Value;
		}

		private int? Loop(int sumTarget, int startIndex, int endIndex, int sumAmount, List<int> input)
		{
			for (var i = startIndex; i < endIndex; i++)
			{
				input.Add(_expenseReport[i]);
				if (startIndex + 1 >= sumAmount)
				{
					if (input.Sum() == sumTarget)
					{
						return input.Aggregate((a, x) => a * x);
					}
				}
				else
				{
					var x = Loop(sumTarget, startIndex + 1, endIndex + 1, sumAmount, input);
					if (x.HasValue)
					{
						return x;
					}
				}
				input.Remove(_expenseReport[i]);
			}
			return null;
		}
	}
}
