using AdventOfCode2020.DayFour.Validators.Abstracts;

namespace AdventOfCode2020.DayFour.Validators
{
	public class IssueYearValidator : YearValidator
	{
		public override int EarliestDate => 2010;
		public override string Field => "iyr";
		public override int LatestDate => 2020;
	}
}
