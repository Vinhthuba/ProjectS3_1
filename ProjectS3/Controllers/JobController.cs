using Microsoft.AspNetCore.Mvc;

namespace ProjectS3.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
