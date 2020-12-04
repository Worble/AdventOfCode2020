using AdventOfCode2020.DayFour.Validators;
using Xunit;

namespace AdventOfCode2020.Test.DayFourTest.Validators
{
	public class HeightValidatorTests
	{
		[Theory]
		[InlineData("60in", true)]
		[InlineData("190cm", true)]
		[InlineData("190in", false)]
		[InlineData("190", false)]
		public void ValidateField_ReturnsCorrectValidationStatus(string input, bool expected)
		{
			//arrange
			var validator = new HeightValidator();

			//act
			var actual = validator.FieldIsValid(input);

			//assert
			Assert.Equal(expected, actual);
		}
	}
}
