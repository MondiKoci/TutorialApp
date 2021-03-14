using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialApplication.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About() 
        {
            return View();
        }

        public IActionResult Contact() 
        {
            var contacts = new Dictionary<string, string> {
                {"Phone", "416-123-1234" },
                {"Email", "name@domain.com" },
                {"Facebook", "facebook.ca/website" },
            };
            return View(contacts);
        }
    }
}
