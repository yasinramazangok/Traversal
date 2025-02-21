using TraversalApi.BusinessLayer.Abstract;
using TraversalApi.BusinessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using TraversalApi.DataAccessLayer.Abstract;
using TraversalApi.DataAccessLayer.Concrete; // for IServiceCollection

namespace TraversalApi.BusinessLayer.Containers
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessAndBusinessLayerServices(this IServiceCollection services)
        {
            services.AddScoped<IVisitorService, VisitorManager>();
            services.AddScoped<IVisitorDal, EfVisitorDal>();
        }
    }
}
