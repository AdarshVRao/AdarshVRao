using System;
using Microsoft.EntityFrameworkCore;
using Core.Models;
namespace DataLayer.EF
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Projects> Projects { get;set;} 

        public DbSet<Tickets> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Projects>()
                .HasMany(o => o.Tickets)
                .WithOne(x => x.Projects)
                .HasForeignKey(k => k.TicketId);

            //modelBuilder.Entity<Projects>().HasData(
            //    new Projects { ProjectId = 1, ProjectName = "Project1"},
            //    new Projects { ProjectId = 2, ProjectName = "Project2" }
            //    );

            modelBuilder.Entity<Tickets>().HasData(
                new Tickets { TicketId = 1, OwnerName = "one"},
                 new Tickets { TicketId = 2, OwnerName = "two" },
                  new Tickets { TicketId = 3, OwnerName = "Three" }
                );
        } 
    }
}
