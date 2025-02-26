using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DTOLayer.AdminDTOs.AccountDtos;

namespace Traversal.BusinessLayer.UnitOfWork
{
    public interface IGenericUowService<T> where T : class
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TMultiUpdate(T t);
        T TGetById(int id);
    }
}
