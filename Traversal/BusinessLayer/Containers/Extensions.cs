using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Traversal.BusinessLayer.Abstracts;
using Traversal.BusinessLayer.Abstracts.AdminAbstracts;
using Traversal.BusinessLayer.Concretes;
using Traversal.BusinessLayer.Concretes.AdminConcretes;
using Traversal.BusinessLayer.ValidationRules.AnnouncementValidationRules;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Concretes;
using Traversal.DataAccessLayer.UnitOfWork;
using Traversal.DTOLayer.AdminDTOs.AnnouncementDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAdminDestinationService, AdminDestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();

            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeatureDal, EfFeatureDal>();

            services.AddScoped<ISubAboutService, SubAboutManager>();
            services.AddScoped<ISubAboutDal, EfSubAboutDal>();

            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();

            services.AddScoped<IAdminCommentService, AdminCommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IAdminReservationService, AdminReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();

            services.AddScoped<IAdminGuideService, AdminGuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>();

            services.AddScoped<IAdminTraversalUserService, AdminTraversalUserManager>();
            services.AddScoped<ITraversalUserDal, EfTraversalUserDal>();

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IAdminContactUsService, AdminContactUsManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();

            services.AddScoped<IAdminAnnouncementService, AdminAnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            services.AddScoped<IAdminAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();

            services.AddScoped<IGenericUowDal<Account>, GenericUowDal<Account>>();
        }

        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AddAnnouncementDto>, AnnouncementValidator>();
        }
    }
}
