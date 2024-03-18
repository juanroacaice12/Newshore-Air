using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NewShoreAirAPI.Models;

namespace NewShoreAirAPI.Services
{
    public class FlightService
    {
        private readonly HttpClient _httpClient;

        public FlightService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<Flight[]> GetFlightsAsync()
        {
            var response = await _httpClient.GetAsync("https://recruiting-api.newshore.es/api/flights/0");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var flights = JsonConvert.DeserializeObject<Flight[]>(content);
                
                return flights ?? Array.Empty<Flight>(); 
            }
            else
            {
                throw new HttpRequestException($"Failed to get flights: {response.ReasonPhrase}");
            }
        }
    }
}
