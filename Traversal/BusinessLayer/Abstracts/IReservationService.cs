using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IReservationService : IGenericReadonlyService<Reservation, Reservation, Reservation>, IGenericWriteService<Reservation, Reservation>
    {
        List<Reservation> GetListOfPendingApprovalReservations(int id);
        List<Reservation> GetListOfAcceptedReservations(int id);
        List<Reservation> GetListOfPastReservations(int id);
    }
}
