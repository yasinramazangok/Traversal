using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void Delete(Reservation entity)
        {
            _reservationDal.Delete(entity);
        }

        public Reservation GetById(int id)
        {
            return _reservationDal.GetById(id);
        }

        public List<Reservation> GetList()
        {
            return _reservationDal.GetList();
        }

        public List<Reservation> GetListOfAcceptedReservations(int id)
        {
            return _reservationDal.GetListOfAcceptedReservations(id);
        }

        public List<Reservation> GetListOfPastReservations(int id)
        {
            return _reservationDal.GetListOfPastReservations(id);
        }

        public List<Reservation> GetListOfPendingApprovalReservations(int id)
        {
            return _reservationDal.GetListOfPendingApprovalReservations(id);
        }

        public void Insert(Reservation entity)
        {
            _reservationDal.Insert(entity);
        }

        public void Update(Reservation entity)
        {
            _reservationDal.Update(entity);
        }
    }
}
