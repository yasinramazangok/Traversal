using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class TestimonialsPartial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialsPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.GetList();

            return View(values);
        }
    }
}
