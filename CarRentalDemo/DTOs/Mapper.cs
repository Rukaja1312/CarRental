namespace CarRentalDemo.DTOs
{
    using AutoMapper;
    using CarRentalDemo.Models;
    using System.Collections.Generic;

    public class Mapper : Profile
    {
        public Mapper()
        {
           CreateMap<CarCreateDTO, Car>();
            CreateMap<Car, CarViewDTO>();
            CreateMap<CarCreateOutOfIFormFileDTO, Car>();
           CreateMap<CarCreateDTO, CarCreateOutOfIFormFileDTO>();
            CreateMap<CarEditDTO, Car>();
            CreateMap<Car, CarEditDTO>();
            CreateMap<DealerCarsDTO, Car>();
            CreateMap<DealerDTO, Dealer>();
        }
    }
}
