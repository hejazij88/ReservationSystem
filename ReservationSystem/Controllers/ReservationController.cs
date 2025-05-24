using Microsoft.AspNetCore.Mvc;
using ReservationSystem.Models;
using ReservationSystem.Services;

namespace ReservationSystem.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ReservationService _reservationService;

        public ReservationController(ReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Reservation reservation)
        {
            var result = await _reservationService.CreateReservationAsync(reservation);
            if (result == null)
                return BadRequest("You Can't Pick This Time.");

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await _reservationService.GetAllAsync();
            return Ok(list);
        }
    }
}
