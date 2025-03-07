using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ContactUsController : Controller
    {
        private readonly IAdminContactUsService _contactUsService;

        public ContactUsController(IAdminContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            return View(_contactUsService.TGetListContactUsByTrue());
        }
    }
}
