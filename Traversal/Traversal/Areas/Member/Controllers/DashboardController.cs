using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.EntityLayer.Concretes;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    public class DashboardController : Controller
    {
        private readonly UserManager<TraversalUser> _userManager;

        public DashboardController(UserManager<TraversalUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.Name;
            ViewBag.userImage = values.ImageUrl;
            return View();
        }
    }
}
