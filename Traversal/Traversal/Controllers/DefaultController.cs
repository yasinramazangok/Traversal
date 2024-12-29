using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class DefaultController : Controller
    {
        [AllowAnonymous]
        public IActionResult Home()
        {
            return View();
        }
    }
}
