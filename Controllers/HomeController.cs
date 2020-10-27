
using System;
using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    public class HomeController : Controller {

        public IActionResult Index(){
            return View();
        }

        
        public IActionResult Contact()
        {
            // TODO: Your code here
            return View();
        }
        
    }
}