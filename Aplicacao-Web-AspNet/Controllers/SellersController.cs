using Aplicacao_Web_AspNet.Models;
using Aplicacao_Web_AspNet.Models.ViewModels;
using Aplicacao_Web_AspNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacao_Web_AspNet.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;
        public SellersController (SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//evitar que enviem itens maliciosos
        public IActionResult Create(Seller seller) 
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
