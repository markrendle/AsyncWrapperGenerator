namespace Microsoft.WindowsAzure.Storage.Table
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class CloudTableClientAsync
    {
        public static Task<TableResultSegment> ListTablesSegmentedAsync(this CloudTableClient instance, TableContinuationToken currentToken)
        {
            var ar = instance.BeginListTablesSegmented(currentToken, null, null);
            return Task.Factory.FromAsync<TableResultSegment>(ar, instance.EndListTablesSegmented);
        }
        public static Task<TableResultSegment> ListTablesSegmentedAsync(this CloudTableClient instance, String prefix, TableContinuationToken currentToken)
        {
            var ar = instance.BeginListTablesSegmented(prefix, currentToken, null, null);
            return Task.Factory.FromAsync<TableResultSegment>(ar, instance.EndListTablesSegmented);
        }
        public static Task<TableResultSegment> ListTablesSegmentedAsync(this CloudTableClient instance, String prefix, Int32? maxResults, TableContinuationToken currentToken, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginListTablesSegmented(prefix, maxResults, currentToken, requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync<TableResultSegment>(ar, instance.EndListTablesSegmented);
        }
        public static Task<ServiceProperties> GetServicePropertiesAsync(this CloudTableClient instance)
        {
            var ar = instance.BeginGetServiceProperties(null, null);
            return Task.Factory.FromAsync<ServiceProperties>(ar, instance.EndGetServiceProperties);
        }
        public static Task<ServiceProperties> GetServicePropertiesAsync(this CloudTableClient instance, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginGetServiceProperties(requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync<ServiceProperties>(ar, instance.EndGetServiceProperties);
        }
        public static Task SetServicePropertiesAsync(this CloudTableClient instance, ServiceProperties properties)
        {
            var ar = instance.BeginSetServiceProperties(properties, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetServiceProperties);
        }
        public static Task SetServicePropertiesAsync(this CloudTableClient instance, ServiceProperties properties, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginSetServiceProperties(properties, requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetServiceProperties);
        }
    }
}
