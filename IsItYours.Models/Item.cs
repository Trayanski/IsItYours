using System;
using System.ComponentModel.DataAnnotations;

namespace IsItYours.Models
{
	public class Item
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required, MinLength(10)]
		public string Description { get; set; }
		
		public DateTime TimeFound { get; set; }

		public bool FoundItsOwner { get; set; }
	}
}