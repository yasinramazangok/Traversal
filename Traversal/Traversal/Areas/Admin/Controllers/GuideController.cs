using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;
using Traversal.BusinessLayer.ValidationRules;
using Traversal.DTOLayer.AdminDTOs.GuideDtos;
using Traversal.EntityLayer.Concretes;


namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            return View(_guideService.TGetList());
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuide(AddGuideDto dto)
        {
            _guideService.TInsert(dto);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteGuide(int id)
        {
            _guideService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateGuide(int id)
        {
            return View(_guideService.TGetById(id));
        }

        [HttpPost]
        public IActionResult UpdateGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToTrue(int id)
        {
            _guideService.ChangeGuideStatusToTrue(id);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToFalse(int id)
        {
            _guideService.ChangeGuideStatusToFalse(id);
            return RedirectToAction("Index");

            //return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
    }
}
