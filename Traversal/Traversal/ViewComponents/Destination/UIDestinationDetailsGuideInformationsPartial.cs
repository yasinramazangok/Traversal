using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;

namespace Traversal.ViewComponents.Destination
{
    public class UIDestinationDetailsGuideInformationsPartial : ViewComponent
    {
        private readonly IAdminGuideService _guideService;

        public UIDestinationDetailsGuideInformationsPartial(IAdminGuideService guideService)
        {
            _guideService = guideService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _guideService.TGetByIdAsync(1);
            return View(values);
        }
    }
}
