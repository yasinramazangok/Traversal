using TraversalApi.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace TraversalApi.DataAccessLayer.Context
{
    public class TraversalApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=YASINRAMAZANGOK; initial catalog=TraversalApiDatabase; integrated security=true; trustservercertificate=true");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
