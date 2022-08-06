using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Login_1.Models;
namespace Login_1.Controllers
{
	public class ValidationController : Controller
	{
		private MemberManagerContext data { get; set; }
		public ValidationController(MemberManagerContext ctx) => data = ctx;
		public JsonResult CheckName(string fullName)
		{
			//string fn = string.Parse(fullName);
			string fn = fullName;
			Member member = data.Members.FirstOrDefault(t => t.FullName == fn);
			if (member == null)
				return Json(true);
			else
				return Json($"The name {fullName} is already in the database.");
		}
	}
}