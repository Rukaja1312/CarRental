namespace CarRentalDemo.DTOs
{
    using CarRentalDemo.Models;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CarCreateDTO
    {      

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Brand { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Model { get; set; }

        [Required]
        [Range(1940, 2022)]
        public int Year { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Description { get; set; }

        public byte[] Images { get; set; }

        //[ForeignKey("Dealer")]
        //public int DealerId { get; set; }
        //
        //public Dealer Dealer { get; set; }
    }
}
