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

        public ActionResult Index() { return View( productService.GetProducts() ); }

        public ActionResult ProductTable()
        { var products = productService.GetProducts(); return View(products); }

        [HttpGet]
        public ActionResult Create(){ return View(); }

        [HttpPost]
        public ActionResult Create(Product product)
        { productService.SaveProducts(product); return RedirectToAction("ProductTable"); }

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