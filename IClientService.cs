using BikeRent.Data.Models;
using BikeRent.Data.ViewModels;

namespace BikeRent.Services
{
    public interface IClientService
    {
        List<Client> GetClient();
        string AddClient(ClientVm ClientVm);
        string DeleteClient(ClientVm ClientVm);
        string UpdateClient(ClientVm clientVm);
    }
}
