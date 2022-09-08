namespace CarRentalDemo.Services
{
    using CarRentalDemo.DTOs;
    using CarRentalDemo.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDealerService
    {
        Task<List<CarViewDTO>> DealerCars();
        Task<bool> CreateDealer(DealerDTO dealerDTO);
        Task<bool> IsDealer(string id);
    }
}
