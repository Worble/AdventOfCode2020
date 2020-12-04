using AdventOfCode2020.DayFour.Validators.Interfaces;

namespace AdventOfCode2020.DayFour.Validators.Abstracts
{
	public abstract class YearValidator : IPassportFieldValidator
	{
		public abstract int EarliestDate { get; }
		public abstract string Field { get; }
		public abstract int LatestDate { get; }

		public bool FieldIsValid(string fieldValue)
		{
			var year = int.Parse(fieldValue.Trim());
			return year >= EarliestDate && year <= LatestDate;
		}
	}
}
