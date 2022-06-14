using Cloth_Storee.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cloth_Storee.Controllers
{
    public class HomeController : Controller
    {      
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult bone()
        {
            return View();
        }
        public IActionResult calca()
        {
            return View();
        }
        public IActionResult camisas()
        {
            return View();
        }
        public IActionResult moletom()
        {
            return View();
        }
        public IActionResult tenis()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult cadastro()
        {
            return View();
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}