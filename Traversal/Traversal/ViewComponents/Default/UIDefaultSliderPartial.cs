using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class UIDefaultSliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
