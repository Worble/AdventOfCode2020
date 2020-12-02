namespace AdventOfCode2020.DayTwo
{
	public class PasswordAndPolicy
	{
		public PasswordAndPolicy(string passwordAndPolicy)
		{
			var passwordSplit = passwordAndPolicy.Split(' ');
			var leastMostSplit = passwordSplit[0].Split('-');
			PolicyLeast = int.Parse(leastMostSplit[0]);
			PolicyMost = int.Parse(leastMostSplit[1]);
			Character = passwordSplit[1][0];
			Password = passwordSplit[2];
		}

		public char Character { get; init; }
		public string Password { get; init; }
		public int PolicyLeast { get; init; }
		public int PolicyMost { get; init; }
	}
}
