using Microsoft.AspNetCore.Mvc;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.ViewComponents.AdminDashboard
{
    public class AdminDashboardCards1StatisticsPartial : ViewComponent
    {
        TraversalContext context = new TraversalContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Destinations.Count();
            ViewBag.v2 = context.Users.Count();
            return View();
        }
    }
}
