namespace Microsoft.WindowsAzure.Storage.Blob
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class CloudBlobContainerAsync
    {
        public static Task CreateAsync(this CloudBlobContainer instance)
        {
            var ar = instance.BeginCreate(null, null);
            return Task.Factory.FromAsync(ar, instance.EndCreate);
        }
        public static Task CreateAsync(this CloudBlobContainer instance, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginCreate(options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndCreate);
        }
        public static Task<Boolean> CreateIfNotExistsAsync(this CloudBlobContainer instance)
        {
            var ar = instance.BeginCreateIfNotExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndCreateIfNotExists);
        }
        public static Task<Boolean> CreateIfNotExistsAsync(this CloudBlobContainer instance, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginCreateIfNotExists(options, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndCreateIfNotExists);
        }
        public static Task DeleteAsync(this CloudBlobContainer instance)
        {
            var ar = instance.BeginDelete(null, null);
            return Task.Factory.FromAsync(ar, instance.EndDelete);
        }
        public static Task DeleteAsync(this CloudBlobContainer instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDelete(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDelete);
        }
        public static Task<Boolean> DeleteIfExistsAsync(this CloudBlobContainer instance)
        {
            var ar = instance.BeginDeleteIfExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndDeleteIfExists);
        }
        public static Task<Boolean> DeleteIfExistsAsync(this CloudBlobContainer instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDeleteIfExists(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndDeleteIfExists);
        }
        public static Task<ICloudBlob> GetBlobReferenceFromServerAsync(this CloudBlobContainer instance, String blobName)
        {
            var ar = instance.BeginGetBlobReferenceFromServer(blobName, null, null);
            return Task.Factory.FromAsync<ICloudBlob>(ar, instance.EndGetBlobReferenceFromServer);
        }
        public static Task<ICloudBlob> GetBlobReferenceFromServerAsync(this CloudBlobContainer instance, String blobName, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginGetBlobReferenceFromServer(blobName, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<ICloudBlob>(ar, instance.EndGetBlobReferenceFromServer);
        }
        public static Task<BlobResultSegment> ListBlobsSegmentedAsync(this CloudBlobContainer instance, BlobContinuationToken currentToken)
        {
            var ar = instance.BeginListBlobsSegmented(currentToken, null, null);
            return Task.Factory.FromAsync<BlobResultSegment>(ar, instance.EndListBlobsSegmented);
        }
        public static Task<BlobResultSegment> ListBlobsSegmentedAsync(this CloudBlobContainer instance, String prefix, Boolean useFlatBlobListing, BlobListingDetails blobListingDetails, Int32? maxResults, BlobContinuationToken currentToken, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginListBlobsSegmented(prefix, useFlatBlobListing, blobListingDetails, maxResults, currentToken, options, operationContext, null, null);
            return Task.Factory.FromAsync<BlobResultSegment>(ar, instance.EndListBlobsSegmented);
        }
        public static Task SetPermissionsAsync(this CloudBlobContainer instance, BlobContainerPermissions permissions)
        {
            var ar = instance.BeginSetPermissions(permissions, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetPermissions);
        }
        public static Task SetPermissionsAsync(this CloudBlobContainer instance, BlobContainerPermissions permissions, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginSetPermissions(permissions, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetPermissions);
        }
        public static Task<BlobContainerPermissions> GetPermissionsAsync(this CloudBlobContainer instance)
        {
            var ar = instance.BeginGetPermissions(null, null);
            return Task.Factory.FromAsync<BlobContainerPermissions>(ar, instance.EndGetPermissions);
        }
        public static Task<BlobContainerPermissions> GetPermissionsAsync(this CloudBlobContainer instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginGetPermissions(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<BlobContainerPermissions>(ar, instance.EndGetPermissions);
        }
        public static Task<Boolean> ExistsAsync(this CloudBlobContainer instance)
        {
            var ar = instance.BeginExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndExists);
        }
        public static Task<Boolean> ExistsAsync(this CloudBlobContainer instance, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginExists(options, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndExists);
        }
        public static Task FetchAttributesAsync(this CloudBlobContainer instance)
        {
            var ar = instance.BeginFetchAttributes(null, null);
            return Task.Factory.FromAsync(ar, instance.EndFetchAttributes);
        }
        public static Task FetchAttributesAsync(this CloudBlobContainer instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginFetchAttributes(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndFetchAttributes);
        }
        public static Task SetMetadataAsync(this CloudBlobContainer instance)
        {
            var ar = instance.BeginSetMetadata(null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetMetadata);
        }
        public static Task SetMetadataAsync(this CloudBlobContainer instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginSetMetadata(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetMetadata);
        }
        public static Task<String> AcquireLeaseAsync(this CloudBlobContainer instance, TimeSpan? leaseTime, String proposedLeaseId)
        {
            var ar = instance.BeginAcquireLease(leaseTime, proposedLeaseId, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndAcquireLease);
        }
        public static Task<String> AcquireLeaseAsync(this CloudBlobContainer instance, TimeSpan? leaseTime, String proposedLeaseId, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginAcquireLease(leaseTime, proposedLeaseId, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndAcquireLease);
        }
        public static Task RenewLeaseAsync(this CloudBlobContainer instance, AccessCondition accessCondition)
        {
            var ar = instance.BeginRenewLease(accessCondition, null, null);
            return Task.Factory.FromAsync(ar, instance.EndRenewLease);
        }
        public static Task RenewLeaseAsync(this CloudBlobContainer instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginRenewLease(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndRenewLease);
        }
        public static Task<String> ChangeLeaseAsync(this CloudBlobContainer instance, String proposedLeaseId, AccessCondition accessCondition)
        {
            var ar = instance.BeginChangeLease(proposedLeaseId, accessCondition, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndChangeLease);
        }
        public static Task<String> ChangeLeaseAsync(this CloudBlobContainer instance, String proposedLeaseId, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginChangeLease(proposedLeaseId, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndChangeLease);
        }
        public static Task ReleaseLeaseAsync(this CloudBlobContainer instance, AccessCondition accessCondition)
        {
            var ar = instance.BeginReleaseLease(accessCondition, null, null);
            return Task.Factory.FromAsync(ar, instance.EndReleaseLease);
        }
        public static Task ReleaseLeaseAsync(this CloudBlobContainer instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginReleaseLease(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndReleaseLease);
        }
        public static Task<TimeSpan> BreakLeaseAsync(this CloudBlobContainer instance, TimeSpan? breakPeriod)
        {
            var ar = instance.BeginBreakLease(breakPeriod, null, null);
            return Task.Factory.FromAsync<TimeSpan>(ar, instance.EndBreakLease);
        }
        public static Task<TimeSpan> BreakLeaseAsync(this CloudBlobContainer instance, TimeSpan? breakPeriod, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginBreakLease(breakPeriod, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<TimeSpan>(ar, instance.EndBreakLease);
        }
    }
}
