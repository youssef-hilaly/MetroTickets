using MetroTickets.Entities.DbSet;
using MetroTickets.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace MetroTickets.DataService.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Station> Stations { get; set; }
        public DbSet<Edge> Edges { get; set; }

        public AppDbContext(): base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"DataSource=Metro.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            GraphConstructionToDB graphHelper = new GraphConstructionToDB();
            modelBuilder.Entity<Station>().HasData(graphHelper.stationsArray);
            modelBuilder.Entity<Edge>().HasData(graphHelper.edgesArray);
        }
    }
}
