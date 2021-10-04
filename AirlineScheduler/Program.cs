using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Dapr.Client;
using Novetta.Dapr.AirlineScheduler.DataAccessLayer;

namespace Novetta.Dapr.AirlineScheduler
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const string storename = "statestore";
            string[] keys  = new string[4] { "airlines", "cities", "arrivals", "departures" };
            var daprClient = new DaprClientBuilder().Build();
            for (int iCounter = 0; iCounter < keys.Length; iCounter++) {
                switch (keys[iCounter]) {
                    case "airlines":
                        await daprClient.SaveStateAsync(storename, keys[iCounter], Metadata.Airlines);
                        break;
                    case "cities":
                        await daprClient.SaveStateAsync(storename, keys[iCounter], Metadata.Cities);
                        break;

                }
                await Task.Delay(1000);
            }

            for (int iCounter = 0; iCounter < keys.Length; iCounter++) {
                switch (keys[iCounter]) {
                    case "airlines":
                    case "cities":
                        Dictionary<string, string> metaData = await daprClient.GetStateAsync<Dictionary<string, string>>(storename, keys[iCounter]);
                        Console.WriteLine($"{keys[iCounter]}");
                        foreach (KeyValuePair<string, string> keyValuePair in metaData) {
                            Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
                        }
                        break;
                }
                await Task.Delay(1000);
            }
        }
    }
}
