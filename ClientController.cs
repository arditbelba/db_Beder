using BikeRent.Data.Models;
using BikeRent.Data.ViewModels;
using BikeRent.Services;
using Microsoft.AspNetCore.Mvc;

namespace BikeRent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        readonly IClientService _service;
        public ClientController(IClientService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _service.GetClient();
        }

        [HttpPost]
        public string Post([FromBody] ClientVm value)
        {
            return _service.AddClient(value);
        }

        [HttpPut]
        public string Update([FromBody] ClientVm value)
        {
            return _service.UpdateClient(value);
        }

        [HttpDelete]
        public string Delete(ClientVm value)
        {
            return _service.DeleteClient(value);
        }
    }
}
