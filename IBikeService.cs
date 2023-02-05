using BikeRent.Data.Models;
using BikeRent.Data.ViewModels;

namespace BikeRent.Services
{
    public interface IBikeService
    {
        List<Bike> GetBikes();
        string AddBike(BikeVm bikeVm);
        string DeleteBike(BikeVm bikeVm);
        string UpdateBike(BikeVm bikeVm);
    }
}
