using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
