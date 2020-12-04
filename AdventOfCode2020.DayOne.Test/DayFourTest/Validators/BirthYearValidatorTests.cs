using AdventOfCode2020.DayFour.Validators;
using Xunit;

namespace AdventOfCode2020.Test.DayFourTest.Validators
{
	public class BirthYearValidatorTests
	{
		[Theory]
		[InlineData("2002", true)]
		[InlineData("2003", false)]
		[InlineData("1920", true)]
		[InlineData("1919", false)]
		[InlineData("1950", true)]
		public void ValidateField_ReturnsCorrectValidationStatus(string input, bool expected)
		{
			//arrange
			var validator = new BirthYearValidator();

			//act
			var actual = validator.FieldIsValid(input);

			//assert
			Assert.Equal(expected, actual);
		}
	}
}
