using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Traversal.Areas.Member.Models;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<TraversalUser> _userManager;

        public ProfileController(UserManager<TraversalUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditViewModel userEditViewModel = new UserEditViewModel();

            userEditViewModel.Name = values.Name;
            userEditViewModel.Username = values.UserName;
            userEditViewModel.Email = values.Email;
            userEditViewModel.Email = values.Email;
            userEditViewModel.PhoneNumber = values.PhoneNumber;


            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return NotFound("Kullanıcı bulunamadı.");
            }

            if (userEditViewModel.Image != null && userEditViewModel.Image.Length > 0)
            {
                var extension = Path.GetExtension(userEditViewModel.Image.FileName);
                if (string.IsNullOrEmpty(extension) || !new[] { ".jpg", ".jpeg", ".png", ".gif" }.Contains(extension.ToLower()))
                {
                    ModelState.AddModelError("", "Geçersiz dosya türü. Lütfen bir resim yükleyin.");
                    return View();
                }
                var resource = Directory.GetCurrentDirectory();
                var imageName = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/UserImages/" + imageName;
                await using (var stream = new FileStream(savelocation, FileMode.Create))
                {
                    userEditViewModel.Image.CopyToAsync(stream);
                }
                user.ImageUrl = imageName;
            }
            user.Name = userEditViewModel.Name;
            user.UserName = userEditViewModel.Username;
            user.Email = userEditViewModel.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
            user.PhoneNumber = userEditViewModel.PhoneNumber;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }
            return View();
        }
    }
}
