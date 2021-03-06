﻿namespace IsItYours.Dto
{
	public class UserDto
	{
		public string FirstName { get; set; }
		
		public string LastName { get; set; }

		public string Email { get; set; }
		
		public string Password { get; set; }

		public int ISDCode { get; set; }

		public int MobileNumber { get; set; }

		public string WorkPhone { get; set; }
		
		public string HomePhone { get; set; }

		public string Address { get; set; }
		
		public string Country { get; set; }

		public string City { get; set; }
		
		public string PostZipCode { get; set; }
	}
}