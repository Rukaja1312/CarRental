namespace CarRentalDemo.Models
{
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Car
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("BrandId")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

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

        [ForeignKey("Dealer")]
        public int DealerId { get; set; }

        public Dealer Dealer { get; set; }
    }
}
