using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DTOLayer.AdminDTOs.AnnouncementDtos;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var values = _announcementService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AddAnnouncementDto dto)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TInsert(dto);
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            _announcementService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _announcementService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(UpdateAnnouncementDto dto)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(dto);
                return RedirectToAction("Index");
            }
            return View(dto);
        }
    }
}
