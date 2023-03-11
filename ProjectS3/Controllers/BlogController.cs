using Microsoft.AspNetCore.Mvc;

namespace ProjectS3.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
