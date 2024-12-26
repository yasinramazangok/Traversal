using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class PopularDestinationsPartial : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public PopularDestinationsPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.GetList();
            return View(values);
        }
    }
}
