using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsAsp.Models.ViewModels;
using DesignPatternsAsp.Strategies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPatternsAsp.Controllers
{
    public class BeerController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> beers =
                from b in _unitOfWork.Beers.Get()
                select new BeerViewModel
                {
                    Id = b.BeerId,
                    Name = b.Name,
                    Style = b.Style
                };

            return View("Index", beers);
        }
        [HttpGet]
        public IActionResult Add()
        {
            GetBrandsData();
            return View();
        }

        [HttpPost]
        public IActionResult Add(FormBeerViewModel beerVM)
        {
            if (!ModelState.IsValid)
            {
                GetBrandsData();
                return View("Add", beerVM);
            }

            var context = beerVM.BrandId == null ?
                new BeerStrategyContext(new BeerWithBrandStrategy()) :
                new BeerStrategyContext(new BeerStrategy());

            context.Add(beerVM, _unitOfWork);

            return RedirectToAction("Index");

        }

        #region HELPERS
        private void GetBrandsData()
        {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
        }
        #endregion

    }
}
