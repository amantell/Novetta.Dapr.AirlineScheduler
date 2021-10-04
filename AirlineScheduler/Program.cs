using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Dapr.Client;
using Novetta.Dapr.AirlineScheduler.DataAccessLayer;

namespace Novetta.Dapr.AirlineScheduler
{
    class Program
    {
        static async Task Main(string[] args)
        {
//            await StateStoreTest();

            await StateStoreTransactionTest();
        }

        private static async Task StateStoreTransactionTest() {
            const string storeName = "statestore";

            using var client = new DaprClientBuilder().Build();

            // State transactions operate on raw bytes
            var bytes = JsonSerializer.SerializeToUtf8Bytes(Metadata.Airlines);

            var requests = new List<StateTransactionRequest>()
            {
                new StateTransactionRequest("airlines", bytes, StateOperationType.Upsert),
                new StateTransactionRequest("oldairlines", null, StateOperationType.Delete)
            };
            
            Console.WriteLine("Executing transaction - save state and delete state");

            var cancellationToken = new CancellationToken();
            await client.ExecuteStateTransactionAsync(storeName, requests, cancellationToken: cancellationToken);
            Console.WriteLine("Executed State Transaction!");

            var state = await client.GetStateAsync<Dictionary<string, string>>(storeName, "airlines", cancellationToken: cancellationToken);
            if (state == null)
            {
                Console.WriteLine("State not found in store");
            }
            else
            {
                Console.WriteLine($"Transaction completed! Now iterate!");
                foreach (KeyValuePair<string, string> keyValuePair in state) {
                    Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
                }
            }
        }

        private static async Task StateStoreTest() {
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
