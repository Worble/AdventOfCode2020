using AdventOfCode2020.DayFour.Validators;
using Xunit;

namespace AdventOfCode2020.Test.DayFourTest.Validators
{
	public class HairColorValidatorTests
	{
		[Theory]
		[InlineData("#123abc", true)]
		[InlineData("#123abz", false)]
		[InlineData("123abc", false)]
		public void ValidateField_ReturnsCorrectValidationStatus(string input, bool expected)
		{
			//arrange
			var validator = new HairColorValidator();

			//act
			var actual = validator.FieldIsValid(input);

			//assert
			Assert.Equal(expected, actual);
		}
	}
}
