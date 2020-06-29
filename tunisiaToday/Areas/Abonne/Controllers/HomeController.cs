using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using tunisiaToday.DataAccess.Repository.IRepository;
using tunisiaToday.Models;
using tunisiaToday.Models.ViewModels;

namespace tunisiaToday.Controllers
{
    [Area("Abonne")]
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

            IEnumerable<Article> Article_Int = _unitOfWork.Article.GetWhereCategoryId(1);
            if (Article_Int.Count() > 6)
            {
                Article_Int = _unitOfWork.Article.GetWhereCategoryId(1).ToList().GetRange(0, 6);
            }
            IEnumerable<Article> Article_Eco = _unitOfWork.Article.GetWhereCategoryId(3);
            if (Article_Eco.Count() > 6)
            {
                Article_Eco = _unitOfWork.Article.GetWhereCategoryId(3).ToList().GetRange(0, 6);
            }
            IEnumerable<Article> Article_Pol = _unitOfWork.Article.GetWhereCategoryId(2);
            if (Article_Pol.Count() > 6)
            {
                Article_Pol = _unitOfWork.Article.GetWhereCategoryId(2).ToList().GetRange(0, 6);
            }
            IEnumerable<Article> Article_Sport = _unitOfWork.Article.GetWhereCategoryId(4);
            if (Article_Sport.Count() > 6)
            {
                Article_Sport = _unitOfWork.Article.GetWhereCategoryId(4).ToList().GetRange(0, 6);
            }

            HomeVM homeVm = new HomeVM()
            {
                Article_Eco = Article_Eco,
                Article_Int = Article_Int,
                Article_Pol = Article_Pol,
                Article_Sport = Article_Sport,
                Article = _unitOfWork.Article.GetLastAlaUneArticle()
            };

            
            return View(homeVm);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
