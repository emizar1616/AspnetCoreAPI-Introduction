using AspnetCoreAPI_Introduction.Entities;

namespace AspnetCoreAPI_Introduction.Interfaces
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllAsync();
        Task<City> GetAsync(int id);
        Task<City> CreateAsync(City city);
        Task UpdateAsync(City city);  
        Task DeleteAsync(City city);


    }
}
