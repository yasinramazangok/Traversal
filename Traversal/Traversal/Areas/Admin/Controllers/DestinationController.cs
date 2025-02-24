using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DTOLayer.AdminDTOs.DestinationDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(AddDestinationDto dto)
        {
            _destinationService.TInsert(dto);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            _destinationService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDestination(UpdateDestinationDto dto)
        {
            _destinationService.TUpdate(dto);
            return RedirectToAction("Index");
        }
    }
}
