using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalApi.DAL.Entities;

namespace TraversalApi.DAL.Context
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
