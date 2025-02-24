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
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonValues = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonValues);
        }

        public IActionResult GetById(int destinationId)
        {
            var jsonValues = JsonConvert.SerializeObject(_destinationService.TGetById(destinationId));
            return Json(jsonValues);
        }

        [HttpPost]
        public IActionResult AddCity(AddDestinationDto dto)
        {
            _destinationService.TInsert(dto);
            var jsonValues = JsonConvert.SerializeObject(dto);
            return Json(jsonValues);
        }

        public IActionResult DeleteCity(int id)
        {
            _destinationService.TDelete(id);
            return NoContent();
        }

        public IActionResult UpdateCity(UpdateDestinationDto dto)
        {
            _destinationService.TUpdate(dto);
            var jsonValues = JsonConvert.SerializeObject(dto);
            return Json(jsonValues);
        }
    }
}
