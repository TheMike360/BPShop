using BPShop.Context;
using BPShop.Enities;
using BPShop.Enums;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
			IQueryable<Product> products = context.Products.OrderByDescending(x => x.ID);
			//для range slider цены
			ViewBag.MaxCost = (int)products.Select(x => x.Cost).Max();
			ViewBag.MinCost = (int)products.Select(x => x.Cost).Min();

			List<Product> result = await products.Take(10).ToListAsync();
			return View(result);
		}

		public async Task<ActionResult> Products(decimal maxRange = 0, decimal minRange = 0, SortType sortType = SortType.defaultSort)
		{
			IQueryable<Product> products = context.Products.OrderByDescending(x => x.ID);
			//для range slider цены
			ViewBag.MaxCost = (int)products.Select(x => x.Cost).Max();
			ViewBag.MinCost = (int)products.Select(x => x.Cost).Min();

			ViewBag.MaxRange = ViewBag.MaxCost;
			ViewBag.MinRange = ViewBag.MinCost;

			if (minRange != 0 && maxRange != 0)
			{
				ViewBag.MaxRange = maxRange;
				ViewBag.MinRange = minRange;
				products = products.Where(x => x.Cost >= minRange && x.Cost <= maxRange);
			}
			if (sortType != SortType.defaultSort)
			{
				switch (sortType)
				{
					case SortType.oldProducts:
						products = products.OrderBy(x => x.ID);
						break;
					case SortType.newProducts:
						products = products.OrderByDescending(x => x.ID);
						break;
					case SortType.costDesc:
						products = products.OrderByDescending(x => x.Cost);
						break;
					case SortType.costAsc:
						products = products.OrderBy(x => x.Cost);
						break;
				}
			}

			//вид сортировки
			ViewBag.SortType = sortType;

			List<Product> result = await products.ToListAsync();
			return View(result);
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