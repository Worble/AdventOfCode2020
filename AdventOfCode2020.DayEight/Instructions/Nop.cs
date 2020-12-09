using AdventOfCode2020.DayEight.Instructions.Interface;

namespace AdventOfCode2020.DayEight.Instructions
{
	public class Nop : IOperationInstruction
	{
		public string Operator => "nop";

		public State PerformOperation(State state, int input)
		{
			return state;
		}
	}
}
