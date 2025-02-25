using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Concretes;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public async Task TDeleteAsync(int id)
        {
            await _testimonialDal.DeleteAsync(id);
        }

        public async Task<Testimonial> TGetByIdAsync(int id)
        {
            return await _testimonialDal.GetByIdAsync(id);
        }

        public async Task<List<Testimonial>> TGetListAsync()
        {
            return await _testimonialDal.GetListAsync();
        }

        public async Task TInsertAsync(Testimonial dto)
        {
            await _testimonialDal.InsertAsync(dto);
        }

        public async Task TUpdateAsync(Testimonial dto)
        {
            await _testimonialDal.UpdateAsync(dto);
        }
    }
}
