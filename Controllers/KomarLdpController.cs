using Microsoft.AspNetCore.Mvc;

namespace STAR_PRC_SEA.Controllers
{
    public class KomarLdpController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}