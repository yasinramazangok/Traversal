using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.DataAccessLayer.Concretes
{
    public class EfReservationDal : GenericRepositoryDal<Reservation>, IReservationDal
    {
        private readonly TraversalContext _traversalContext;

        public EfReservationDal(TraversalContext traversalContext) : base(traversalContext)
        {
            _traversalContext = traversalContext;
        }

        public override async Task<List<Reservation>> GetListAsync()
        {
            return await _traversalContext.Reservations
            .Include(reservation => reservation.TraversalUser)
            .Include(reservation => reservation.Destination)
            .ToListAsync();

        }

        public List<Reservation> GetListOfAcceptedReservations(int id)
        {
            using (var context = new TraversalContext())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.TraversalUserId == id).ToList();
            }
        }

        public List<Reservation> GetListOfPastReservations(int id)
        {
            using (var context = new TraversalContext())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.TraversalUserId == id).ToList();
            }
        }

        public List<Reservation> GetListOfPendingApprovalReservations(int id)
        {
            using (var context = new TraversalContext())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onay Bekliyor" && x.TraversalUserId == id).ToList();
            }
        }
    }
}
