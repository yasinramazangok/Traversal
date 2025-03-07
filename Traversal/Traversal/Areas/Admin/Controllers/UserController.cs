using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IAdminTraversalUserService _traversalUserService;

        public UserController(IAdminTraversalUserService traversalUserService)
        {
            _traversalUserService = traversalUserService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _traversalUserService.TGetListAsync();
            return View(values);
        }

        public IActionResult DeleteUser(int id)
        {
            _traversalUserService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            var values = _traversalUserService.TGetByIdAsync(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateUser(TraversalUser traversalUser)
        {
            _traversalUserService.TUpdateAsync(traversalUser);
            return RedirectToAction("Index");
        }
    }
}
