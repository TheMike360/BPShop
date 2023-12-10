using Renci.SshNet.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BPShop.Controllers
{
    public class AuthController : Controller
	{
		private static int failedLoginAttempts = 0;
		private static DateTime? lockoutEndTime = null;
		public ActionResult Login()
		{
			return View();
		}
		public ActionResult Auth(string Pass)
		{
			if (IsUserLockedOut())
			{
				int secondsUntilUnlock = (int)(lockoutEndTime.Value - DateTime.Now).TotalSeconds;
				ViewBag.Message = $"Ваш аккаунт заблокирован. Повторите попытку через {secondsUntilUnlock} секунд.";
				return View("Login");
			}

			const string PassCon = "Kony123";
			if (PassCon == Pass)
			{
				int expirationMinutes = 60; 
				failedLoginAttempts = 0;
				FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
					1,                                     
					"AdminPanama",                             
					DateTime.Now,                         
					DateTime.Now.AddMinutes(expirationMinutes), 
					true, 
					"Admin"
				);

				string encryptedTicket = FormsAuthentication.Encrypt(ticket);
				HttpCookie authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
				authCookie.Expires = DateTime.Now.AddMinutes(60);

				HttpContext.Response.Cookies.Add(authCookie);
				return RedirectToAction("AdminPanel", "Admin");
			}

			failedLoginAttempts++;
			if (failedLoginAttempts >= 3)
			{
				lockoutEndTime = DateTime.Now.AddMinutes(5);
				failedLoginAttempts = 0; 
			}
			return View("Login");
		}
		private bool IsUserLockedOut()
		{
			return lockoutEndTime.HasValue && lockoutEndTime.Value > DateTime.Now;
		}
	}
}