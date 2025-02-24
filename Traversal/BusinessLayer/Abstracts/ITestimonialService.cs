using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface ITestimonialService : IGenericReadonlyService<Testimonial, Testimonial>, IGenericWriteService<Testimonial, Testimonial>
    {
    }
}
