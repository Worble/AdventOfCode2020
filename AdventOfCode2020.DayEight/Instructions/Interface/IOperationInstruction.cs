namespace AdventOfCode2020.DayEight.Instructions.Interface
{
	public interface IOperationInstruction
	{
		public string Operator { get; }

		public State PerformOperation(State state, int input);
	}
}
