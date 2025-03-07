using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DTOLayer.AdminDTOs.DestinationDtos;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class CityController : Controller
    {
        private readonly IAdminDestinationService _destinationService;

        public CityController(IAdminDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCityList()
        {
            var jsonValues = JsonConvert.SerializeObject(_destinationService.TGetListAsync());
            return Json(jsonValues);
        }

        public IActionResult GetById(int destinationId)
        {
            var jsonValues = JsonConvert.SerializeObject(_destinationService.TGetByIdAsync(destinationId));
            return Json(jsonValues);
        }

        [HttpPost]
        public IActionResult AddCity(AddDestinationDto dto)
        {
            _destinationService.TInsertAsync(dto);
            var jsonValues = JsonConvert.SerializeObject(dto);
            return Json(jsonValues);
        }

        public IActionResult DeleteCity(int id)
        {
            _destinationService.TDeleteAsync(id);
            return NoContent();
        }

        [HttpPost]
        public IActionResult UpdateCity(UpdateDestinationDto dto)
        {
            _destinationService.TUpdateAsync(dto);
            var jsonValues = JsonConvert.SerializeObject(dto);
            return Json(jsonValues);
        }
    }
}
