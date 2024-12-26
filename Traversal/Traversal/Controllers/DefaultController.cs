using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
