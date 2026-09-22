using Microsoft.AspNetCore.Mvc;

namespace STAR_PRC_SEA.Controllers
{
    public class FreightChargesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}