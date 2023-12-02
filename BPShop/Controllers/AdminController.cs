using BPShop.Context;
using BPShop.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BPShop.Controllers
{
    public class AdminController : Controller
    {
		private readonly MYContext context;
        
        public AdminController() : this(new MYContext())
        {
        }
        public AdminController(MYContext context)
        {
			this.context = context;
		}

        public ActionResult AdminPanel()
        {
            return View();
        }

        [HttpPost]
        public async Task AdminPanelAdd(Product product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();
        }

        public ActionResult AddProductsForm()
        {
            return View();
        }

        public ActionResult GetProductsTable()
        {
            IQueryable<Product> Products = context.Products.OrderByDescending(x => x.ID);
            return View(Products);
        }
    }
}