﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class MemberLastDestinationsPartial : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public MemberLastDestinationsPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            //var values = _destinationService.TGetLast4Destinations();
            return View();
        }
    }
}
