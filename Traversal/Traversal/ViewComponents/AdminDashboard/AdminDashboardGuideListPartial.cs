using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;

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
            var values = _guideService.TGetList();
            return View(values);
        }
    }
}
