using Activity3a.Models;
namespace Activity3a.ServicesCar
{
    public interface ICarDataService
    {
        List<CarModel> GetAllCars();
        List<CarModel> SearchCar(string searchTerm);
        CarModel GetCarById(int carId);
        int Insert(CarModel car);
        int Delete(CarModel car);
        int Update(CarModel car);

    }
}
