using Microsoft.EntityFrameworkCore;
using NotificationScheduler.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationScheduler.Infrastructure.Data
{
    public class NotificationSchedulerContext : DbContext
    {
        public NotificationSchedulerContext(DbContextOptions<NotificationSchedulerContext> options) : base(options)
        {

        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CompanyName);
                entity.Property(e => e.CompanyNumber).HasMaxLength(10);
                entity.Property(e => e.CompanyType).HasConversion<int>();
                entity.Property(e => e.Market).HasConversion<int>();
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CompanyId);
                entity.Property(e => e.Notifications);
            });
        }
    }

}
