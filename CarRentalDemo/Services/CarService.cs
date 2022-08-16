using AutoMapper;
using CarRentalDemo.Data;
using CarRentalDemo.DTOs;
using CarRentalDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalDemo.Services
{
    public class CarService : ICarService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CarService(ApplicationDbContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public Car CarCreate(CarCreateDTO  carCreateDTO)//string brand, string model, string description, byte[] image, int year, int dealerId)
        {

            //CarCreateDTO car = new CarCreateDTO
            //{
            //    Brand = brand,
            //    Model = model,
            //    Description = description,
            //    Images = image,
            //    Year = year,
            //    //DealerId = dealerId
            //};
            //context.Cars.Add(car);
            //context.SaveChanges();

            Car car = this.mapper.Map<Car>(carCreateDTO);
            return car;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Car>> GetAllCars()
        {
            var cars = await context.Cars.Include(x=>x.Brand).Include(x => x.Dealer).ToListAsync();
            return cars;
        }

        public void Edit(int carId, string brand, string model, string description, string imageUrl, int yea)
        {
            throw new System.NotImplementedException();
        }
    }
}
