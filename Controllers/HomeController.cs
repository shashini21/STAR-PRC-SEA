using Microsoft.AspNetCore.Mvc;


namespace STAR_PRC_SEA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
