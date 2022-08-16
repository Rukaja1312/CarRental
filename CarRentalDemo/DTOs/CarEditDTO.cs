using System.ComponentModel.DataAnnotations;

namespace CarRentalDemo.DTOs
{
    public class CarEditDTO
    {
        [Required(ErrorMessage = "Description is Required!")]
        public string Descrioption { get; set; }
    }
}
