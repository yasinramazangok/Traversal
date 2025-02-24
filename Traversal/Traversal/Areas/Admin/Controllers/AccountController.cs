using Microsoft.AspNetCore.Mvc;
using Traversal.Areas.Admin.Models;
using Traversal.BusinessLayer.Abstract.AbstractUow;
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
            var valueSender = _accountService.TGetById(balanceTransferDto.SenderId);
            var valueReceiver = _accountService.TGetById(balanceTransferDto.ReceiverId);
            //senderid,receiverid,amount

            valueSender.Balance -= balanceTransferDto.Amount;
            valueReceiver.Balance += balanceTransferDto.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                valueSender,
                valueReceiver
            };

            _accountService.TMultiUpdate(modifiedAccounts);

            return View();
        }
    }
}
