using System.Collections.Generic;

namespace NewShoreAirAPI.Models
{
    public class Journey
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();
        public string Origin { get; set; } = "";
        public string Destination { get; set; } = "";
        public double Price { get; set; }
    }

    public class Flight
    {
        public Transport Transport { get; set; } = new Transport();
        public string Origin { get; set; } = "";
        public string Destination { get; set; } = "";
        public double Price { get; set; }
    }

    public class Transport
    {
        public string FlightCarrier { get; set; } = "";
        public string FlightNumber { get; set; } = "";
    }
}
