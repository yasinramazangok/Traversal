using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public override List<Reservation> GetList()
        {
            using var context = new Context();

            return context.Reservations
                .Include(reservation => reservation.TraversalUser)
                .Include(reservation => reservation.Destination)
                .ToList();
        }

        public List<Reservation> GetListOfAcceptedReservations(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.TraversalUserId == id).ToList();
            }
        }

        public List<Reservation> GetListOfPastReservations(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.TraversalUserId == id).ToList();
            }
        }

        public List<Reservation> GetListOfPendingApprovalReservations(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onay Bekliyor" && x.TraversalUserId == id).ToList();
            }
        }
    }
}
