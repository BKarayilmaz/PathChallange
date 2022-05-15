using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathChallange.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
    }
}
