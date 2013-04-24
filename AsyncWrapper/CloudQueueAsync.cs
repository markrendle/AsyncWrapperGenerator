namespace Microsoft.WindowsAzure.Storage.Queue
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class CloudQueueAsync
    {
        public static Task CreateAsync(this CloudQueue instance)
        {
            var ar = instance.BeginCreate(null, null);
            return Task.Factory.FromAsync(ar, instance.EndCreate);
        }
        public static Task CreateAsync(this CloudQueue instance, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginCreate(options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndCreate);
        }
        public static Task<Boolean> CreateIfNotExistsAsync(this CloudQueue instance)
        {
            var ar = instance.BeginCreateIfNotExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndCreateIfNotExists);
        }
        public static Task<Boolean> CreateIfNotExistsAsync(this CloudQueue instance, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginCreateIfNotExists(options, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndCreateIfNotExists);
        }
        public static Task<Boolean> DeleteIfExistsAsync(this CloudQueue instance)
        {
            var ar = instance.BeginDeleteIfExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndDeleteIfExists);
        }
        public static Task<Boolean> DeleteIfExistsAsync(this CloudQueue instance, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDeleteIfExists(options, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndDeleteIfExists);
        }
        public static Task DeleteAsync(this CloudQueue instance)
        {
            var ar = instance.BeginDelete(null, null);
            return Task.Factory.FromAsync(ar, instance.EndDelete);
        }
        public static Task DeleteAsync(this CloudQueue instance, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDelete(options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDelete);
        }
        public static Task SetPermissionsAsync(this CloudQueue instance, QueuePermissions permissions)
        {
            var ar = instance.BeginSetPermissions(permissions, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetPermissions);
        }
        public static Task SetPermissionsAsync(this CloudQueue instance, QueuePermissions permissions, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginSetPermissions(permissions, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetPermissions);
        }
        public static Task<QueuePermissions> GetPermissionsAsync(this CloudQueue instance)
        {
            var ar = instance.BeginGetPermissions(null, null);
            return Task.Factory.FromAsync<QueuePermissions>(ar, instance.EndGetPermissions);
        }
        public static Task<QueuePermissions> GetPermissionsAsync(this CloudQueue instance, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginGetPermissions(options, operationContext, null, null);
            return Task.Factory.FromAsync<QueuePermissions>(ar, instance.EndGetPermissions);
        }
        public static Task<Boolean> ExistsAsync(this CloudQueue instance)
        {
            var ar = instance.BeginExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndExists);
        }
        public static Task<Boolean> ExistsAsync(this CloudQueue instance, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginExists(options, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndExists);
        }
        public static Task SetMetadataAsync(this CloudQueue instance)
        {
            var ar = instance.BeginSetMetadata(null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetMetadata);
        }
        public static Task SetMetadataAsync(this CloudQueue instance, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginSetMetadata(options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetMetadata);
        }
        public static Task FetchAttributesAsync(this CloudQueue instance)
        {
            var ar = instance.BeginFetchAttributes(null, null);
            return Task.Factory.FromAsync(ar, instance.EndFetchAttributes);
        }
        public static Task FetchAttributesAsync(this CloudQueue instance, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginFetchAttributes(options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndFetchAttributes);
        }
        public static Task AddMessageAsync(this CloudQueue instance, CloudQueueMessage message)
        {
            var ar = instance.BeginAddMessage(message, null, null);
            return Task.Factory.FromAsync(ar, instance.EndAddMessage);
        }
        public static Task AddMessageAsync(this CloudQueue instance, CloudQueueMessage message, TimeSpan? timeToLive, TimeSpan? initialVisibilityDelay, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginAddMessage(message, timeToLive, initialVisibilityDelay, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndAddMessage);
        }
        public static Task UpdateMessageAsync(this CloudQueue instance, CloudQueueMessage message, TimeSpan visibilityTimeout, MessageUpdateFields updateFields)
        {
            var ar = instance.BeginUpdateMessage(message, visibilityTimeout, updateFields, null, null);
            return Task.Factory.FromAsync(ar, instance.EndUpdateMessage);
        }
        public static Task UpdateMessageAsync(this CloudQueue instance, CloudQueueMessage message, TimeSpan visibilityTimeout, MessageUpdateFields updateFields, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginUpdateMessage(message, visibilityTimeout, updateFields, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndUpdateMessage);
        }
        public static Task DeleteMessageAsync(this CloudQueue instance, CloudQueueMessage message, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDeleteMessage(message, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDeleteMessage);
        }
        public static Task DeleteMessageAsync(this CloudQueue instance, String messageId, String popReceipt, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDeleteMessage(messageId, popReceipt, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDeleteMessage);
        }
        public static Task<IEnumerable<CloudQueueMessage>> GetMessagesAsync(this CloudQueue instance, Int32 messageCount)
        {
            var ar = instance.BeginGetMessages(messageCount, null, null);
            return Task.Factory.FromAsync<IEnumerable<CloudQueueMessage>>(ar, instance.EndGetMessages);
        }
        public static Task<IEnumerable<CloudQueueMessage>> GetMessagesAsync(this CloudQueue instance, Int32 messageCount, TimeSpan? visibilityTimeout, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginGetMessages(messageCount, visibilityTimeout, options, operationContext, null, null);
            return Task.Factory.FromAsync<IEnumerable<CloudQueueMessage>>(ar, instance.EndGetMessages);
        }
        public static Task<CloudQueueMessage> GetMessageAsync(this CloudQueue instance)
        {
            var ar = instance.BeginGetMessage(null, null);
            return Task.Factory.FromAsync<CloudQueueMessage>(ar, instance.EndGetMessage);
        }
        public static Task<CloudQueueMessage> GetMessageAsync(this CloudQueue instance, TimeSpan? visibilityTimeout, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginGetMessage(visibilityTimeout, options, operationContext, null, null);
            return Task.Factory.FromAsync<CloudQueueMessage>(ar, instance.EndGetMessage);
        }
        public static Task<IEnumerable<CloudQueueMessage>> PeekMessagesAsync(this CloudQueue instance, Int32 messageCount)
        {
            var ar = instance.BeginPeekMessages(messageCount, null, null);
            return Task.Factory.FromAsync<IEnumerable<CloudQueueMessage>>(ar, instance.EndPeekMessages);
        }
        public static Task<IEnumerable<CloudQueueMessage>> PeekMessagesAsync(this CloudQueue instance, Int32 messageCount, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginPeekMessages(messageCount, options, operationContext, null, null);
            return Task.Factory.FromAsync<IEnumerable<CloudQueueMessage>>(ar, instance.EndPeekMessages);
        }
        public static Task<CloudQueueMessage> PeekMessageAsync(this CloudQueue instance)
        {
            var ar = instance.BeginPeekMessage(null, null);
            return Task.Factory.FromAsync<CloudQueueMessage>(ar, instance.EndPeekMessage);
        }
        public static Task<CloudQueueMessage> PeekMessageAsync(this CloudQueue instance, QueueRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginPeekMessage(options, operationContext, null, null);
            return Task.Factory.FromAsync<CloudQueueMessage>(ar, instance.EndPeekMessage);
        }
    }
}
