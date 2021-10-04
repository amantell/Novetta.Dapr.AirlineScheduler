using System;
//using StackExchange.Redis;
using System.Collections.Generic;
using System.Data;
//using Newtonsoft.Json;
using System.Dynamic;
using System.Linq;
using Novetta.Dapr.AirlineScheduler.DataAccessLayer.Models;

namespace Novetta.Dapr.AirlineScheduler.DataAccessLayer
{
    class ScheduleAssembler
    {
        // ConnectionMultiplexer _connectionMultiplexer;
        // IDatabase _cache;
        // HashEntry[] _cities;
        // HashEntry[] _airlines;

        // public ScheduleAssembler(ConnectionMultiplexer connectionMultiplexer, IDatabase cache)
        // {
        //     _connectionMultiplexer = connectionMultiplexer;
        //     _cache = cache;
        // }

        // public void Run()
        // {
        //     GetMetadata();
        //     bool isRunning = true;
        //     while (isRunning)
        //     {
        //         try
        //         {
        //             GetData();
        //         } catch (Exception exception)
        //         {
        //             Console.WriteLine($"Exception: {exception.Message}");
        //             isRunning = false;
        //         }
        //     }
        // }

        // private void GetMetadata()
        // {
        //     _airlines = _cache.HashGetAll("Airlines");
        //     _cities = _cache.HashGetAll("Cities");
        // }

        // public List<IFlight> GetData()
        // {
        //     List<IFlight> flights = new List<IFlight>();
        //     List<Arrival> arrivals = new List<Arrival>();
        //     List<Departure> departures = new List<Departure>();

        //     try
        //     {
        //         while (arrivals.Count < 180)
        //         {
        //             arrivals.Add(GetArrival());
        //         }

        //         flights.AddRange(arrivals.OrderBy(a => a.ToTime));

        //         while (departures.Count < 180)
        //         {
        //             departures.Add(GetDeparture());
        //         }

        //         flights.AddRange(departures.OrderBy(d => d.ToTime));
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.Write(ex.Message);
        //     }
        //     return flights;
        // }

        // private Arrival GetArrival()
        // {
        //     DateTime[] startEndTimes = GetStartEndTimes();
        //     int[] cityIndexes = GetCityIndexes();
            
        //     return new Arrival()
        //     {
        //         FromCity = _cities[cityIndexes[0]].Value,
        //         ToCity = _cities[cityIndexes[1]].Value,
        //         FromTime = startEndTimes[0],
        //         ToTime = startEndTimes[1],
        //         Flight = GetAirline(),
        //         Notifications = GetNotification(true),
        //         Aircraft = "737"
        //     };
        // }

        // private string GetNotification(bool isArrival)
        // {
        //     Random random = new Random();
        //     int result = random.Next(0, 4);

        //     string flightType = (isArrival ? "arriving" : "departing");

        //     switch (result)
        //     {
        //         case 0:
        //         case 1:
        //         case 2:
        //             return string.Format(@"The plane is {0} on time.", flightType);
        //         case 3:
        //             return string.Format(@"The plane is {0} {1} minutes early.", flightType, random.Next(0, 15).ToString());
        //         case 4:
        //             return string.Format(@"The plane is delayed {0} minutes.", random.Next(0, 15).ToString());
        //     }

        //     return string.Format(@"The plane is {0} on time.", flightType);
        // }

        // private Departure GetDeparture()
        // {
        //     DateTime[] startEndTimes = GetStartEndTimes();
        //     int[] cityIndexes = GetCityIndexes();

        //     return new Departure()
        //     {
        //         FromCity = _cities[cityIndexes[0]].Value,
        //         ToCity = _cities[cityIndexes[1]].Value,
        //         FromTime = startEndTimes[0],
        //         ToTime = startEndTimes[1],
        //         Flight = GetAirline(),
        //         Notifications = GetNotification(false),
        //         Aircraft = "747"
        //     };
        // }

        // private int[] GetCityIndexes()
        // {
        //     Random random = new Random();
        //     int fromIndex = random.Next(0, _cities.Length - 1);
        //     int toIndex = random.Next(0, _cities.Length - 1);

        //     while (toIndex == fromIndex)
        //     {
        //         toIndex = random.Next(0, _cities.Length - 1);
        //     };
        //     return new int[] { fromIndex, toIndex };
        // }

        // private string GetAirline()
        // {
        //     Random random = new Random();
        //     return _airlines[random.Next(0, _airlines.Length - 1)].Value;
        // }

        // private DateTime[] GetStartEndTimes()
        // {
        //     Random random = new Random();

        //     int randomStartHour = random.Next(0, 23);
        //     int randomStartMinute = random.Next(0, 59);

        //     int randomEndHour = random.Next((randomStartHour == 23 ? 18 : randomStartHour), 23);
        //     int randomEndMinute = random.Next(0, 59);

        //     return new DateTime[]
        //     {
        //         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, randomStartHour, randomStartMinute, 0),
        //         new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, randomEndHour, randomEndMinute, 0),
        //     };
        // }
    }
}
