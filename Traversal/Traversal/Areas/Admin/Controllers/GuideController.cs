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
        private readonly IAdminGuideService _guideService;

        public GuideController(IAdminGuideService guideService)
        {
            _guideService = guideService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _guideService.TGetListAsync());
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGuide(AddGuideDto dto)
        {
            _guideService.TInsertAsync(dto);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteGuide(int id)
        {
            _guideService.TDeleteAsync(id);
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
