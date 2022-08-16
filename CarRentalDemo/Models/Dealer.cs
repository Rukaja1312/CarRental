using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalDemo.Models
{
    public class Dealer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        public IEnumerable<Car> Cars { get; set; }
    }
}
