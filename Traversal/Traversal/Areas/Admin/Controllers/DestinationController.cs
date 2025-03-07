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
        private readonly IAdminDestinationService _destinationService;

        public DestinationController(IAdminDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _destinationService.TGetListAsync();
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
            _destinationService.TInsertAsync(dto);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            _destinationService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.TGetByIdAsync(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDestination(UpdateDestinationDto dto)
        {
            _destinationService.TUpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
