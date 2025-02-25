using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using Traversal.BusinessLayer.Abstracts;

namespace Traversal.ViewComponents.Default
{
    public class UIDefaultTestimonialsPartial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public UIDefaultTestimonialsPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.TGetListAsync();

            return View(values);
        }
    }
}
