using System.Text.RegularExpressions;
using AdventOfCode2020.DayFour.Validators.Interfaces;

namespace AdventOfCode2020.DayFour.Validators
{
	public class HairColorValidator : IPassportFieldValidator
	{
		public string Field => "hcl";

		public bool FieldIsValid(string fieldValue)
		{
			return Regex.IsMatch(fieldValue, "^#[a-f0-9]{6}$");
		}
	}
}
