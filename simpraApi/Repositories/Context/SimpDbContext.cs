using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Context
{
    public class SimpDbContext : DbContext
    {
        public DbSet<Staff> Staff { get; set; }

        public SimpDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new StaffConfig());
        }
    }
}
