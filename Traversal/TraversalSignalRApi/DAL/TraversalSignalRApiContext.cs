using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalSignalRApi.DAL
{
    public class TraversalSignalRApiContext : DbContext
    {
        public TraversalSignalRApiContext(DbContextOptions<TraversalSignalRApiContext> options) : base(options)
        {

        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
