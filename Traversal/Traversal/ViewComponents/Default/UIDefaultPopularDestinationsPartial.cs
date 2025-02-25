using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;

namespace Traversal.ViewComponents.Default
{
    public class UIDefaultPopularDestinationsPartial : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public UIDefaultPopularDestinationsPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _destinationService.TGetListAsync();
            return View(values);
        }
    }
}
