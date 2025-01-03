﻿using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            _guideService.Insert(guide);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteGuide(int id)
        {
            var value = _guideService.GetById(id);
            _guideService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateGuide(int id)
        {
            var values = _guideService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateGuide(Guide guide)
        {
            _guideService.Update(guide);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToTrue(int id)
        {
            _guideService.ChangeGuideStatusToTrue(id);
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToFalse(int id)
        {
            _guideService.ChangeGuideStatusToFalse(id);
            return RedirectToAction("Index");

            //return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
    }
}
