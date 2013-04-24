namespace Microsoft.WindowsAzure.Storage.Table.DataServices
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class TableServiceContextAsync
    {
        public static Task<DataServiceResponse> SaveChangesWithRetriesAsync(this TableServiceContext instance)
        {
            var ar = instance.BeginSaveChangesWithRetries(null, null);
            return Task.Factory.FromAsync<DataServiceResponse>(ar, instance.EndSaveChangesWithRetries);
        }
        public static Task<DataServiceResponse> SaveChangesWithRetriesAsync(this TableServiceContext instance, SaveChangesOptions options)
        {
            var ar = instance.BeginSaveChangesWithRetries(options, null, null);
            return Task.Factory.FromAsync<DataServiceResponse>(ar, instance.EndSaveChangesWithRetries);
        }
        public static Task<DataServiceResponse> SaveChangesWithRetriesAsync(this TableServiceContext instance, SaveChangesOptions options, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginSaveChangesWithRetries(options, requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync<DataServiceResponse>(ar, instance.EndSaveChangesWithRetries);
        }
        public static Task<QueryOperationResponse> LoadPropertyAsync(this TableServiceContext instance, Object entity, String propertyName)
        {
            var ar = instance.BeginLoadProperty(entity, propertyName, null, null);
            return Task.Factory.FromAsync<QueryOperationResponse>(ar, instance.EndLoadProperty);
        }
        public static Task<QueryOperationResponse> LoadPropertyAsync(this TableServiceContext instance, Object entity, String propertyName, Uri nextLinkUri)
        {
            var ar = instance.BeginLoadProperty(entity, propertyName, nextLinkUri, null, null);
            return Task.Factory.FromAsync<QueryOperationResponse>(ar, instance.EndLoadProperty);
        }
        public static Task<QueryOperationResponse> LoadPropertyAsync(this TableServiceContext instance, Object entity, String propertyName, DataServiceQueryContinuation continuation)
        {
            var ar = instance.BeginLoadProperty(entity, propertyName, continuation, null, null);
            return Task.Factory.FromAsync<QueryOperationResponse>(ar, instance.EndLoadProperty);
        }
        public static Task<DataServiceStreamResponse> GetReadStreamAsync(this TableServiceContext instance, Object entity, DataServiceRequestArgs args)
        {
            var ar = instance.BeginGetReadStream(entity, args, null, null);
            return Task.Factory.FromAsync<DataServiceStreamResponse>(ar, instance.EndGetReadStream);
        }
        public static Task<DataServiceResponse> ExecuteBatchAsync(this TableServiceContext instance, params DataServiceRequest[] queries)
        {
            var ar = instance.BeginExecuteBatch(null, null, queries);
            return Task.Factory.FromAsync<DataServiceResponse>(ar, instance.EndExecuteBatch);
        }
        public static Task<DataServiceResponse> SaveChangesAsync(this TableServiceContext instance)
        {
            var ar = instance.BeginSaveChanges(null, null);
            return Task.Factory.FromAsync<DataServiceResponse>(ar, instance.EndSaveChanges);
        }
        public static Task<DataServiceResponse> SaveChangesAsync(this TableServiceContext instance, SaveChangesOptions options)
        {
            var ar = instance.BeginSaveChanges(options, null, null);
            return Task.Factory.FromAsync<DataServiceResponse>(ar, instance.EndSaveChanges);
        }
    }
}
