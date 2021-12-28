using HotelListing.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelListing.Controllers
{
    [ApiVersion("2.0", Deprecated = true)]
    [Route("api/country")]
    //[Route("api/country")] //https://localhost:44321/api/Country?api-version=2.0
    //[Route("api/{v:apiversion}/country")] //https://localhost:44321/api/2.0/Country
    [ApiController]
    public class CountryV2Controller : ControllerBase
    {
        #region Private Fields
        private readonly ApplicationDbContext _context;
        #endregion

        #region Ctor
        public CountryV2Controller(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetCountries() => Ok(_context.Countries);
    }
}
