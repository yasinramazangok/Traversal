using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
