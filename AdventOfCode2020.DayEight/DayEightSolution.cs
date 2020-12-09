using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.DayEight.Instructions;
using AdventOfCode2020.DayEight.Instructions.Interface;

namespace AdventOfCode2020.DayEight
{
	public class DayEightSolution
	{
		private readonly List<IOperationInstruction> _operationInstructions;
		private readonly List<ProgramInstruction> _program;

		public DayEightSolution(string input)
		{
			var inputSplit = input.ToLower().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
			_program = inputSplit.Select(e =>
			{
				var split = e.Trim().Split(' ');
				return new ProgramInstruction
				{
					Operation = split[0],
					Argument = int.Parse(split[1])
				};
			}).ToList();
			_operationInstructions = new List<IOperationInstruction>
			{
				new Acc(),
				new Jmp(),
				new Nop()
			};
		}

		public int AccumulatorValueAfterTermination()
		{
			for (var i = 0; i < _program.Count; i++)
			{
				if (_program[i].Operation != "nop" && _program[i].Operation != "jmp")
				{
					continue;
				}

				_program[i].Operation = _program[i].Operation == "nop" ? "jmp" : "nop";
				if (!DoesLoop(out var state))
				{
					return state.Accumulator;
				}
				_program[i].Operation = _program[i].Operation == "nop" ? "jmp" : "nop";
			}
			throw new Exception();
		}

		public bool DoesLoop(out State state)
		{
			state = new State();
			var visitedIndexes = new List<int>();
			while (state.CurrentIndex < _program.Count)
			{
				if (visitedIndexes.Contains(state.CurrentIndex))
				{
					return true;
				}
				visitedIndexes.Add(state.CurrentIndex);
				var instruction = _program[state.CurrentIndex];
				var operation = _operationInstructions.Find(e => e.Operator == instruction.Operation);
				operation.PerformOperation(state, instruction.Argument);
				state.CurrentIndex++;
			}
			return false;
		}
	}
}
