using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Concretes;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class AdminReservationManager : IAdminReservationService
    {
        private readonly IReservationDal _reservationDal;

        public AdminReservationManager(IReservationDal reservationDal)
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

        public async Task TDeleteAsync(int id)
        {
            await _reservationDal.DeleteAsync(id);
        }

        public async Task<Reservation> TGetByIdAsync(int id)
        {
            return await _reservationDal.GetByIdAsync(id);
        }

        public async Task<List<Reservation>> TGetListAsync()
        {
            return await _reservationDal.GetListAsync();
        }

        public async Task TInsertAsync(Reservation dto)
        {
            await _reservationDal.InsertAsync(dto);
        }

        public async Task TUpdateAsync(Reservation dto)
        {
            await _reservationDal.UpdateAsync(dto);
        }
    }
}
