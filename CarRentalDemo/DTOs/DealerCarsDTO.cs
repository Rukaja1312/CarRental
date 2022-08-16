using CarRentalDemo.Models;
using System.Collections;
using System.Collections.Generic;

namespace CarRentalDemo.DTOs
{
    public class DealerCarsDTO
    {
        public int Id { get; set; }

        public IEnumerable<Car> Cars { get; set; } 
    }
}
