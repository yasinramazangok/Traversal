using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class UIDefaultFeaturedPartial : ViewComponent
    {
        //private readonly IFeatureService _featureService;

        //public FeaturedPartial(IFeatureService featureService)
        //{
        //    _featureService = featureService;
        //}

        public IViewComponentResult Invoke()
        {
            //var values = _featureService.GetList();

            return View();
        }
    }
}
