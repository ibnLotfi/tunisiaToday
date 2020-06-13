using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using tunisiaToday.DataAccess.Repository.IRepository;
using tunisiaToday.Models;
using tunisiaToday.Models.ViewModels;

namespace tunisiaToday.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            HomeVM homeVm = new HomeVM()
            {
                Article_Eco = _unitOfWork.Article.GetAll(),
                Article_Int = _unitOfWork.Article.GetAll(),
                Article_Pol = _unitOfWork.Article.GetAll(),
                Article_Sport = _unitOfWork.Article.GetAll(),
                Categories = _unitOfWork.Category.GetAll()
        };


            return View(homeVm);
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
