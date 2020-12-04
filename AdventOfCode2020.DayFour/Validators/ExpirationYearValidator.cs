using AdventOfCode2020.DayFour.Validators.Abstracts;

namespace AdventOfCode2020.DayFour.Validators
{
	public class ExpirationYearValidator : YearValidator
	{
		public override int EarliestDate => 2020;
		public override string Field => "eyr";
		public override int LatestDate => 2030;
	}
}
