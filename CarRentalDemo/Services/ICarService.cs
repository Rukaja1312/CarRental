namespace CarRentalDemo.Services
{
    using CarRentalDemo.DTOs;
    using CarRentalDemo.Models;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICarService
    {
        Task<List<CarViewDTO>> GetAllCars();
        Task<bool> CarCreate(CarCreateDTO carCreateDTO);
        Task<bool> Delete(int id);
        Task<Car> DeleteGet(int id);
        Task<bool> Edit(int carId, CarEditDTO carEditDTO);
        Task<CarEditDTO> Edit(int id);
        Task<List<CarViewDTO>> SortByBrand(int? id);
        SelectList BrandList();
    }
}
