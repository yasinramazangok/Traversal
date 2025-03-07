using Traversal.BusinessLayer.UnitOfWork;
using Traversal.DTOLayer.AdminDTOs.AccountDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts.AdminAbstracts
{
    public interface IAdminAccountService : IGenericUowService<Account>
    {
        void TMultiUpdate(BalanceTransferDto balanceTransferDto);
    }
}
