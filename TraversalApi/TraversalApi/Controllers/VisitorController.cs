using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TraversalApi.BusinessLayer.Abstract;
using TraversalApi.DTOLayer.VisitorDTOs;

namespace TraversalApi.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("api/[controller]")]
    public class VisitorController : ControllerBase
    {
        private readonly IVisitorService _visitorService;

        public VisitorController(IVisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        [HttpGet]
        public IActionResult GetVisitorList()
        {
            var values = _visitorService.TGetList();
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(values);
            }
        }

        [HttpPost]
        public IActionResult AddVisitor(AddVisitorDto addVisitorDto)
        {
            _visitorService.TInsert(addVisitorDto);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetVisitorById(int id)
        {
            var values = _visitorService.TGetById(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(values);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVisitor(int id)
        {
            _visitorService.TDelete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateVisitor(UpdateVisitorDto updateVisitorDto)
        {
            _visitorService.TUpdate(updateVisitorDto);
            return Ok();
        }
    }
}
