using Microsoft.AspNetCore.Mvc;

namespace STAR_PRC_SEA.Controllers
{
    public class ReferencesControlsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}