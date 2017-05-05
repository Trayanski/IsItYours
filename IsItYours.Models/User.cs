using System.ComponentModel.DataAnnotations;
using IsItYours.Models.Attributes;
using Newtonsoft.Json;

namespace IsItYours.Models
{
	public class User
	{
		public int Id { get; set; }

		[Required, MinLength(3), JsonProperty(PropertyName = "First Name")]
		public string FirstName { get; set; }

		[Required, MinLength(3), JsonProperty(PropertyName = "Last Name")]
		public string LastName { get; set; }

		[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
		public string Email { get; set; }

		[Required, Password]
		public string Password { get; set; }
		
		[Required, Attributes.Phone, JsonProperty(PropertyName = "Mobile Number")]
		public string MobileNumber { get; set; }

		[Attributes.Phone, JsonProperty(PropertyName = "Work Phone")]
		public string WorkPhone { get; set; }

		[Attributes.Phone, JsonProperty(PropertyName = "Home Phone")]
		public string HomePhone { get; set; }

		public string Address { get; set; }

		[Required]
		public string Country { get; set; }

		public string City { get; set; }

		[JsonProperty(PropertyName = "Post / Zip Code")]
		public int PostZipCode { get; set; }
	}
}