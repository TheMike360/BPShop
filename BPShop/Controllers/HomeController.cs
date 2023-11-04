using BPShop.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BPShop.Controllers
{
	public class HomeController : Controller
	{
		private readonly MYContext context;

		public HomeController() : this(new MYContext())
		{
		}
		public HomeController(MYContext context)
		{
			this.context = context;
		}

		public async Task<ActionResult> Index()
		{
			var Products = await context.Products.OrderByDescending(x => x.ID).Take(10).ToListAsync();
			return View(Products);
		}

		public ActionResult About()
		{
			return View();
		}

		public ActionResult Contact()
		{
			return View();
		}
	}
}