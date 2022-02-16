using Activity3a.Models;
using System.Globalization;

namespace Activity3a.ServicesCar
{
    public class HardCodedDataRepository : ICarDataService
    {
        static List<CarModel> carList = new List<CarModel>();
        public int Delete(CarModel car)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> GetAllCars()
        {
            DateOnly mydate1 = new DateOnly(2008, 01, 01);
            carList.Add(new CarModel
            {
                Id = 1,
                Name = "Opel Zafira 1.7TDI-6ск.",
                Date = mydate1.ToString("yyyy"),
                Fuel = "Disel",
            });

            DateOnly mydate2 = new DateOnly(2008, 01, 01);
            carList.Add(new CarModel
            {
                Id = 2,
                Name = "Ford Galaxy 7седалки",
                Date = mydate2.ToString("yyyy"),
                Fuel = "Disel",
            });
            DateOnly mydate3 = new DateOnly(2004, 10, 01);
            carList.Add(new CarModel
            {
                Id = 3,
                Name = "Opel Vectra 1.8i",
                Date = mydate3.ToString("yyyy"),
                Fuel = "Gasoline",
            });
            DateOnly mydate4 = new DateOnly(2010, 11, 01);
            carList.Add(new CarModel
            {
                Id = 4,
                Name = "Citroen DS3",
                Date = mydate4.ToString("yyyy"),
                Fuel = "Gasoline",
            });
            return carList;
        }



        public CarModel GetCarById(int carId)
        {
            throw new NotImplementedException();
        }

        public int Insert(CarModel car)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> SearchCar(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(CarModel car)
        {
            throw new NotImplementedException();
        }
    }
}
