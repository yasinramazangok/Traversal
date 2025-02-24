using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DTOLayer.AdminDTOs.ContactDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Home(SendMessageDto sendMessageDto)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TInsert(new ContactUs()
                {
                    Message = sendMessageDto.Message,
                    Email = sendMessageDto.Email,
                    Status = true,
                    Name = sendMessageDto.Name,
                    Subject = sendMessageDto.Subject,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Home", "Default");
            }
            return View(sendMessageDto);
        }

    }
}
