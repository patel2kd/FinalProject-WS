using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Login_1.Models
{
	public class Member
	{
		public string name { get; set; }

		[Required(ErrorMessage = "Please enter a name.")]
		[Remote("CheckString", "Validation")]
		public string? FullName { get; set; }

		[Required(ErrorMessage = "Please enter some information about yourself")]
		[Range(0, 1000, ErrorMessage = "Please do not leave this section empty.")]
		public string? statement { get; set; }

	}
}