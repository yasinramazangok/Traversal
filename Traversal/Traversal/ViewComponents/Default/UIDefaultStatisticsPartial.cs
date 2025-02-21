using Microsoft.AspNetCore.Mvc;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.ViewComponents.Default
{
    public class UIDefaultStatisticsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new TraversalContext();

            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "285";

            return View();
        }
    }
}
