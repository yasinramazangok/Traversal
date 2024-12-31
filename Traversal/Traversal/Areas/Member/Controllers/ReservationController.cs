using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;

        private readonly IDestinationService _destinationService;

        private readonly UserManager<TraversalUser> _userManager;

        public ReservationController(UserManager<TraversalUser> userManager, IDestinationService destinationService, IReservationService reservationService)
        {
            _userManager = userManager;
            _destinationService = destinationService;
            _reservationService = reservationService;
        }

        private async Task<TraversalUser> GetCurrentUserAsync()
        {
            return await _userManager.FindByNameAsync(User.Identity.Name);
        }

        public async Task< IActionResult> MyCurrentReservation()
        {
            var values = await GetCurrentUserAsync();
            var valuesList = _reservationService.GetListOfAcceptedReservations(values.Id);
            return View(valuesList);
        }
        public async Task <IActionResult> MyOldReservation()
        {
            var values = await GetCurrentUserAsync();
            var valuesList = _reservationService.GetListOfPastReservations(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await GetCurrentUserAsync();
            var valuesList = _reservationService.GetListOfPendingApprovalReservations(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in _destinationService.GetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationId.ToString()
                                           }).ToList();
            
            if (!values.Any())
            {
                throw new Exception("Destination listesi boş!");
            }

            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation reservation)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            reservation.TraversalUserId = user.Id;
            reservation.Status = "Onay Bekliyor";
            _reservationService.Insert(reservation);
            return RedirectToAction("Index", "Destination");
        }
        public IActionResult Deneme()
        {
            return View();
        }
    }
}
