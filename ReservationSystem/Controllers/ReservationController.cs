using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using ReservationSystem.Models;
using ReservationSystem.Services;

namespace ReservationSystem.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IHubContext _hubContext;

        private readonly ReservationService _reservationService;

        public ReservationController(ReservationService reservationService, IHubContext hubContext)
        {
            _reservationService = reservationService;
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Reservation reservation)
        {
            var result = await _reservationService.CreateReservationAsync(reservation);
            if (result == null)
                return BadRequest("You Can't Pick This Time.");


            await _hubContext.Clients.All.SendAsync("ReservationMade",result);
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
