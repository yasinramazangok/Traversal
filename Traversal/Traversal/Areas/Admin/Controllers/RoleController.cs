using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.Areas.Admin.Models;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class RoleController : Controller
    {
        private readonly RoleManager<TraversalRole> _traversalRoleManager;
        private readonly UserManager<TraversalUser> _traversalUserManager;

        public RoleController(RoleManager<TraversalRole> traversalRoleManager, UserManager<TraversalUser> traversalUserManager)
        {
            _traversalRoleManager = traversalRoleManager;
            _traversalUserManager = traversalUserManager;
        }

        public IActionResult Index()
        {
            var values = _traversalRoleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel createRoleViewModel)
        {
            TraversalRole traversalRole = new TraversalRole()
            {
                Name = createRoleViewModel.Name
            };

            var result = await _traversalRoleManager.CreateAsync(traversalRole);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var value = _traversalRoleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _traversalRoleManager.DeleteAsync(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var value = _traversalRoleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel
            {
                RoleId = value.Id,
                Name = value.Name
            };
            return View(updateRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
        {
            var value = _traversalRoleManager.Roles.FirstOrDefault(x => x.Id == updateRoleViewModel.RoleId);
            value.Name = updateRoleViewModel.Name;
            await _traversalRoleManager.UpdateAsync(value);
            return RedirectToAction("Index");
        }

        public IActionResult GetUserList()
        {
            var values = _traversalUserManager.Users.ToList();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _traversalUserManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["UserId"] = user.Id;
            var roles = _traversalRoleManager.Roles.ToList();
            var userRoles = await _traversalUserManager.GetRolesAsync(user);
            List<AssignRoleViewModel> assignRoleViewModel = new List<AssignRoleViewModel>();
            foreach (var item in roles)
            {
                AssignRoleViewModel model = new AssignRoleViewModel();
                model.RoleId = item.Id;
                model.Name = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                assignRoleViewModel.Add(model);
            }
            return View(assignRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(List<AssignRoleViewModel> assignRoleViewModelList)
        {
            var userId = (int)TempData["UserId"];
            var user = _traversalUserManager.Users.FirstOrDefault(x => x.Id == userId);
            foreach (var item in assignRoleViewModelList)
            {
                if (item.RoleExist)
                {
                    await _traversalUserManager.AddToRoleAsync(user, item.Name);
                }
                else
                {
                    await _traversalUserManager.RemoveFromRoleAsync(user, item.Name);
                }
            }
            return RedirectToAction("GetUserList");
        }
    }
}
