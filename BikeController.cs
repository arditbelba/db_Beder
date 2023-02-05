using BikeRent.Data.Models;
using BikeRent.Data.ViewModels;
using BikeRent.Services;
using Microsoft.AspNetCore.Mvc;

namespace BikeRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeController : ControllerBase
    {
        readonly IBikeService _service;
        public BikeController(IBikeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Bike> Get()
        {
            return _service.GetBikes();
        }

        [HttpPost]
        public string Post([FromBody] BikeVm value)
        {
            return _service.AddBike(value);
        }

        [HttpPut]
        public string Update([FromBody] BikeVm value)
        {
            return _service.UpdateBike(value);
        }

        [HttpDelete]
        public string Delete(BikeVm value)
        {
            return _service.DeleteBike(value);
        }
    }
}
