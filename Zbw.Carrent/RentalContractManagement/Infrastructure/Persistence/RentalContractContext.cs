using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Zbw.Carrent.Classes;
using Zbw.Carrent.RentalContractManagement.Domain;
using RentalContract = Zbw.Carrent.Classes.RentalContract;

namespace Zbw.Carrent.RentalContractManagement.Infrastructure.Persistence
{
    public class RentalContractContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RentalContract>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<RentalContract>()
            .Property(c => c.Id);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Car> Rentals { get; }
    }
}
