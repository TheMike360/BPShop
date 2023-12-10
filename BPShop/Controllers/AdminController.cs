using BPShop.Common;
using BPShop.Context;
using BPShop.Enities;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BPShop.Controllers
{
    [AdminAuthorize]
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
        public async Task AdminPanelAdd(Product product, HttpPostedFileBase file)
        {
			if (file != null && file.ContentLength > 0)
			{
				string fileName = Path.GetFileName(file.FileName);

				string filePath = Path.Combine(Server.MapPath("~/Content/productImgs"), fileName);
				file.SaveAs(filePath);
                product.ImgRef = "~/Content/productImgs" + fileName;
			}

			context.Products.Add(product);
            await context.SaveChangesAsync();
        }

		public ActionResult ImagesPage()
		{
			string folderPath = Server.MapPath("~/Content/productImgs");
			string[] imagePaths = Directory.GetFiles(folderPath);

			// Извлекаем имена файлов из путей
			string[] fileNames = imagePaths.Select(path => Path.GetFileName(path)).ToArray();

			// Передаем имена файлов и пути к изображениям в представление
			ViewBag.ImagePaths = imagePaths;
			ViewBag.FileNames = fileNames;

			return View();
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