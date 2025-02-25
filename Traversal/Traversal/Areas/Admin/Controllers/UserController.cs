using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly ITraversalUserService _traversalUserService;
        private readonly IReservationService _reservationService;

        public UserController(ITraversalUserService traversalUserService, IReservationService reservationService)
        {
            _traversalUserService = traversalUserService;
            _reservationService = reservationService;
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

        public IActionResult CommentUser(int id)
        {
            _traversalUserService.TGetListAsync();
            return View();
        }

        public IActionResult UserReservationList(int id)
        {
            var values = _reservationService.GetListOfAcceptedReservations(id);
            return View(values);
        }
    }
}
