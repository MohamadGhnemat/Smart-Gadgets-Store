using System.Collections.Generic;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;

namespace smartGadgetsStore.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Brand> Brand{ get; set; }
    }
}
