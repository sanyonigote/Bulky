using Bulky.DataAccess.Repository;
using Bulky.Models.Models;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BulkyWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;    
        public HomeController(ILogger<HomeController> logger,IUnitOfWork unitofwork)
        {
            _logger = logger;
            _unitOfWork = unitofwork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> ProductList = _unitOfWork.product.GetAll(includeProperties: "Category");
            return View(ProductList);
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
