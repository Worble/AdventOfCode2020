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

		public int SumValidPasswords()
		{
			var amount = 0;
			foreach (var passwordAndPolicyString in _passwordsAndPolicy)
			{
				var passwordAndPolicy = new PasswordAndPolicy(passwordAndPolicyString);
				var policyLeast = passwordAndPolicy.PolicyLeast;
				var policyMost = passwordAndPolicy.PolicyMost;
				var character = passwordAndPolicy.Character;
				var password = passwordAndPolicy.Password;
				var count = password.Count(s => s == character);
				if (count >= policyLeast && count <= policyMost)
				{
					amount++;
				}
			}
			return amount;
		}

		public int SumValidPasswordsBasedOnPosition()
		{
			var amount = 0;
			foreach (var passwordAndPolicyString in _passwordsAndPolicy)
			{
				var passwordAndPolicy = new PasswordAndPolicy(passwordAndPolicyString);
				var policyLeast = passwordAndPolicy.PolicyLeast;
				var policyMost = passwordAndPolicy.PolicyMost;
				var character = passwordAndPolicy.Character;
				var password = passwordAndPolicy.Password;
				if ((password[policyLeast - 1] == character && password[policyMost - 1] != character) ||
					(password[policyLeast - 1] != character && password[policyMost - 1] == character))
				{
					amount++;
				}
			}
			return amount;
		}
	}
}
