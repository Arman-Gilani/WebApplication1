using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
       

       

        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Resume()
		{
			return View();
		}
		public IActionResult Portfolio()
		{
			return View();
		}
		public IActionResult PortfolioDetails()
		{
			return View();
		}
		public IActionResult Services()
		{
			return View();
		}
		public IActionResult Contact()
		{
			return View();
		}

		public IActionResult About()
        {
            return View();
        }

        
    }
}