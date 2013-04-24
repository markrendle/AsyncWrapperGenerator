namespace Microsoft.WindowsAzure.Storage.Blob
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class CloudBlobClientAsync
    {
        public static Task<ContainerResultSegment> ListContainersSegmentedAsync(this CloudBlobClient instance, BlobContinuationToken continuationToken)
        {
            var ar = instance.BeginListContainersSegmented(continuationToken, null, null);
            return Task.Factory.FromAsync<ContainerResultSegment>(ar, instance.EndListContainersSegmented);
        }
        public static Task<ContainerResultSegment> ListContainersSegmentedAsync(this CloudBlobClient instance, String prefix, ContainerListingDetails detailsIncluded, Int32? maxResults, BlobContinuationToken continuationToken, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginListContainersSegmented(prefix, detailsIncluded, maxResults, continuationToken, options, operationContext, null, null);
            return Task.Factory.FromAsync<ContainerResultSegment>(ar, instance.EndListContainersSegmented);
        }
        public static Task<BlobResultSegment> ListBlobsSegmentedAsync(this CloudBlobClient instance, String prefix, BlobContinuationToken currentToken)
        {
            var ar = instance.BeginListBlobsSegmented(prefix, currentToken, null, null);
            return Task.Factory.FromAsync<BlobResultSegment>(ar, instance.EndListBlobsSegmented);
        }
        public static Task<BlobResultSegment> ListBlobsSegmentedAsync(this CloudBlobClient instance, String prefix, Boolean useFlatBlobListing, BlobListingDetails blobListingDetails, Int32? maxResults, BlobContinuationToken currentToken, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginListBlobsSegmented(prefix, useFlatBlobListing, blobListingDetails, maxResults, currentToken, options, operationContext, null, null);
            return Task.Factory.FromAsync<BlobResultSegment>(ar, instance.EndListBlobsSegmented);
        }
        public static Task<ICloudBlob> GetBlobReferenceFromServerAsync(this CloudBlobClient instance, Uri blobUri)
        {
            var ar = instance.BeginGetBlobReferenceFromServer(blobUri, null, null);
            return Task.Factory.FromAsync<ICloudBlob>(ar, instance.EndGetBlobReferenceFromServer);
        }
        public static Task<ICloudBlob> GetBlobReferenceFromServerAsync(this CloudBlobClient instance, Uri blobUri, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginGetBlobReferenceFromServer(blobUri, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<ICloudBlob>(ar, instance.EndGetBlobReferenceFromServer);
        }
        public static Task<ServiceProperties> GetServicePropertiesAsync(this CloudBlobClient instance)
        {
            var ar = instance.BeginGetServiceProperties(null, null);
            return Task.Factory.FromAsync<ServiceProperties>(ar, instance.EndGetServiceProperties);
        }
        public static Task<ServiceProperties> GetServicePropertiesAsync(this CloudBlobClient instance, BlobRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginGetServiceProperties(requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync<ServiceProperties>(ar, instance.EndGetServiceProperties);
        }
        public static Task SetServicePropertiesAsync(this CloudBlobClient instance, ServiceProperties properties)
        {
            var ar = instance.BeginSetServiceProperties(properties, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetServiceProperties);
        }
        public static Task SetServicePropertiesAsync(this CloudBlobClient instance, ServiceProperties properties, BlobRequestOptions requestOptions, OperationContext operationContext)
        {
            var ar = instance.BeginSetServiceProperties(properties, requestOptions, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetServiceProperties);
        }
    }
}
