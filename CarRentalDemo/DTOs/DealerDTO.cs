namespace CarRentalDemo.DTOs
{
    using System.ComponentModel.DataAnnotations;

    public class DealerDTO
    {
        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
