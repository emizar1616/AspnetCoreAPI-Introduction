using AspnetCoreAPI_Introduction.Data;
using AspnetCoreAPI_Introduction.Entities;
using AspnetCoreAPI_Introduction.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreAPI_Introduction.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly CityDbContext _context;

        public CityRepository(CityDbContext context)
        {
            _context = context;
        }

        public async Task<City> CreateAsync(City city)
        {
            await _context.Cities.AddAsync(city);
            await _context.SaveChangesAsync();          
            return city;
        }

        public async Task DeleteAsync(City city)
        {
            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<City> GetAsync(int id)
        {
            return await _context.Cities.FindAsync(id);
        }

        public async Task UpdateAsync(City city)
        {
            var orjCity = await _context.Cities.FirstOrDefaultAsync(x => x.Id == city.Id);
            _context.Entry(orjCity).CurrentValues.SetValues(city);
            await _context.SaveChangesAsync();
        }
    }
}
