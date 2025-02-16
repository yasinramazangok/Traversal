using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraversalSignalRApiForMSSQL.DAL;
using TraversalSignalRApiForMSSQL.Models;

namespace TraversalSignalRApiForMSSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly VisitorService _visitorService;
        public VisitorController(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        [HttpGet]
        public IActionResult CreateVisitor()
        {
            Random random = new Random();
            Enumerable.Range(1, 10).ToList().ForEach(x =>
            {
                foreach (ECity item in Enum.GetValues(typeof(ECity)))
                {
                    var newVisitor = new Visitor
                    {
                        City = item,
                        VisitCount = random.Next(100, 2000),
                        Date = DateTime.UtcNow.AddDays(x)
                    };
                    _visitorService.SaveVisitor(newVisitor).Wait();
                    System.Threading.Thread.Sleep(1000);
                }
            });
            return Ok("Ziyaretçiler başarılı bir şekilde eklendi");
        }
    }
}
