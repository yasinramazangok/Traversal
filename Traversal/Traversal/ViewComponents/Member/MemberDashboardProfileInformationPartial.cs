using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.EntityLayer.Concretes;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class MemberDashboardProfileInformationPartial : ViewComponent
    {
        private readonly UserManager<TraversalUser> _userManager;

        public MemberDashboardProfileInformationPartial(UserManager<TraversalUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName = values.Name;
            ViewBag.memberPhone = values.PhoneNumber;
            ViewBag.memberEmail = values.Email;
            return View();
        }
    }
}
