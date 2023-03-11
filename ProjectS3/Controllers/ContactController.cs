using Microsoft.AspNetCore.Mvc;

namespace ProjectS3.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
