using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DL.Issues.AspNetCore.Mvc.CustomRouting.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListByType(string type)
        {
            return View("index", $"ListByType - { type }");
        }

        public IActionResult ListByCategory(string type, string category)
        {
            return View("index", $"ListByCategory - { type }/{ category }");
        }

        public IActionResult Details(string type, string category, string product)
        {
            return View("index", $"Details - { type }/{ category }/{ product }");
        }
    }
}