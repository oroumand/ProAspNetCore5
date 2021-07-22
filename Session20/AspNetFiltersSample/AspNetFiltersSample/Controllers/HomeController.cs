using AspNetFiltersSample.Infrastructures;
using Microsoft.AspNetCore.Mvc;

namespace AspNetFiltersSample.Controllers
{
    [MyOrderFilter("Controller Order Filter")]
    public class HomeController : Controller
    {
        //[TypeFilter(typeof(ExeptionRedirectionFilter))]
        //[ServiceFilter(typeof(LifeTimeFilter))]
        //[IsHttpsFilter]
        //[ActionMethodExecutionTimeFilter]
        //[ResultExectionTimerFilter]

        //[HybridFilter]

        [MyOrderFilter("Action Order Filter First")]
        [MyOrderFilter("Action Order Filter Seccond",Order = -1)]
        public IActionResult Index()
        {
            //throw new System.Exception("یک خطای بحرانی اتفاق افتاده است.");
            return View();

        }
        //[IsHttpsFilter]
        [ActionMethodExecutionTimeFilter]
        [ResultExectionTimerFilter]
        public IActionResult Index2()
        {

            return View();

        }
    }
}
