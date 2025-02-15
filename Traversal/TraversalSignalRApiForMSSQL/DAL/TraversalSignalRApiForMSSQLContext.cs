using Microsoft.EntityFrameworkCore;

namespace TraversalSignalRApiForMSSQL.DAL
{
    public class TraversalSignalRApiForMSSQLContext : DbContext
    {
        public TraversalSignalRApiForMSSQLContext(DbContextOptions<TraversalSignalRApiForMSSQLContext> options) : base(options)
        {

        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
