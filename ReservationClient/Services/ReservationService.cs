using ReservationClient.Model;

namespace ReservationClient.Services;

public class ReservationService
{
    private readonly HttpClient _http;

    public ReservationService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Reservation>> GetAllAsync()
    {
        return await _http.GetFromJsonAsync<List<Reservation>>("api/reservation") ?? new();
    }

    public async Task<bool> CreateAsync(Reservation reservation)
    {
        var response = await _http.PostAsJsonAsync("api/reservation", reservation);
        return response.IsSuccessStatusCode;
    }
}