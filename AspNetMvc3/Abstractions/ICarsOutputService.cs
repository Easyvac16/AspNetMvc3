using AspNetMvc3.Models;

namespace AspNetMvc3.Abstractions
{
    public interface ICarsOutputService
    {
        public abstract void SaveToFile(Car car, string fileName);
        public abstract void SaveToJson(Car cars, string fileName);
        public abstract List<Car> LoadFromJson(string fileName);
        public abstract List<Car> LoadFromFile(string fileName);
        public abstract bool CreateCar(CarViewModel model);
    }
}
