using Microsoft.AspNetCore.Mvc;

namespace salian_front.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult List()
        {
            return View() ;
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

    
    }
}
