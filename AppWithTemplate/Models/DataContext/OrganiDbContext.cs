using AppWithTemplate.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWithTemplate.Models.DataContext
{
    public class OrganiDbContext : DbContext
    {
        public OrganiDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<AppInfo> AppInfo { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>(e =>
            {
                e.Property(p => p.CreatedDate)
                    .HasDefaultValueSql("DATEADD(HOUR,4,GETUTCDATE())");
            });

            modelBuilder.Entity<AppInfo>(e => {
                e.Property(p => p.CreatedDate)
                    .HasDefaultValueSql("DATEADD(HOUR,4,GETUTCDATE())");
            });
        }
    }
}
