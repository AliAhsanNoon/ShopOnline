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
        // GET: Product
        public ActionResult Index()
        {   return View(productService.GetProducts()); }
    }
}