using AspnetCoreAPI_Introduction.Entities;
using AspnetCoreAPI_Introduction.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreAPI_Introduction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;

        public CitiesController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _cityRepository.GetAllAsync();
            // maybe to control validation and null exception
            return Ok(list); //returns a message which writes 200 success code with a list. 
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var city = await _cityRepository.GetAsync(id);
            if (city == null)
            {
                return NotFound(id); // this code returns an error 
            }
            return Ok(city); // returns 200 status code
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] City city)
        {
            var addedCity = await _cityRepository.CreateAsync(city);
            return Created(string.Empty , addedCity); // returns 201 status code
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] City city)
        {
            var entity = await _cityRepository.GetAsync(city.Id);
            if (entity == null)
            {
                return NotFound(city.Id);
            }
            await _cityRepository.UpdateAsync(city);
            return NoContent(); // returns 204 status code message. We usually prefer to use NoContent() method. Which means that there is no any value to turns .
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var entity = await _cityRepository.GetAsync(id);
            if(entity == null)
            {
                return NotFound(id);
            }
            await _cityRepository.DeleteAsync(entity);
            return NoContent();
        }
    }
}
