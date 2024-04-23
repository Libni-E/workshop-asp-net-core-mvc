using Aplicacao_Web_AspNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacao_Web_AspNet.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        public SellersController (SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
