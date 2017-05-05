using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace IsItYours.Models.Attributes
{
	class PhoneAttribute : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			if (value == null)
			{
				return true;
			}

			string strValue = value.ToString();
			Regex regex = new Regex(@"\+\d+\/\d+");
			Match match = regex.Match(strValue);
			if (match.Success)
			{
				string countryCode = String.Empty;
				string phone = String.Empty;
				Regex regexCC = new Regex(@"\+\d+\/");
				match = regexCC.Match(strValue);
				if (match.Success)
				{
					countryCode = match.Value.Substring(1, match.Length - 2);
					if (countryCode.Length < 1 || countryCode.Length > 3)
					{
						return false;
					}
				}

				Regex regexP = new Regex(@"\/\d+");
				match = regexP.Match(strValue);
				if (match.Success)
				{
					phone = match.Value.Substring(1, match.Length - 1);
					if (phone.Length < 8 || phone.Length > 10)
					{
						return false;
					}
				}
			}

			return true;
		}
	}
}
