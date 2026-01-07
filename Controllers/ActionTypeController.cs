using Microsoft.AspNetCore.Mvc;

namespace salian_front.Controllers
{
    public class ActionTypeController : Controller
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
