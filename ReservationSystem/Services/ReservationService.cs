using Microsoft.EntityFrameworkCore;
using ReservationSystem.Data;
using ReservationSystem.Models;

namespace ReservationSystem.Services;

public class ReservationService
{
    private readonly ReservationContext _context;

    public ReservationService(ReservationContext context)
    {
        _context = context;
    }

    public async Task<bool> IsTimeAvailableAsync(DateTime start, DateTime end)
    {
        return !await _context.Reservations.AnyAsync(r =>
            (start < r.EndDate && end > r.StartDate));
    }

    public async Task<Reservation?> CreateReservationAsync(Reservation reservation)
    {
        if (!await IsTimeAvailableAsync(reservation.StartDate, reservation.EndDate))
            return null;

        _context.Reservations.Add(reservation);
        await _context.SaveChangesAsync();
        return reservation;
    }

    public async Task<List<Reservation>> GetAllAsync()
    {
        return await _context.Reservations.OrderBy(r => r.StartDate).ToListAsync();
    }
}