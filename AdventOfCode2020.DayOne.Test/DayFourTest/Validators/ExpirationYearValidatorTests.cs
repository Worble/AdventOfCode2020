using AdventOfCode2020.DayFour.Validators;
using Xunit;

namespace AdventOfCode2020.Test.DayFourTest.Validators
{
	public class ExpirationYearValidatorTests
	{
		[Theory]
		[InlineData("2020", true)]
		[InlineData("2019", false)]
		[InlineData("2030", true)]
		[InlineData("2031", false)]
		[InlineData("2025", true)]
		public void ValidateField_ReturnsCorrectValidationStatus(string input, bool expected)
		{
			//arrange
			var validator = new ExpirationYearValidator();

			//act
			var actual = validator.FieldIsValid(input);

			//assert
			Assert.Equal(expected, actual);
		}
	}
}
