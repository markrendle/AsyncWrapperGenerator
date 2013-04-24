namespace Microsoft.WindowsAzure.Storage.Table
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class EntityResolver`1Async
    {
        public static Task<T> InvokeAsync(this EntityResolver`1 instance, String partitionKey, String rowKey, DateTimeOffset timestamp, IDictionary<String,EntityProperty> properties, String etag, Object object)
        {
            var ar = instance.BeginInvoke(partitionKey, rowKey, timestamp, properties, etag, object, null, null);
            return Task.Factory.FromAsync<T>(ar, instance.EndInvoke);
        }
    }
}
