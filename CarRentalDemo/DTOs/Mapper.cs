using AutoMapper;
using CarRentalDemo.Models;

namespace CarRentalDemo.DTOs
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Car, CarCreateDTO>();
            CreateMap<Car, CarViewDTO>();
            CreateMap<Car, CarEditDTO>();
            CreateMap<Dealer, DealerEditPhoneDTO>();
            CreateMap<Dealer, DealerCarsDTO>();
        }
    }
}
