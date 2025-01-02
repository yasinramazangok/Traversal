using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public IActionResult Index()
        {
            var values = _traversalUserService.GetList();
            return View(values);
        }

        public IActionResult DeleteUser(int id)
        {
            var values = _traversalUserService.GetById(id);
            _traversalUserService.Delete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            var values = _traversalUserService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateUser(TraversalUser traversalUser)
        {
            _traversalUserService.Update(traversalUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser(int id)
        {
            _traversalUserService.GetList();
            return View();
        }

        public IActionResult UserReservationList(int id)
        {
            var values = _reservationService.GetListOfAcceptedReservations(id);
            return View(values);
        }
    }
}
