namespace Microsoft.WindowsAzure.Storage.Table.DataServices
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class TableServiceQuery`1Async
    {
        public static Task<TableQuerySegment<TElement>> ExecuteSegmentedAsync(this TableServiceQuery`1 instance, TableContinuationToken currentToken)
        {
            var ar = instance.BeginExecuteSegmented(currentToken, null, null);
            return Task.Factory.FromAsync<TableQuerySegment<TElement>>(ar, instance.EndExecuteSegmented);
        }
        public static Task<TableQuerySegment<TElement>> ExecuteSegmentedAsync(this TableServiceQuery`1 instance, TableContinuationToken currentToken, TableRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginExecuteSegmented(currentToken, requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync<TableQuerySegment<TElement>>(ar, instance.EndExecuteSegmented);
        }
    }
}
