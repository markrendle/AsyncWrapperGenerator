namespace Microsoft.WindowsAzure.Storage.Table
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class CloudTableAsync
    {
        public static Task<TableResult> ExecuteAsync(this CloudTable instance, TableOperation operation)
        {
            var ar = instance.BeginExecute(operation, null, null);
            return Task.Factory.FromAsync<TableResult>(ar, instance.EndExecute);
        }
        public static Task<TableResult> ExecuteAsync(this CloudTable instance, TableOperation operation, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginExecute(operation, requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync<TableResult>(ar, instance.EndExecute);
        }
        public static Task<IList<TableResult>> ExecuteBatchAsync(this CloudTable instance, TableBatchOperation batch)
        {
            var ar = instance.BeginExecuteBatch(batch, null, null);
            return Task.Factory.FromAsync<IList<TableResult>>(ar, instance.EndExecuteBatch);
        }
        public static Task<IList<TableResult>> ExecuteBatchAsync(this CloudTable instance, TableBatchOperation batch, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginExecuteBatch(batch, requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync<IList<TableResult>>(ar, instance.EndExecuteBatch);
        }
        public static Task CreateAsync(this CloudTable instance)
        {
            var ar = instance.BeginCreate(null, null);
            return Task.Factory.FromAsync(ar, instance.EndCreate);
        }
        public static Task CreateAsync(this CloudTable instance, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginCreate(requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndCreate);
        }
        public static Task<Boolean> CreateIfNotExistsAsync(this CloudTable instance)
        {
            var ar = instance.BeginCreateIfNotExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndCreateIfNotExists);
        }
        public static Task<Boolean> CreateIfNotExistsAsync(this CloudTable instance, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginCreateIfNotExists(requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndCreateIfNotExists);
        }
        public static Task DeleteAsync(this CloudTable instance)
        {
            var ar = instance.BeginDelete(null, null);
            return Task.Factory.FromAsync(ar, instance.EndDelete);
        }
        public static Task DeleteAsync(this CloudTable instance, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginDelete(requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDelete);
        }
        public static Task<Boolean> DeleteIfExistsAsync(this CloudTable instance)
        {
            var ar = instance.BeginDeleteIfExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndDeleteIfExists);
        }
        public static Task<Boolean> DeleteIfExistsAsync(this CloudTable instance, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginDeleteIfExists(requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndDeleteIfExists);
        }
        public static Task<Boolean> ExistsAsync(this CloudTable instance)
        {
            var ar = instance.BeginExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndExists);
        }
        public static Task<Boolean> ExistsAsync(this CloudTable instance, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginExists(requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndExists);
        }
        public static Task<TablePermissions> GetPermissionsAsync(this CloudTable instance)
        {
            var ar = instance.BeginGetPermissions(null, null);
            return Task.Factory.FromAsync<TablePermissions>(ar, instance.EndGetPermissions);
        }
        public static Task<TablePermissions> GetPermissionsAsync(this CloudTable instance, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginGetPermissions(requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync<TablePermissions>(ar, instance.EndGetPermissions);
        }
        public static Task SetPermissionsAsync(this CloudTable instance, TablePermissions permissions)
        {
            var ar = instance.BeginSetPermissions(permissions, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetPermissions);
        }
        public static Task SetPermissionsAsync(this CloudTable instance, TablePermissions permissions, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginSetPermissions(permissions, requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetPermissions);
        }
    }
}
