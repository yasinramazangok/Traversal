﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class UIDefaultSubAboutPartial : ViewComponent
    {
        private readonly ISubAboutService _subAboutService;

        public UIDefaultSubAboutPartial(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _subAboutService.GetList();

            return View(values);
        }
    }
}
