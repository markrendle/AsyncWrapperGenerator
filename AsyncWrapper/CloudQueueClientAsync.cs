namespace Microsoft.WindowsAzure.Storage.Queue
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class CloudQueueClientAsync
    {
        public static Task<QueueResultSegment> ListQueuesSegmentedAsync(this CloudQueueClient instance, QueueContinuationToken currentToken)
        {
            var ar = instance.BeginListQueuesSegmented(currentToken, null, null);
            return Task.Factory.FromAsync<QueueResultSegment>(ar, instance.EndListQueuesSegmented);
        }
        public static Task<QueueResultSegment> ListQueuesSegmentedAsync(this CloudQueueClient instance, String prefix, QueueListingDetails blobListingDetails, Int32 maxResults, QueueContinuationToken currentToken, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginListQueuesSegmented(prefix, blobListingDetails, maxResults, currentToken, options, operationContext, null, null);
            return Task.Factory.FromAsync<QueueResultSegment>(ar, instance.EndListQueuesSegmented);
        }
        public static Task<ServiceProperties> GetServicePropertiesAsync(this CloudQueueClient instance)
        {
            var ar = instance.BeginGetServiceProperties(null, null);
            return Task.Factory.FromAsync<ServiceProperties>(ar, instance.EndGetServiceProperties);
        }
        public static Task<ServiceProperties> GetServicePropertiesAsync(this CloudQueueClient instance, QueueRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginGetServiceProperties(requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync<ServiceProperties>(ar, instance.EndGetServiceProperties);
        }
        public static Task SetServicePropertiesAsync(this CloudQueueClient instance, ServiceProperties properties)
        {
            var ar = instance.BeginSetServiceProperties(properties, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetServiceProperties);
        }
        public static Task SetServicePropertiesAsync(this CloudQueueClient instance, ServiceProperties properties, QueueRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginSetServiceProperties(properties, requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetServiceProperties);
        }
    }
}
