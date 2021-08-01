using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Th_E_shop.Views.Customer
{
    public class CustomerController : Controller
    {

        
        public IActionResult Register()
        {
            return View();
        }
    }
}
