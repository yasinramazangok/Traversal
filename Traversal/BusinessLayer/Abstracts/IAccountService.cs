using Traversal.BusinessLayer.UnitOfWork;
using Traversal.DTOLayer.AdminDTOs.AccountDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IAccountService : IGenericUowService<Account>
    {
        void TMultiUpdate(BalanceTransferDto balanceTransferDto);
    }
}
