using Microsoft.AspNetCore.Mvc;

namespace salian_front.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Setting()
        {
            return View();
        }
    }
}
