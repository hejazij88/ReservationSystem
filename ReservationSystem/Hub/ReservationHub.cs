using Microsoft.AspNetCore.SignalR;
using ReservationSystem.Models;

namespace ReservationSystem.Hub;


public class ReservationHub:Microsoft.AspNetCore.SignalR.Hub
{
    public async Task SendReservation(Reservation reservation)
    {
        await Clients.All.SendAsync("ReservationMade",reservation);
    }
}