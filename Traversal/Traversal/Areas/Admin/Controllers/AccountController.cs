using Microsoft.AspNetCore.Mvc;
using Traversal.Areas.Admin.Models;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DTOLayer.AdminDTOs.AccountDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
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
