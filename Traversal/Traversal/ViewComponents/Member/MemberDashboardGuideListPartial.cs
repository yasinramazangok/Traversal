using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class MemberDashboardGuideListPartial : ViewComponent
    {
        private readonly IAdminGuideService _guideService;

        public MemberDashboardGuideListPartial(IAdminGuideService guideService)
        {
            _guideService = guideService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _guideService.TGetListAsync();   
            return View(values);
        }
    }
}
