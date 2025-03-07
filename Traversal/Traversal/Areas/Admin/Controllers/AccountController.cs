using Microsoft.AspNetCore.Mvc;
using Traversal.Areas.Admin.Models;
using Traversal.BusinessLayer.Abstracts.AdminAbstracts;
using Traversal.DTOLayer.AdminDTOs.AccountDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly IAdminAccountService _accountService;

        public AccountController(IAdminAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BalanceTransferDto balanceTransferDto)
        {      
            _accountService.TMultiUpdate(balanceTransferDto);
            return View();
        }
    }
}
