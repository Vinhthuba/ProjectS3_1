using Microsoft.AspNetCore.Mvc;

namespace ProjectS3.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
