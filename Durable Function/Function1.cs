using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Durable_Function
{
    public static class Function1
    {
        //[FunctionName("Function1")]
        //public static void Run([CosmosDBTrigger(
        //    databaseName: "databaseName",
        //    collectionName: "collectionName",
        //    ConnectionStringSetting = "",
        //    LeaseCollectionName = "leases")]IReadOnlyList<Document> input, ILogger log)
        //{
        //    if (input != null && input.Count > 0)
        //    {
        //        log.LogInformation("Documents modified " + input.Count);
        //        log.LogInformation("First document Id " + input[0].Id);
        //    }
        //}
        [FunctionName("Chaining")]
        public static async void Run(
    [OrchestrationTrigger] IDurableOrchestrationContext context)
        {
            try
            {
                var x = await context.CallActivityAsync<object>("F1", null);
                var y = await context.CallActivityAsync<object>("F2", x);
                var z = await context.CallActivityAsync<object>("F3", y);
                //return await context.CallActivityAsync<object>("F4", z);
            }
            catch (System.Exception)
            {
                // Error handling or compensation goes here.
            }
        }
    }
}
