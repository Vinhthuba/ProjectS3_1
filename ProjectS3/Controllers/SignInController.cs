using Microsoft.AspNetCore.Mvc;

namespace ProjectS3.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
