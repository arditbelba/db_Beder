using BikeRent.Data;
using BikeRent.Data.Models;
using BikeRent.Data.ViewModels;

namespace BikeRent.Services
{
    public class BikeService : IBikeService
    {
        readonly AppDbContext _db;
        public BikeService(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public List<Bike> GetBikes()
        {
            return _db.Bikes.ToList();
        }

        public string AddBike(BikeVm bikeVm)
        {
            _db.Bikes.Add(new Bike
            {
                Color= bikeVm.Color,
                Description = bikeVm.Description,
                Name = bikeVm.Name,
                TireNumber = bikeVm.TireNumber,
                Type = bikeVm.Type,
            });
            _db.SaveChanges();
            return "Bike added successfully!";
        }
        public string DeleteBike(BikeVm bikeVm)
        {
            var bike = _db.Bikes.FirstOrDefault(b => b.Name == bikeVm.Name);
            _db.Bikes.Remove(bike);
            _db.SaveChanges();
            return "Bike deleted successfully!";
        }
        public string UpdateBike(BikeVm bikeVm)
        {
            var bike = _db.Bikes.FirstOrDefault(b => b.Name == bikeVm.Name);
            bike.Color = bikeVm.Color;
            bike.TireNumber = bikeVm.TireNumber;
            bike.Description = bikeVm.Description;
            _db.SaveChanges();
            return "Bike updated uccessfully!";
        }
    }
}
