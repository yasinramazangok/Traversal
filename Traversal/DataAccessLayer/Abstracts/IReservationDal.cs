using Traversal.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DataAccessLayer.Abstracts
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListOfPendingApprovalReservations(int id);
        List<Reservation> GetListOfAcceptedReservations(int id);
        List<Reservation> GetListOfPastReservations(int id);
    }
}
