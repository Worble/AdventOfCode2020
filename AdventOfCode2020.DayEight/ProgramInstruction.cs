using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.DayEight.Instructions;
using AdventOfCode2020.DayEight.Instructions.Interface;

namespace AdventOfCode2020.DayEight
{

	public class ProgramInstruction
	{
		public int Argument { get; set; }
		public string Operation { get; set; } = string.Empty;
	}
}
