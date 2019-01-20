using Shop.Entites;
using Shop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductService productService = new ProductService();

        public ActionResult Index()
        {   return View( productService.GetProducts() ); }

        [HttpGet]
        public ActionResult Edit(int ID) { return View(productService.Edit(ID)); }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productService.Update(product);
            return RedirectToAction("Index");
        }
    }
}