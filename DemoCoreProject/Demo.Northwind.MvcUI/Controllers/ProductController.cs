using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Northwind.BLL.Abstract;
using Demo.Northwind.MvcUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Northwind.MvcUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        
        public ActionResult Index()
        {
            var products = _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel { Products = products };
            return View(model);
        }



        //public ActionResult Index(int page = 1, int category = 0)
        //{
        //    int pageSize = 10;
        //    var products = _productService.GetByCategory(1);
        //    ProductListViewModel model = new ProductListViewModel
        //    {
        //        Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
        //        PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
        //        PageSize = pageSize,
        //        CurrentCategory = category,
        //        CurrentPage = page
        //    };
        //    return View(model);
        //}

        //public string Session()
        //{
        //    HttpContext.Session.SetString("city","Ankara");
        //    HttpContext.Session.SetInt32("age",32);

        //    HttpContext.Session.GetString("city");
        //    HttpContext.Session.GetInt32("age");
        //}

        public ActionResult Login()
        {
            return View();
        }
    }
}
