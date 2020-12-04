using System.Collections.Generic;
using AdventOfCode2020.DayFour.Validators.Interfaces;

namespace AdventOfCode2020.DayFour.Validators
{
	public class EyeColorValidator : IPassportFieldValidator
	{
		public string Field => "ecl";

		public bool FieldIsValid(string fieldValue)
		{
			var validStrings = new List<string>
			{
				"amb", "blu", "brn", "gry", "grn", "hzl", "oth"
			};
			return validStrings.Contains(fieldValue);
		}
	}
}
