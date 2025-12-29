using Microsoft.AspNetCore.Mvc;

namespace salian_front.Controllers
{
    public class LogController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
