namespace ReservationClient.Model;

public class Reservation
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = "";
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Type { get; set; } = "";
}