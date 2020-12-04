using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.DayTwo
{
	public class DayTwoSolution
	{
		private readonly List<string> _passwordsAndPolicy;

		public DayTwoSolution(List<string> passwordsAndPolicy)
		{
			_passwordsAndPolicy = passwordsAndPolicy;
		}

		public int SumValidPasswords(PasswordStrategy passwordStrategy)
		{
			var amount = 0;
			foreach (var passwordAndPolicyString in _passwordsAndPolicy)
			{
				if (PasswordValid(passwordStrategy, passwordAndPolicyString))
				{
					amount++;
				}
			}
			return amount;
		}

		private static bool PasswordValid(PasswordStrategy passwordStrategy, string passwordAndPolicyString)
		{
			var passwordAndPolicy = new PasswordAndPolicy(passwordAndPolicyString);
			var policyLeast = passwordAndPolicy.PolicyLeast;
			var policyMost = passwordAndPolicy.PolicyMost;
			var character = passwordAndPolicy.Character;
			var password = passwordAndPolicy.Password;

			switch (passwordStrategy)
			{
				case PasswordStrategy.CharacterPosition:
					return
						(password[policyLeast - 1] == character && password[policyMost - 1] != character) ||
						(password[policyLeast - 1] != character && password[policyMost - 1] == character);

				case PasswordStrategy.MinMaxCharacters:
					var count = password.Count(s => s == character);
					return count >= policyLeast && count <= policyMost;

				default:
					throw new ArgumentOutOfRangeException(nameof(passwordStrategy));
			}
		}
	}
}
