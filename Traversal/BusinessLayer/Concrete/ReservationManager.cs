using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
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

        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetListWithReservationByWaitAprroval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitAprroval(id);
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
