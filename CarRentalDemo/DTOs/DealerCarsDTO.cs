namespace CarRentalDemo.DTOs
{
    using CarRentalDemo.Models;
    using System.Collections.Generic;

    public class DealerCarsDTO
    {
        public IEnumerable<Car> Cars { get; set; } 
    }
}
