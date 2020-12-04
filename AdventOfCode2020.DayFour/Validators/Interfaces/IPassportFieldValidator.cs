namespace AdventOfCode2020.DayFour.Validators.Interfaces
{
	public interface IPassportFieldValidator
	{
		public string Field { get; }

		public bool FieldIsValid(string fieldValue);
	}
}
