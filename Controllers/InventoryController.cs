using Microsoft.AspNetCore.Mvc;

namespace salian_front.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
