using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sales3.Models;

namespace Sales3.Data
{
    public class Sales3Context : DbContext
    {
        public Sales3Context (DbContextOptions<Sales3Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }

    }
}
