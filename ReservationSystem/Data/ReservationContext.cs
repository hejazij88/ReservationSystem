using Microsoft.EntityFrameworkCore;
using ReservationSystem.Models;

namespace ReservationSystem.Data;

public class ReservationContext:DbContext
{
    public ReservationContext(DbContextOptions<ReservationContext> options):base(options)
    {
        
    }

    public DbSet<Reservation> Reservations { get; set; }

}