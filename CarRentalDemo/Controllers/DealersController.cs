namespace CarRentalDemo.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using CarRentalDemo.Services;
    using CarRentalDemo.DTOs;
    using Microsoft.AspNetCore.Authorization;

    public class DealersController : Controller
    {
        private readonly IDealerService dealerService;

        public DealersController(IDealerService dealerService)
        {
            this.dealerService = dealerService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(DealerDTO dealerDTO)
        {
            var dealer = await dealerService.CreateDealer(dealerDTO);
            if (!dealer)
            {
                return View(dealer);
            }
            return RedirectToAction("Index","Cars");
        }

        [Authorize]
        public async Task<IActionResult> MyCars()
        {
            var myCars = await dealerService.DealerCars();

            return View(myCars);
        }        
    }
}
