using AspnetCoreAPI_Introduction.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreAPI_Introduction.Data
{
    public class CityDbContext : DbContext
    {
        public CityDbContext(DbContextOptions<CityDbContext> options) : base(options) { }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<City>().HasData(
                new City() { Id = 1, Name = "Istanbul", Region = "Marmara", Code = 34 },
                new City() { Id = 2, Name = "Izmir", Region = "Ege", Code = 35 },
                new City() { Id = 3, Name = "Ankara", Region = "İç Anadolu", Code = 06 },
                new City() { Id = 4, Name = "Antalya", Region = "Akdeniz", Code = 07 },
                new City() { Id = 5, Name = "Adana", Region = "Akdeniz", Code = 01 },
                new City() { Id = 6, Name = "Edirne", Region = "Marmara", Code = 22 }
                );
            base.OnModelCreating(modelBuilder);


        }

    }
}
