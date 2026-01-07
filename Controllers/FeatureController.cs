using Microsoft.AspNetCore.Mvc;

namespace salian_front.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
