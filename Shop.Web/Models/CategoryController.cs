using Shop.Entites;
using Shop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.cats
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryService categoryService = new CategoryService();

        public ActionResult Index()
        {
            var cat = categoryService.GetCategories();
            return View(cat);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category )
        {
            categoryService.SaveCategory(category);
            return RedirectToAction("Index");
        }
    }
}