using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NovoTeste.Models
{
    public class NovoTesteContext : DbContext
    {
        public NovoTesteContext (DbContextOptions<NovoTesteContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
