using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;

namespace Traversal.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly UserManager<TraversalUser> _traversalUserManager;

        public DestinationController(IDestinationService destinationService, UserManager<TraversalUser> traversalUserManager)
        {
            _destinationService = destinationService;
            _traversalUserManager = traversalUserManager;
        }

        public IActionResult Home()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }

        //[HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.id = id;
            ViewBag.destinationId = id;
            var user = await _traversalUserManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userId = user.Id;
            var value = _destinationService.GetDestinationWithGuide(id);
            return View(value);
        }

        //[HttpPost]
        //public IActionResult DestinationDetails(Destination p)
        //{
        //    return View();
        //}
    }
}
