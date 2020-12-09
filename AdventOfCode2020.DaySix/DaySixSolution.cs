using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.DaySix
{
	public class DaySixSolution
	{
		private readonly List<GroupAnswers> _questionsAnsweredYes;

		public DaySixSolution(string input)
		{
			var inputSplit = input.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			var current = new GroupAnswers();
			_questionsAnsweredYes = new List<GroupAnswers>();
			foreach (var answers in inputSplit)
			{
				answers.Trim();
				if (string.IsNullOrWhiteSpace(answers))
				{
					if (current.Answers.Count > 0)
					{
						_questionsAnsweredYes.Add(current);
						current = new GroupAnswers();
					}
					continue;
				}
				current.PeopleInGroup++;
				foreach (var character in answers)
				{
					if (current.Answers.ContainsKey(character))
					{
						current.Answers[character]++;
						continue;
					}
					current.Answers.Add(character, 1);
				}
			}
			if (current.Answers.Count > 0)
			{
				_questionsAnsweredYes.Add(current);
			}
		}

		public int SumGroupYes()
		{
			var total = 0;
			foreach (var item in _questionsAnsweredYes)
			{
				var filtered = item.Answers.Where(e => e.Value == item.PeopleInGroup);
				total += filtered.Count();
			}
			return total;
		}

		public int SumIndividualYes()
		{
			return _questionsAnsweredYes.Select(e => e.Answers.Count).Sum();
		}
	}
}
