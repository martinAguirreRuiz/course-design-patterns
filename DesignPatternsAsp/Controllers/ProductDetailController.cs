using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesignPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        private EarnFactory _localEarnFactory;
        private EarnFactory _foreignEarnFactory;
        public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }
        public IActionResult Index(decimal total)
        {
            //Factories 
            //EarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
            //EarnFactory foreignEarnFactory = new ForeignEarnFactory(0.20m, 100m);
            //Products

            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEarnFactory.GetEarn();

            //Total

            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.foreignLocal = total + foreignEarn.Earn(total);

            //View
            return View();
        }
    }
}
