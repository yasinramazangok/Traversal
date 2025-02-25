using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.DataAccessLayer.Concretes
{
    public class EfTestimonialDal : GenericRepositoryDal<Testimonial>, ITestimonialDal
    {
        public EfTestimonialDal(TraversalContext traversalContext) : base(traversalContext)
        {
        }
    }
}
