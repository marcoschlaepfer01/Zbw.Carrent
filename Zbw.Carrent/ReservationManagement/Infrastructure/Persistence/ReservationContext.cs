using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Zbw.Carrent.Classes;
using Zbw.Carrent.ReservationManagement.Domain;
using Reservation = Zbw.Carrent.Classes.Reservation;

namespace Zbw.Carrent.ReservationManagement.Infrastructure.Persistence
{
    public class ReservationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Reservation>()
            .Property(c => c.Id);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Car> Reservations { get; }
    }
}
