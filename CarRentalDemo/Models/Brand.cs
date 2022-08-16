using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalDemo.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }

    }
}
