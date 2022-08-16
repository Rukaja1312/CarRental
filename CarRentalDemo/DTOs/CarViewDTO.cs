using CarRentalDemo.Models;

namespace CarRentalDemo.DTOs
{
    public class CarViewDTO
    {
        //[Required]
        //[MinLength(2)]
        //[MaxLength(30)]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        //[Required]
        //[MinLength(2)]
        //[MaxLength(30)]
        public string Model { get; set; }

        //[Required]
        //[Range(1940, 2022)]
        public int Year { get; set; }

        //[Required]
        //[MinLength(10)]
        //[MaxLength(500)]
        public string Description { get; set; }

        public byte[] Images { get; set; }
    }
}
