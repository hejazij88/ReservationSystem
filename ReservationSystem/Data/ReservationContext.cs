using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReservationSystem.Models;
using ReservationSystem.Models.Auth;

namespace ReservationSystem.Data;

public class ReservationContext: IdentityDbContext<AppUser>
{
    public ReservationContext(DbContextOptions<ReservationContext> options):base(options)
    {
        
    }

    public DbSet<Reservation> Reservations { get; set; }

}