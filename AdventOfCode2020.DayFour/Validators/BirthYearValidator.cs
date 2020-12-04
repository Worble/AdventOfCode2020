using AdventOfCode2020.DayFour.Validators.Abstracts;

namespace AdventOfCode2020.DayFour.Validators
{
	public class BirthYearValidator : YearValidator
	{
		public override int EarliestDate => 1920;
		public override string Field => "byr";
		public override int LatestDate => 2002;
	}
}
