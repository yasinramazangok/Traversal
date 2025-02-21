using Traversal.BusinessLayer.Abstract.AbstractUow;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.UnitOfWork;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes.ConcreteUow
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUowDal _uowDal;
        public AccountManager(IAccountDal accountDal, IUowDal uowDal)
        {
            _accountDal = accountDal;
            _uowDal = uowDal;
        }

        public Account TGetById(int id)
        {
            return _accountDal.GetById(id);
        }

        public void TInsert(Account t)
        {
            _accountDal.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDal.Update(t);
            _uowDal.Save();
        }
    }
}
