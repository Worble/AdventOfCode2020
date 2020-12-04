using System.Text.RegularExpressions;
using AdventOfCode2020.DayFour.Validators.Interfaces;

namespace AdventOfCode2020.DayFour.Validators
{
	public class PassportIdValidator : IPassportFieldValidator
	{
		public string Field => "pid";

		public bool FieldIsValid(string fieldValue)
		{
			return Regex.IsMatch(fieldValue, "^[0-9]{9}$");
		}
	}
}
