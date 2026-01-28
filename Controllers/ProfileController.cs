using Microsoft.AspNetCore.Mvc;

namespace salian_front.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Setting()
        {
            return View();
        }
    }
}
