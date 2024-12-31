using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.AdminDashboard
{
    public class AdminDashboardCards1Statistics : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Destinations.Count();
            ViewBag.v2 = context.Users.Count();
            return View();
        }
    }
}
