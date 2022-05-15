using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathChallange.Controllers
{
    public class ShippingCompanyController : Controller
    {
        public IActionResult ShippingCompanies()
        {
            return View();
        }
    }
}
