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
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _guideService.TGetListAsync();
            return View(values);
        }
    }
}
