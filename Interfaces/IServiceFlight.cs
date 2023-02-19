using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        public List<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        IEnumerable<Flight> OrderedDurationFlights();
        IEnumerable<Traveller> SeniorTravellers(Flight f);
        IGrouping<string, IEnumerable<Flight>> DestinationGroupedFlights();

    }
}
public void GetFlights(string filterType, string filterValue)
{
    List<Flight> flights = new List<Flight>();

    if (filterType.Equals("Destination"))
    {

        foreach (var flight in Flights)
        {
            if (flight.Destination.Equals(filterValue))
            {
                flights.Add(flight);
                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);

            }
        }

    }
    if (filterType.Equals("PlaneType"))
    {

        foreach (var flight in Flights)
        {
            if (flight.plane.PlaneType.Equals(filterValue))
            {
                flights.Add(flight);
                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);

            }
        }

    }
    if (filterType.Equals("PlaneType"))
    {

        foreach (var flight in Flights)
        {
            if (flight.plane.PlaneType.Equals(filterValue))
            {
                flights.Add(flight);
                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);

            }
        }

    }
    if (filterType.Equals("FlightDate"))
    {

        foreach (var flight in Flights)
        {
            if (flight.FlightDate.Equals(filterValue))
            {
                flights.Add(flight);
                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);
            }
        }

    }
    if (filterType.Equals("EffectiveArrival"))
    {

        foreach (var flight in Flights)
        {
            if (flight.EffectiveArrival.Equals(filterValue))
            {
                flights.Add(flight);
                Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);

            }
        }

    }
}
