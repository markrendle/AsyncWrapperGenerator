namespace Microsoft.WindowsAzure.Storage.Blob
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class CloudBlobDirectoryAsync
    {
        public static Task<BlobResultSegment> ListBlobsSegmentedAsync(this CloudBlobDirectory instance, BlobContinuationToken currentToken)
        {
            var ar = instance.BeginListBlobsSegmented(currentToken, null, null);
            return Task.Factory.FromAsync<BlobResultSegment>(ar, instance.EndListBlobsSegmented);
        }
        public static Task<BlobResultSegment> ListBlobsSegmentedAsync(this CloudBlobDirectory instance, Boolean useFlatBlobListing, BlobListingDetails blobListingDetails, Int32? maxResults, BlobContinuationToken currentToken, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginListBlobsSegmented(useFlatBlobListing, blobListingDetails, maxResults, currentToken, options, operationContext, null, null);
            return Task.Factory.FromAsync<BlobResultSegment>(ar, instance.EndListBlobsSegmented);
        }
    }
}
