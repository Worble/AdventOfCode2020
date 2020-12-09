using AdventOfCode2020.DayEight.Instructions.Interface;

namespace AdventOfCode2020.DayEight.Instructions
{
	public class Jmp : IOperationInstruction
	{
		public string Operator => "jmp";

		public State PerformOperation(State state, int input)
		{
			state.CurrentIndex += input - 1;
			return state;
		}
	}
}
