namespace CarRentalDemo.Services
{
    using CarRentalDemo.DTOs;
    using CarRentalDemo.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICarService
    {
        Task<IEnumerable<Car>> GetAllCars();

        Car CarCreate(CarCreateDTO carCreateDTO);//string brand, string model, string description, byte[] image, int year, int dealerId);

        void Delete(int id);

        void Edit(int carId, string brand, string model, string description, string imageUrl, int yea);
    }
}
