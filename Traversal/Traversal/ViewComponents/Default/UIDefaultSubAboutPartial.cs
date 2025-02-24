using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;

namespace Traversal.ViewComponents.Default
{
    public class UIDefaultSubAboutPartial : ViewComponent
    {
        private readonly ISubAboutService _subAboutService;

        public UIDefaultSubAboutPartial(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _subAboutService.TGetList();

            return View(values);
        }
    }
}
