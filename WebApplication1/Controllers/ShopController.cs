using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Product.Demo;

namespace WebApplication1.Controllers
{
    public class ShopController : Controller
    {
        MyContext context = new MyContext();
        public IActionResult Index()
        {
            ViewBag.data = context.Products.ToList();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product.Demo.Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.item = context.Products.Find(id);
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Product.Demo.Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            context.Products.Remove(new Product.Demo.Product() { ProductId = id });
            context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}