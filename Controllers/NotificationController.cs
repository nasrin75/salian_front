using Microsoft.AspNetCore.Mvc;

namespace salian_front.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
