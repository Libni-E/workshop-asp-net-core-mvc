using Microsoft.AspNetCore.Mvc;

namespace Aplicacao_Web_AspNet.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
