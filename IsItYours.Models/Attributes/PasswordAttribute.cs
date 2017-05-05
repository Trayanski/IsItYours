using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace IsItYours.Models.Attributes
{
	class PasswordAttribute : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			if (value.ToString().Length < 6 
				|| !value.ToString().Substring(0).Equals(value.ToString().Substring(0).ToUpper()) 
				|| !value.ToString().Any(char.IsDigit))
			{
				return false;
			}

			return true;
		}
	}
}
