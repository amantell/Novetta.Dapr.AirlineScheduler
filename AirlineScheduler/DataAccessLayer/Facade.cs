using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using StackExchange.Redis;
using System.Threading.Tasks;

namespace Novetta.Dapr.AirlineScheduler.DataAccessLayer
{
    public class Facade
    {
        // ConnectionMultiplexer _connectionMultiplexer;
        // IDatabase _cache;
        // string _host = "localhost:6379,allowAdmin=true";
        // EndPoint[] _endpoints;
        // IServer _server;
        // string[] _keys;
        // bool _hasMetadata = false;

        // public bool HasMetadata
        // {
        //     get { return _hasMetadata; }
        // }

        // public bool IsDatabaseOpen
        // {
        //     get { return (_cache != null); }
        // }

        // public List<string> KeyList { 
        //     get
        //     {
        //         return GetKeyList();
        //     } 
        // }

        // public Facade()
        // {
        //     Initialize();
        //     _keys = new string[4] { "airlines", "cities", "arrivals", "departures" };
        // }

        // public void FlushDatabase()
        // {
        //     _endpoints = _connectionMultiplexer.GetEndPoints();
        //     _server = _connectionMultiplexer.GetServer(_endpoints[0]);
        //     _server.FlushDatabase();
        // }

        // public void WriteMetadataKeys()
        // {
        //     try
        //     {
        //         IBatch batch = _cache.CreateBatch();

        //         for (int iCounter = 0; iCounter < _keys.Length; iCounter++)
        //         {
        //             switch (_keys[iCounter])
        //             {
        //                 case "airlines":
        //                     WriteAirlines(batch);
        //                     break;
        //                 case "cities":
        //                     WriteCities(batch);
        //                     break;
        //             }
        //         }
        //         batch.Execute();
        //        _hasMetadata = true;
        //     }
        //     catch (Exception exception)
        //     {
        //         Console.WriteLine($"Exception: {exception.Message}");
        //         _hasMetadata = false;
        //     }
        // }

        // public void SetSchedule()
        // {
        //     ScheduleAssembler scheduleAssembler = new ScheduleAssembler(_connectionMultiplexer, _cache);
        //     scheduleAssembler.Run();
        // }

        // private void WriteAirlines(IBatch batch)
        // {
        //     List<HashEntry> hashEntries = new List<HashEntry>();
        //     Metadata.Airlines.ToList().ForEach(
        //         a =>
        //         {
        //             hashEntries.Add(new HashEntry(a.Key, a.Value));
        //         }
        //     );
        //     batch.HashSetAsync($"Airlines", hashEntries.ToArray());
        // }

        // private void WriteCities(IBatch batch)
        // {
        //     List<HashEntry> hashEntries = new List<HashEntry>();
        //     Metadata.Cities.ToList().ForEach(
        //         c =>
        //         {
        //             hashEntries.Add(new HashEntry(c.Key, c.Value));
        //         }
        //     );
        //     batch.HashSetAsync($"Cities", hashEntries.ToArray());
        // }

        // private List<string> GetKeyList()
        // {
        //     List<string> result = new List<string>();
        //     _endpoints = _connectionMultiplexer.GetEndPoints();
        //     _server = _connectionMultiplexer.GetServer(_endpoints[0]);
        //     var keys = _server.Keys();
        //     IEnumerator ide = keys.GetEnumerator();
        //     while (ide.MoveNext())
        //     {
        //         result.Add(ide.Current.ToString());
        //     }
        //     return result;
        // }

        // private void Initialize()
        // {
        //     try
        //     {
        //         _connectionMultiplexer = ConnectionMultiplexer.Connect(_host);
        //         _cache = _connectionMultiplexer.GetDatabase();            
        //     }
        //     catch (Exception exception)
        //     {
        //         Console.WriteLine(exception.Message);
        //     }
        // }
    }
}
