using Shop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.Models
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryService categoryService = new CategoryService();
        public ActionResult Index()
        {
            var model = categoryService.GetCategories();
            return View(model);
        }
    }
}