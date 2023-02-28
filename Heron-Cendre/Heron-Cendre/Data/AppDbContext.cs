using Heron_Cendre.Models;
using Microsoft.EntityFrameworkCore;

namespace Heron_Cendre.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation_Chambre>().HasKey(am => new
            {
                am.ChambreId,
                am.ReservationId
            });
            modelBuilder.Entity<Reservation_Chambre>().HasOne(m => m.Chambre).WithMany(am => am.Reservations_Chambres).HasForeignKey(m => m.ChambreId);
            modelBuilder.Entity<Reservation_Chambre>().HasOne(m => m.Reservation).WithMany(am => am.Reservations_Chambres).HasForeignKey(m => m.ReservationId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Chambre> chambres { get; set; }

        public DbSet<Client> clients { get; set; }

        public DbSet<Evenement> evenements { get; set; }

        public DbSet<Menu> menu { get; set; }

        public DbSet<Prestation> prestations { get; set; }

        public DbSet<Reservation> reservation { get; set; }

        public DbSet<Table> table { get; set; }
    }
}
