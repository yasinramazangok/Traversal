using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.AdminDashboard
{
    public class AdminDashboardGuideListPartial : ViewComponent
    {
        private readonly IGuideService _guideService;

        public AdminDashboardGuideListPartial(IGuideService guideService)
        {
            _guideService = guideService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _guideService.GetList();
            return View(values);
        }
    }
}
