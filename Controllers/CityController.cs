using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SimpleTutorialWebApplication.Models;

namespace SimpleTutorialWebApplication.AddControllers
{
    [ApiController]
    [Route("api/cities")]
    public class CityController: ControllerBase {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities() {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id) {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(city => city.Id == id);
            return city == null ? NotFound() : Ok(city);
        }

    }
}