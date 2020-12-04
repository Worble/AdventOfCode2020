using AdventOfCode2020.DayFour.Validators;
using Xunit;

namespace AdventOfCode2020.Test.DayFourTest.Validators
{
	public class IssueYearValidatorTests
	{
		[Theory]
		[InlineData("2010", true)]
		[InlineData("2009", false)]
		[InlineData("2020", true)]
		[InlineData("2021", false)]
		[InlineData("2015", true)]
		public void ValidateField_ReturnsCorrectValidationStatus(string input, bool expected)
		{
			//arrange
			var validator = new IssueYearValidator();

			//act
			var actual = validator.FieldIsValid(input);

			//assert
			Assert.Equal(expected, actual);
		}
	}
}
