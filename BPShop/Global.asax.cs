using System.Web;
using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Configuration;
using BPShop.Context;
using System.Data.Entity;

namespace BPShop
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			Database.SetInitializer<MYContext>(null);

			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{
			if (HttpContext.Current.User == null)
				return;

			if (HttpContext.Current.User.Identity.IsAuthenticated)
			{
				if (HttpContext.Current.User.Identity is FormsIdentity)
				{
					FormsIdentity id = (FormsIdentity)HttpContext.Current.User.Identity;
					FormsAuthenticationTicket ticket = id.Ticket;

					string userData = ticket.UserData;

					string[] userDataArray = userData.Split(',');

					HttpContext.Current.User = new System.Security.Principal.GenericPrincipal(id, userDataArray);
				}
			}
		}
		protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
		{
			HttpCookie authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];

			if (authCookie != null)
			{
				try
				{
					FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);
					if (authTicket != null && !authTicket.Expired)
					{
						HttpContext.Current.User = new System.Security.Principal.GenericPrincipal(
							new FormsIdentity(authTicket),
							new string[] { });
					}
				}
				catch { }
			}
		}
	}
}
