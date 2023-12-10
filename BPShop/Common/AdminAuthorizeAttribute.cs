using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BPShop.Common
{
	public class AdminAuthorize : AuthorizeAttribute
	{
		protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
		{
			if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
			{
				filterContext.Result = new RedirectResult("~/Auth/Login");
			}
		}
	}
}