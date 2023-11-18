﻿using BPShop.Context;
using BPShop.Enities;
using BPShop.Enums;
using BPShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
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

		public async Task<ActionResult> Products(decimal maxRange = 0, decimal minRange = 0, SortType sortType = SortType.defaultSort, string search = "")
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
			if (!string.IsNullOrEmpty(search))
			{
				ViewBag.Search = search;
				products = products.Where(x => x.SearhPrompt.Contains(search));
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
			var cart = GetCart();
			ViewBag.IsHaveCart = cart.Count() > 0;

			List<Product> result = await products.ToListAsync();
			return View(result);
		}

		public async Task<ActionResult> ShowProduct(int Id)
		{
			Product Item = await context.Products.FirstOrDefaultAsync(x => x.ID == Id);
			return View(Item);
		}

		public ActionResult Cart()
		{
			List<CartModel> cart = GetCart();
			return View(cart);
		}

		public int AddToCart(int productId, int quantity = 1)
		{
			List<CartModel> cart = GetCart();
			if (cart.Count() > 100)
			{
				return -100;
			}

			CartModel existingItem = cart.FirstOrDefault(item => item.ProductId == productId);

			if (existingItem != null)
			{
				existingItem.Quantity += quantity;
			}
			else
			{
				cart.Add(new CartModel { ProductId = productId, Quantity = quantity });
			}

			return 0;
		}


		public ActionResult About()
		{
			return View();
		}

		public ActionResult Contact()
		{
			return View();
		}

		private List<CartModel> GetCart()
		{
			var cart = Session["Cart"] as List<CartModel>;
			if (cart == null)
			{
				cart = new List<CartModel>();
				Session["Cart"] = cart;
			}
			return cart;
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

	}
}