using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Destination
{
    public class UIDestinationDetailsGuideInformationsPartial : ViewComponent
    {
        private readonly IGuideService _guideService;

        public UIDestinationDetailsGuideInformationsPartial(IGuideService guideService)
        {
            _guideService = guideService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _guideService.GetById(1);
            return View(values);
        }
    }
}
