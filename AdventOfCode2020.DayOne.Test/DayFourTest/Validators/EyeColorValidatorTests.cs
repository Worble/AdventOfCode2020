using AdventOfCode2020.DayFour.Validators;
using Xunit;

namespace AdventOfCode2020.Test.DayFourTest.Validators
{
	public class EyeColorValidatorTests
	{
		[Theory]
		[InlineData("brn", true)]
		[InlineData("wat", false)]
		public void ValidateField_ReturnsCorrectValidationStatus(string input, bool expected)
		{
			//arrange
			var validator = new EyeColorValidator();

			//act
			var actual = validator.FieldIsValid(input);

			//assert
			Assert.Equal(expected, actual);
		}
	}
}
