
using Aplicacao_Web_AspNet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao_Web_AspNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Me chamo Libni Evanio, sou um desenvolvedor junior, construo aplicações back end e front end.";
            ViewData["Email"] = "libnievanio@gmail.com";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Seu contato para a pagina.";


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
