using Traversal.BusinessLayer.Abstracts.AdminAbstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.UnitOfWork;
using Traversal.DTOLayer.AdminDTOs.AccountDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes.AdminConcretes
{
    public class AccountManager : IAdminAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IGenericUowDal<Account> _genericUowDal;

        public AccountManager(IAccountDal accountDal, IGenericUowDal<Account> genericUowDal)
        {
            _accountDal = accountDal;
            _genericUowDal = genericUowDal;
        }

        public Account TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Account t)
        {
            throw new NotImplementedException();
        }

        public void TMultiUpdate(BalanceTransferDto balanceTransferDto)
        {
            var sender = _accountDal.GetById(balanceTransferDto.SenderId);
            var receiver = _accountDal.GetById(balanceTransferDto.ReceiverId);
            //senderid,receiverid,amount

            if (sender == null || receiver == null)
            {
                throw new Exception("Gönderen veya alıcı hesap bulunamadı.");
            }

            if (sender.Balance < balanceTransferDto.Amount)
            {
                throw new Exception("Bakiye yetersiz.");
            }

            sender.Balance -= balanceTransferDto.Amount;
            receiver.Balance += balanceTransferDto.Amount;

            List<Account> updatedAccounts = new List<Account>()
            {
                sender,
                receiver
            };

            try
            {
                _genericUowDal.BeginTransaction();

                _accountDal.MultiUpdate(updatedAccounts);
                _genericUowDal.Commit();
            }
            catch (Exception)
            {
                _genericUowDal.Rollback();
                throw;
            }
        }

        public void TMultiUpdate(Account t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Account t)
        {
            throw new NotImplementedException();
        }
    }
}
