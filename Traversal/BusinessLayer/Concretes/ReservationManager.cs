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

        public void TDelete(int id)
        {
            var reservation = _reservationDal.GetById(id);
            _reservationDal.Delete(reservation);
        }

        public Reservation TGetById(int id)
        {
            return _reservationDal.GetById(id);
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public void TInsert(Reservation dto)
        {
            _reservationDal.Insert(dto);
        }

        public void TUpdate(Reservation dto)
        {
            _reservationDal.Update(dto);
        }
    }
}
