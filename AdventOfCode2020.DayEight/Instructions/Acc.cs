using AdventOfCode2020.DayEight.Instructions.Interface;

namespace AdventOfCode2020.DayEight.Instructions
{
	public class Acc : IOperationInstruction
	{
		public string Operator => "acc";

		public State PerformOperation(State state, int input)
		{
			state.Accumulator += input;
			return state;
		}
	}
}
