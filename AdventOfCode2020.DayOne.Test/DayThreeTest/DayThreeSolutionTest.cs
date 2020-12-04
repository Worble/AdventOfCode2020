using System.Collections.Generic;
using System.Drawing;
using AdventOfCode2020.DayThree;
using Xunit;

namespace AdventOfCode2020.Test.DayThreeTest
{
	public class DayThreeSolutionTest
	{
		[Theory]
		[InlineData(@"..##.......
					#...#...#..
					.#....#..#.
					..#.#...#.#
					.#...##..#.
					..#.##.....
					.#.#.#....#
					.#........#
					#.##...#...
					#...##....#
					.#..#...#.#", 3, 1, 7)]
		[InlineData(@"........#.............#........
					...#....#...#....#.............
					.#..#...#............#.....#..#
					..#......#..##............###..
					..........#......#..#..#.......
					.#..#.......#.........#.#......
					.........#..#....##..#.##....#.
					..#....##...#..................
					##..........#.##...#....##..#..
					...#....#...#..............#...
					...........................#..#
					..##.##.#..................#...
					...#.##..#............#........
					........#.......#...#.....##.#.
					.##..........#......#.......#..
					...#..........#...#..#.......#.
					......#...#...#.##.......#.#...
					........#...#...#...##.........
					#..............#.#....#.......#
					..#..#..#.#....#...............
					.....#........#...#..........#.
					##......#...#..#.##.......#....
					..#.#.....#.#.............#.#.#
					#..#..##......##...#...........
					..#......#........#.....#......
					.....#.......#....#.#...#......
					...#........#...........#...#..
					.......#.#...........###....#..
					...#...........##....##........
					#....#..####....#.....#..#....#
					..........#...........#........
					...#.......#....#.#.........#..
					....#...#.......#..###.........
					......#......#..#......#..#....
					...#.....#............#..#.....
					...#.#.#.#..#.......#.....#....
					#....##...#.........#...##.....
					#..#.......#..#..#..#...##.....
					#.......#............#.....#...
					.#........##....##...#........#
					.....#...#.....................
					.......#........#..............
					.....#............#.#.#...#.#..
					.....##..#.............#.......
					..#.##..#........#..#...#......
					.........#.#....#...........#..
					.#.....#..#....#.....#...#.....
					....#.#................#.......
					...............##......#...#...
					.##...#...#.......##.#....#....
					............#........#.......#.
					......##.#.#...................
					.#.#..............#.......#....
					#.....#...#.......#..#...#.....
					.............#....#..#......#..
					........#...##................#
					.......#...#..#..##............
					..#..#...##...#..#.#.....#...#.
					.#.#...#.........#.#...........
					...###....#.......#...#........
					........#......##.#...#..##..#.
					.....................#.#.......
					.............#...........#...#.
					#..#..#.....#.#...#............
					...#....#.....#...........#....
					..##.....##...#......#..##.....
					#.....#.....###.#.....#....##..
					.#...........###...............
					..................#..##.#...#..
					................#....##.#......
					.#.#.#...#....#.........#..#.#.
					#.......#........##............
					.......##.#....#.#............#
					..........#..##.#....#.........
					........##..#....#.............
					.........#....#...........##...
					#.........#.#..#..#..........#.
					.....#........#......#.........
					....#.#.#...............#......
					.#..#..##...#.##..........#....
					..#....................#.#.....
					.........#....#...........#.#.#
					........#....##.##.............
					..#.....#.......#..#......#....
					#..........#.#.....#.#....#....
					........##.#.....#..#.....#.#..
					...................#...#....#.#
					............#..#....#...#...#..
					..............#.#.........#....
					...#..#..#.#..##..##...........
					.#...........................#.
					.#.......#...........#....#.#.#
					......#..#...#........#...##...
					.........#......#.#.......#...#
					...#..##................#......
					.............#.#..##....#.#....
					...............#..#......#.....
					.#......#.#.#....#........#....
					........#..#.##..#..#.........#
					...#....#.#...#..#.......#..#..
					..#...##.........#..#...#......
					...#...........#.............#.
					....#.....................#....
					.....#..#...............#.#...#
					....#..........#........#......
					..#....#........##..##.........
					...#....#..#.#.......#...#.....
					..#........#....#...##....#.#..
					.#...#........##.....#....###..
					#....#....##......#........#...
					.........#..#.#..........#....#
					....#...#.....#.......##.......
					..............#..........#.##..
					#...#..#..............#......#.
					.................#......##....#
					..#..##..#.......#..#.#......#.
					.............#........#.....#.#
					.#.##............#..#..........
					..#...#...........#..##........
					.#....#...#....#.......#.......
					...#.#..#..#..#....#.....#..#..
					....#..##..............#...#...
					#..........###......###........
					.##.##......#..#............#..
					.#...........#.#.....#...#.....
					#.#..#...#............#........
					.........#...#...#..........##.
					.......###..#..........#.......
					...........###.....#........#..
					.#.............#.....#......#..
					...#.....#....#.#.........##...
					....##..##...#.......##........
					......#....##.........#......#.
					..........#.....##..#.....#..#.
					..........####...#..#.........#
					.##....#..#.#...#.......#......
					...#.#.##.#.#...#....#.#.#.....
					.........#...##........##.....#
					..#........#..........##...##.#
					##...##..........#.#...........
					..............#......#.........
					........#.....#.#.......#......
					.#...#.....#....#.#..#.........
					.....#....................##...
					....#..................#.#...##
					.....#............#..##........
					#..........#....#.#.......##.#.
					....#..#.....................#.
					#..#....##.....#...............
					..#...#..#..##....#.#..........
					.......#......#.#.......#.....#
					...#.#.......#...#.##..........
					....#..........#....#.#.#......
					.......#..#..........#..##.....
					#......#......#...#......#...#.
					###..#....##......##........#..
					.#..........#.....#.......#.#..
					.......#.....#.....#.#.........
					..#...#....#...................
					..............#.##.............
					.#...#.......#.##...#.#.......#
					.......#......................#
					....#.#...#.#........#.........
					.#......#....#...#.............
					#.......#...###.....#.#.#..#...
					#....##.#...............##.....
					..#.......#..................#.
					.....####...............#......
					.##......#......#.#.......##.#.
					#......##..###....#....#......#
					.##.......##.##...#.##.........
					......##............#.......#..
					......#..#.....##.#............
					.#..........#.....##...........
					#.........#......#......##.#...
					.........#.......#..#......#.#.
					.........#.......#...........#.
					.#..##.#..................##...
					.............#.............#...
					.....##........#......##...##..
					..#..#.#.....#..#....#.........
					.....#....#.....#.....#........
					#......##.....#....#....#......
					#.................#..#.#......#
					.......#..#......#....#.#...#.#
					....#.........#..#..........#.#
					##......#............#...#...#.
					....##......#...#.....#....##..
					.#...##.........#..............
					......#.....................#..
					..#..........###....#..........
					#....#...#..#.............#....
					#........#.#......#....#.......
					.#...#.......#..#...#.#...#..#.
					................##.#.....#.....
					###.......#...#................
					...#.......#...#.#.....#.......
					..#.........#.....#.#.......#..
					......#.......................#
					#.....#.#..#....#.......#......
					...#....#..#....####...........
					.............#.....#...##......
					.......#.........#...#..#......
					.##..#.........#....#.#........
					....##...#.#...........#....#..
					.........................##....
					..###.......##....#.#.........#
					.#....#.#.#...........##....#..
					......#...#..#..#..#..#.......#
					..#....#.#.......#..#..#..#...#
					.....##...#.##....#.#...#......
					.........#..#....#..#..........
					.##..##.........#.#.....#......
					..........#...##...#.#...#.....
					#.##..#..#.............#.......
					...#...........#.......#......#
					.......#....#....#...##.......#
					..#.##........###..#......#....
					...#...........###......#..#..#
					.#.........#.#.........#.#.....
					##.......##.##.##......##......
					............#...#..........#...
					....................#..........
					...#..#...........#...#...#....
					.................#...#......###
					...#................#.#.##.....
					...............#........#......
					#.............##......#.#..#...
					..#.#.....#..#.##.....##...#...
					......#.........#......#.......
					#.......#......#....#........#.
					.#..##.....#.........#.........
					....##.##.#...#.........##.#...
					...............#..#..#..##.....
					.#..#...............###........
					.##............##..............
					...............#...##...#...#.#
					..#.#......#.#..#.............#
					#.#..#..##.........#.#.#...#...
					....##.#....................##.
					.........#..#.....#.....#..#..#
					....#......#......#.##....#....
					........###..#.............#..#
					##................#.........#..
					#.....#.......#....#...........
					..#.......#..#........#....#...
					..#.#.##..#.#...##........#.##.
					..#..........#............#....
					..........#...............##...
					..........###........#.#.......
					.....###..#.............#......
					##.............#...#.....#.....
					.....#......#....#........#.#..
					............#..#..............#
					.................#...........##
					#........#.........###.....#...
					..#.#..............##......#.#.
					.#...........#.........#..##..#
					...............................
					.#.....#..#....#....#......#...
					.#...#......#.#..#....#.......#
					......#.##.......#......#......
					......#..###..#................
					#..#.....#........##...#.......
					......##.........##....#...##..
					.#..........#.................#
					#..#.......#...............#...
					.........#..###....#.#.##.#....
					..#...#.##..##...............##
					.........#.....................
					.#....##...#......#....#.......
					............#..........#..#....
					...#......##....#....#........#
					.#...................#.........
					#.#........###....#..........#.
					.........#....#....#........##.
					.#....#..#.........#..#........
					...............#..#...#..#...##
					.........#....##....#......#...
					.#.............................
					...#........#...#.#...#.#..#...
					.....#..##...#.#...............
					#.....#....#.........#.........
					#...#...........##.........#...
					..##........#.#...#...#......#.
					...........#.....#...#.#.......
					......###....#.....#...........
					......##...#..........#....#.#.
					.......##..##..........#.......
					....#............#..#....##....
					..##...................#.#.....
					...#.#..#.#....................
					.#..##..#............##.###..#.
					#.#...#....#.#..........#.#....
					........#....#.....#...........
					..##....#...#.......#..........
					...........##.##....#..........
					.....#............#............
					.......#.............#....#....
					.................#......#......
					......##.......#....#..##...#..
					.#..#....#.....................
					...#.#.#...#......##...........
					##........##.#....#....#.......
					.......#.....#..#..#...#.##....
					#..........#....#.#..#..#..#...
					...##..............#...........
					.........#.....#.#....#.......#
					.........#....##..#..##..#.....
					.....#......................#..
					...###...#..#......#...........
					....#.....................#....
					...............................
					..#.....###.......#..#....#....
					#..........#.................#.
					......#.......###.......#..##..
					.............#.##..............
					......#..#.#..#...........#....
					...#....##.#...#..#.#...#....#.
					..................#...#....#.##
					......#.#....#.................
					......#.#.....#.....#..##......
					#..##...........#..#.....#.##..", 3, 1, 148)]
		public void CalculateTreeEncounters_ReturnsCorrectAmountOfTreeEncountersForGivenSlope(string mapString, int x, int y, int expected)
		{
			//arrange
			var dayThree = new DayThreeSolution(mapString);

			//act
			var result = dayThree.CalculateTreeEncounters(new Point(x, y));

			//assert
			Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData(@"..##.......
					#...#...#..
					.#....#..#.
					..#.#...#.#
					.#...##..#.
					..#.##.....
					.#.#.#....#
					.#........#
					#.##...#...
					#...##....#
					.#..#...#.#", 336)]
		[InlineData(@"........#.............#........
					...#....#...#....#.............
					.#..#...#............#.....#..#
					..#......#..##............###..
					..........#......#..#..#.......
					.#..#.......#.........#.#......
					.........#..#....##..#.##....#.
					..#....##...#..................
					##..........#.##...#....##..#..
					...#....#...#..............#...
					...........................#..#
					..##.##.#..................#...
					...#.##..#............#........
					........#.......#...#.....##.#.
					.##..........#......#.......#..
					...#..........#...#..#.......#.
					......#...#...#.##.......#.#...
					........#...#...#...##.........
					#..............#.#....#.......#
					..#..#..#.#....#...............
					.....#........#...#..........#.
					##......#...#..#.##.......#....
					..#.#.....#.#.............#.#.#
					#..#..##......##...#...........
					..#......#........#.....#......
					.....#.......#....#.#...#......
					...#........#...........#...#..
					.......#.#...........###....#..
					...#...........##....##........
					#....#..####....#.....#..#....#
					..........#...........#........
					...#.......#....#.#.........#..
					....#...#.......#..###.........
					......#......#..#......#..#....
					...#.....#............#..#.....
					...#.#.#.#..#.......#.....#....
					#....##...#.........#...##.....
					#..#.......#..#..#..#...##.....
					#.......#............#.....#...
					.#........##....##...#........#
					.....#...#.....................
					.......#........#..............
					.....#............#.#.#...#.#..
					.....##..#.............#.......
					..#.##..#........#..#...#......
					.........#.#....#...........#..
					.#.....#..#....#.....#...#.....
					....#.#................#.......
					...............##......#...#...
					.##...#...#.......##.#....#....
					............#........#.......#.
					......##.#.#...................
					.#.#..............#.......#....
					#.....#...#.......#..#...#.....
					.............#....#..#......#..
					........#...##................#
					.......#...#..#..##............
					..#..#...##...#..#.#.....#...#.
					.#.#...#.........#.#...........
					...###....#.......#...#........
					........#......##.#...#..##..#.
					.....................#.#.......
					.............#...........#...#.
					#..#..#.....#.#...#............
					...#....#.....#...........#....
					..##.....##...#......#..##.....
					#.....#.....###.#.....#....##..
					.#...........###...............
					..................#..##.#...#..
					................#....##.#......
					.#.#.#...#....#.........#..#.#.
					#.......#........##............
					.......##.#....#.#............#
					..........#..##.#....#.........
					........##..#....#.............
					.........#....#...........##...
					#.........#.#..#..#..........#.
					.....#........#......#.........
					....#.#.#...............#......
					.#..#..##...#.##..........#....
					..#....................#.#.....
					.........#....#...........#.#.#
					........#....##.##.............
					..#.....#.......#..#......#....
					#..........#.#.....#.#....#....
					........##.#.....#..#.....#.#..
					...................#...#....#.#
					............#..#....#...#...#..
					..............#.#.........#....
					...#..#..#.#..##..##...........
					.#...........................#.
					.#.......#...........#....#.#.#
					......#..#...#........#...##...
					.........#......#.#.......#...#
					...#..##................#......
					.............#.#..##....#.#....
					...............#..#......#.....
					.#......#.#.#....#........#....
					........#..#.##..#..#.........#
					...#....#.#...#..#.......#..#..
					..#...##.........#..#...#......
					...#...........#.............#.
					....#.....................#....
					.....#..#...............#.#...#
					....#..........#........#......
					..#....#........##..##.........
					...#....#..#.#.......#...#.....
					..#........#....#...##....#.#..
					.#...#........##.....#....###..
					#....#....##......#........#...
					.........#..#.#..........#....#
					....#...#.....#.......##.......
					..............#..........#.##..
					#...#..#..............#......#.
					.................#......##....#
					..#..##..#.......#..#.#......#.
					.............#........#.....#.#
					.#.##............#..#..........
					..#...#...........#..##........
					.#....#...#....#.......#.......
					...#.#..#..#..#....#.....#..#..
					....#..##..............#...#...
					#..........###......###........
					.##.##......#..#............#..
					.#...........#.#.....#...#.....
					#.#..#...#............#........
					.........#...#...#..........##.
					.......###..#..........#.......
					...........###.....#........#..
					.#.............#.....#......#..
					...#.....#....#.#.........##...
					....##..##...#.......##........
					......#....##.........#......#.
					..........#.....##..#.....#..#.
					..........####...#..#.........#
					.##....#..#.#...#.......#......
					...#.#.##.#.#...#....#.#.#.....
					.........#...##........##.....#
					..#........#..........##...##.#
					##...##..........#.#...........
					..............#......#.........
					........#.....#.#.......#......
					.#...#.....#....#.#..#.........
					.....#....................##...
					....#..................#.#...##
					.....#............#..##........
					#..........#....#.#.......##.#.
					....#..#.....................#.
					#..#....##.....#...............
					..#...#..#..##....#.#..........
					.......#......#.#.......#.....#
					...#.#.......#...#.##..........
					....#..........#....#.#.#......
					.......#..#..........#..##.....
					#......#......#...#......#...#.
					###..#....##......##........#..
					.#..........#.....#.......#.#..
					.......#.....#.....#.#.........
					..#...#....#...................
					..............#.##.............
					.#...#.......#.##...#.#.......#
					.......#......................#
					....#.#...#.#........#.........
					.#......#....#...#.............
					#.......#...###.....#.#.#..#...
					#....##.#...............##.....
					..#.......#..................#.
					.....####...............#......
					.##......#......#.#.......##.#.
					#......##..###....#....#......#
					.##.......##.##...#.##.........
					......##............#.......#..
					......#..#.....##.#............
					.#..........#.....##...........
					#.........#......#......##.#...
					.........#.......#..#......#.#.
					.........#.......#...........#.
					.#..##.#..................##...
					.............#.............#...
					.....##........#......##...##..
					..#..#.#.....#..#....#.........
					.....#....#.....#.....#........
					#......##.....#....#....#......
					#.................#..#.#......#
					.......#..#......#....#.#...#.#
					....#.........#..#..........#.#
					##......#............#...#...#.
					....##......#...#.....#....##..
					.#...##.........#..............
					......#.....................#..
					..#..........###....#..........
					#....#...#..#.............#....
					#........#.#......#....#.......
					.#...#.......#..#...#.#...#..#.
					................##.#.....#.....
					###.......#...#................
					...#.......#...#.#.....#.......
					..#.........#.....#.#.......#..
					......#.......................#
					#.....#.#..#....#.......#......
					...#....#..#....####...........
					.............#.....#...##......
					.......#.........#...#..#......
					.##..#.........#....#.#........
					....##...#.#...........#....#..
					.........................##....
					..###.......##....#.#.........#
					.#....#.#.#...........##....#..
					......#...#..#..#..#..#.......#
					..#....#.#.......#..#..#..#...#
					.....##...#.##....#.#...#......
					.........#..#....#..#..........
					.##..##.........#.#.....#......
					..........#...##...#.#...#.....
					#.##..#..#.............#.......
					...#...........#.......#......#
					.......#....#....#...##.......#
					..#.##........###..#......#....
					...#...........###......#..#..#
					.#.........#.#.........#.#.....
					##.......##.##.##......##......
					............#...#..........#...
					....................#..........
					...#..#...........#...#...#....
					.................#...#......###
					...#................#.#.##.....
					...............#........#......
					#.............##......#.#..#...
					..#.#.....#..#.##.....##...#...
					......#.........#......#.......
					#.......#......#....#........#.
					.#..##.....#.........#.........
					....##.##.#...#.........##.#...
					...............#..#..#..##.....
					.#..#...............###........
					.##............##..............
					...............#...##...#...#.#
					..#.#......#.#..#.............#
					#.#..#..##.........#.#.#...#...
					....##.#....................##.
					.........#..#.....#.....#..#..#
					....#......#......#.##....#....
					........###..#.............#..#
					##................#.........#..
					#.....#.......#....#...........
					..#.......#..#........#....#...
					..#.#.##..#.#...##........#.##.
					..#..........#............#....
					..........#...............##...
					..........###........#.#.......
					.....###..#.............#......
					##.............#...#.....#.....
					.....#......#....#........#.#..
					............#..#..............#
					.................#...........##
					#........#.........###.....#...
					..#.#..............##......#.#.
					.#...........#.........#..##..#
					...............................
					.#.....#..#....#....#......#...
					.#...#......#.#..#....#.......#
					......#.##.......#......#......
					......#..###..#................
					#..#.....#........##...#.......
					......##.........##....#...##..
					.#..........#.................#
					#..#.......#...............#...
					.........#..###....#.#.##.#....
					..#...#.##..##...............##
					.........#.....................
					.#....##...#......#....#.......
					............#..........#..#....
					...#......##....#....#........#
					.#...................#.........
					#.#........###....#..........#.
					.........#....#....#........##.
					.#....#..#.........#..#........
					...............#..#...#..#...##
					.........#....##....#......#...
					.#.............................
					...#........#...#.#...#.#..#...
					.....#..##...#.#...............
					#.....#....#.........#.........
					#...#...........##.........#...
					..##........#.#...#...#......#.
					...........#.....#...#.#.......
					......###....#.....#...........
					......##...#..........#....#.#.
					.......##..##..........#.......
					....#............#..#....##....
					..##...................#.#.....
					...#.#..#.#....................
					.#..##..#............##.###..#.
					#.#...#....#.#..........#.#....
					........#....#.....#...........
					..##....#...#.......#..........
					...........##.##....#..........
					.....#............#............
					.......#.............#....#....
					.................#......#......
					......##.......#....#..##...#..
					.#..#....#.....................
					...#.#.#...#......##...........
					##........##.#....#....#.......
					.......#.....#..#..#...#.##....
					#..........#....#.#..#..#..#...
					...##..............#...........
					.........#.....#.#....#.......#
					.........#....##..#..##..#.....
					.....#......................#..
					...###...#..#......#...........
					....#.....................#....
					...............................
					..#.....###.......#..#....#....
					#..........#.................#.
					......#.......###.......#..##..
					.............#.##..............
					......#..#.#..#...........#....
					...#....##.#...#..#.#...#....#.
					..................#...#....#.##
					......#.#....#.................
					......#.#.....#.....#..##......
					#..##...........#..#.....#.##..", 727923200)]
		public void MultiplyDifferentRuns_ReturnsCorrectMultiplicationForDifferentRuns(string mapString, int expected)
		{
			//arrange
			var dayThree = new DayThreeSolution(mapString);
			var points = new List<Point>
			{
				new Point(1, 1),
				new Point(3, 1),
				new Point(5, 1),
				new Point(7, 1),
				new Point(1, 2),
			};

			//act
			var result = dayThree.MultiplyDifferentRuns(points);

			//assert
			Assert.Equal(expected, result);
		}
	}
}
