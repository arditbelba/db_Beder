using BikeRent.Data.Models;
using BikeRent.Data.ViewModels;
using BikeRent.Data;

namespace BikeRent.Services
{
    public class ClientService : IClientService
    {
        readonly AppDbContext _db;
        public ClientService(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public List<Client> GetClient()
        {
            return _db.Clients.ToList();
        }
        
        public string AddClient(ClientVm ClientVm)
        {
            _db.Clients.Add(new Client
            {
                Email= ClientVm.Email,
                Name= ClientVm.Name,
                Password = ClientVm.Password,
            });
            _db.SaveChanges();
            return "Client added successfully!";
        }
        public string DeleteClient(ClientVm ClientVm)
        {
            var client = _db.Clients.FirstOrDefault(b => b.Name == ClientVm.Name);
            _db.Clients.Remove(client!);
            _db.SaveChanges();
            return "Client deleted successfully!";
        }
        public string UpdateClient(ClientVm clientVm)
        {
            var client = _db.Clients.FirstOrDefault(b => b.Name == clientVm.Name);
            client!.Password = clientVm.Password;
            _db.SaveChanges();
            return "Client updated uccessfully!";
        }
    }
}
