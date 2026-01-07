using Microsoft.AspNetCore.Mvc;

namespace salian_front.Controllers
{
    public class LogController : Controller
    {
        public IActionResult List()
        {
            ViewBag.nowDate = DateTime.Now.ToString("MM/dd/yyyy");
            return View();
        }
    }
}
