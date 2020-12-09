using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.DaySeven
{
	public class DaySevenSolution
	{
		private readonly Dictionary<string, List<BagResult>> _bagRules;

		public DaySevenSolution(string input)
		{
			var inputSplit = input.ToLower().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
			_bagRules = new Dictionary<string, List<BagResult>>();
			foreach (var item in inputSplit)
			{
				var rules = item.Split(new[] { "contain" }, StringSplitOptions.None);
				var key = rules[0].Trim();
				var result = new List<BagResult>();
				foreach (var rule in rules[1].Split(new[] { ',', '.' }, StringSplitOptions.RemoveEmptyEntries))
				{
					var trim = rule.Trim();
					if (string.Equals(trim, "no other bags", StringComparison.OrdinalIgnoreCase))
					{
						continue;
					}
					var bag = trim[1..].Trim();
					if (!bag.EndsWith('s'))
					{
						bag = $"{bag}s";
					}
					result.Add(new BagResult
					{
						Bag = bag,
						Amount = int.Parse(trim[0].ToString())
					});
				}
				_bagRules.Add(key, result);
			}
		}

		public List<string> FindHoldingBag(string bag)
		{
			var result = new List<string>();
			foreach (var rule in _bagRules)
			{
				if (FindBag(rule.Key, bag))
				{
					result.Add(bag);
				}
			}
			return result;
		}

		public int FindTotalBagCount(string bag)
		{
			var rule = _bagRules.FirstOrDefault(e => e.Key == bag);
			return CalculateTotal(rule.Value);
		}

		private int CalculateTotal(List<BagResult> bagResults)
		{
			var total = 0;
			foreach (var rules in bagResults)
			{
				total += rules.Amount;
				total += rules.Amount * CalculateTotal(_bagRules.FirstOrDefault(e => e.Key == rules.Bag).Value);
			}
			return total;
		}

		private bool FindBag(string currentBag, string bagToLookFor)
		{
			_bagRules.TryGetValue(currentBag, out var rules);
			if (rules.Any(e => e.Bag == bagToLookFor))
			{
				return true;
			}
			foreach (var newBag in rules)
			{
				if (FindBag(newBag.Bag, bagToLookFor))
				{
					return true;
				}
			}
			return false;
		}
	}
}
