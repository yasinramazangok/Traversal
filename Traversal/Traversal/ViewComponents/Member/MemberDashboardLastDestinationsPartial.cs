using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class MemberDashboardLastDestinationsPartial : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public MemberDashboardLastDestinationsPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.GetRecentDestinations();
            return View(values);
        }
    }
}
