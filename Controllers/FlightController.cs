using Microsoft.AspNetCore.Mvc;
using NewShoreAirAPI.Models;
using NewShoreAirAPI.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewShoreAirAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly FlightService _flightService;

        public FlightController(FlightService flightService)
        {
            _flightService = flightService ?? throw new ArgumentNullException(nameof(flightService));
        }

        [HttpGet("route")]
        public async Task<ActionResult<Journey>> GetRoute(string origin, string destination)
        {
            if (string.IsNullOrEmpty(origin) || string.IsNullOrEmpty(destination))
            {
                return BadRequest("Origin and destination must be provided.");
            }

            var flights = await _flightService.GetFlightsAsync();

            if (flights == null)
            {
                return NotFound("No flights available."); // Devolver "Not Found" si no hay vuelos disponibles
            }

            var journey = new Journey
            {
                Origin = origin,
                Destination = destination,
                Flights = new List<Flight>(flights),
                Price = 0
            };

            return journey;
        }

        private decimal ConvertPriceToCurrency(decimal price, string currency)
        {
            
            return price;
        }

        private double ConvertPriceToDouble(decimal price, string currency)
        {
            return Convert.ToDouble(ConvertPriceToCurrency(price, currency));
        }
    }
}
