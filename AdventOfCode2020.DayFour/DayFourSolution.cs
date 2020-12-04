using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2020.DayFour.Validators;
using AdventOfCode2020.DayFour.Validators.Interfaces;

namespace AdventOfCode2020.DayFour
{
	public class DayFourSolution
	{
		private readonly List<Dictionary<string, string>> _passports;
		private readonly List<string> _requiredFields;
		private readonly List<IPassportFieldValidator> _validators;

		public DayFourSolution(string input, List<string> requiredFields)
		{
			_requiredFields = requiredFields;
			var inputSplit = input.Split(new[] { "\r\n", "\r", "\n", " " }, StringSplitOptions.None);
			_passports = new List<Dictionary<string, string>>();
			ReadPasswords(inputSplit);
			_validators = new List<IPassportFieldValidator>
			{
				new BirthYearValidator(),
				new ExpirationYearValidator(),
				new EyeColorValidator(),
				new HairColorValidator(),
				new HeightValidator(),
				new IssueYearValidator(),
				new PassportIdValidator()
			};
		}

		public int SumValidPassports()
		{
			var invalidPassportSum = 0;
			foreach (var passport in _passports)
			{
				foreach (var field in _requiredFields)
				{
					if (!passport.Keys.Contains(field))
					{
						invalidPassportSum++;
						break;
					}
				}
			}
			return _passports.Count - invalidPassportSum;
		}

		public int SumValidPassportsWithValidators()
		{
			var invalidPassportSum = 0;
			foreach (var passport in _passports)
			{
				if (FieldMissing(passport) || FieldInvalid(passport))
				{
					invalidPassportSum++;
				}
			}
			return _passports.Count - invalidPassportSum;
		}

		private bool FieldInvalid(Dictionary<string, string> passport)
		{
			foreach (var (key, value) in passport)
			{
				foreach (var validator in _validators.Where(validator => validator.Field == key))
				{
					if (!validator.FieldIsValid(value))
					{
						return true;
					}
				}
			}
			return false;
		}

		private bool FieldMissing(Dictionary<string, string> passport)
		{
			foreach (var field in _requiredFields)
			{
				if (!passport.Keys.Contains(field))
				{
					return true;
				}
			}
			return false;
		}

		private void ReadPasswords(string[] inputSplit)
		{
			var passport = new Dictionary<string, string>();
			foreach (var item in inputSplit)
			{
				if (string.IsNullOrWhiteSpace(item))
				{
					if (passport.Count > 0)
					{
						_passports.Add(passport.ToDictionary(x => x.Key, x => x.Value));
						passport = new Dictionary<string, string>();
					}
					continue;
				}
				var kvp = item.Split(":");
				passport.Add(kvp[0], kvp[1]);
			}
			if (passport.Count > 0)
			{
				_passports.Add(passport.ToDictionary(x => x.Key, x => x.Value));
			}
		}
	}
}
