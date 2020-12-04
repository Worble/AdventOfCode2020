using AdventOfCode2020.DayFour.Validators.Interfaces;

namespace AdventOfCode2020.DayFour.Validators
{
	public class HeightValidator : IPassportFieldValidator
	{
		public string Field => "hgt";

		public bool FieldIsValid(string fieldValue)
		{
			var unit = fieldValue[^2..];
			if (!int.TryParse(fieldValue[..^2], out var height))
			{
				return false;
			}
			return unit switch
			{
				"cm" => height >= 150 && height <= 193,
				"in" => height >= 59 && height <= 76,
				_ => false
			};
		}
	}
}
