namespace Microsoft.WindowsAzure.Storage.Blob
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class ICloudBlobAsync
    {
        public static Task UploadFromStreamAsync(this ICloudBlob instance, Stream source)
        {
            var ar = instance.BeginUploadFromStream(source, null, null);
            return Task.Factory.FromAsync(ar, instance.EndUploadFromStream);
        }
        public static Task UploadFromStreamAsync(this ICloudBlob instance, Stream source, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginUploadFromStream(source, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndUploadFromStream);
        }
        public static Task DownloadToStreamAsync(this ICloudBlob instance, Stream target)
        {
            var ar = instance.BeginDownloadToStream(target, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDownloadToStream);
        }
        public static Task DownloadToStreamAsync(this ICloudBlob instance, Stream target, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDownloadToStream(target, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDownloadToStream);
        }
        public static Task DownloadRangeToStreamAsync(this ICloudBlob instance, Stream target, Int64? offset, Int64? length)
        {
            var ar = instance.BeginDownloadRangeToStream(target, offset, length, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDownloadRangeToStream);
        }
        public static Task DownloadRangeToStreamAsync(this ICloudBlob instance, Stream target, Int64? offset, Int64? length, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDownloadRangeToStream(target, offset, length, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDownloadRangeToStream);
        }
        public static Task<Boolean> ExistsAsync(this ICloudBlob instance)
        {
            var ar = instance.BeginExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndExists);
        }
        public static Task<Boolean> ExistsAsync(this ICloudBlob instance, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginExists(options, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndExists);
        }
        public static Task FetchAttributesAsync(this ICloudBlob instance)
        {
            var ar = instance.BeginFetchAttributes(null, null);
            return Task.Factory.FromAsync(ar, instance.EndFetchAttributes);
        }
        public static Task FetchAttributesAsync(this ICloudBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginFetchAttributes(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndFetchAttributes);
        }
        public static Task SetMetadataAsync(this ICloudBlob instance)
        {
            var ar = instance.BeginSetMetadata(null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetMetadata);
        }
        public static Task SetMetadataAsync(this ICloudBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginSetMetadata(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetMetadata);
        }
        public static Task SetPropertiesAsync(this ICloudBlob instance)
        {
            var ar = instance.BeginSetProperties(null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetProperties);
        }
        public static Task SetPropertiesAsync(this ICloudBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginSetProperties(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetProperties);
        }
        public static Task DeleteAsync(this ICloudBlob instance)
        {
            var ar = instance.BeginDelete(null, null);
            return Task.Factory.FromAsync(ar, instance.EndDelete);
        }
        public static Task DeleteAsync(this ICloudBlob instance, DeleteSnapshotsOption deleteSnapshotsOption, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDelete(deleteSnapshotsOption, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDelete);
        }
        public static Task<Boolean> DeleteIfExistsAsync(this ICloudBlob instance)
        {
            var ar = instance.BeginDeleteIfExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndDeleteIfExists);
        }
        public static Task<Boolean> DeleteIfExistsAsync(this ICloudBlob instance, DeleteSnapshotsOption deleteSnapshotsOption, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDeleteIfExists(deleteSnapshotsOption, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndDeleteIfExists);
        }
        public static Task<String> AcquireLeaseAsync(this ICloudBlob instance, TimeSpan? leaseTime, String proposedLeaseId)
        {
            var ar = instance.BeginAcquireLease(leaseTime, proposedLeaseId, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndAcquireLease);
        }
        public static Task<String> AcquireLeaseAsync(this ICloudBlob instance, TimeSpan? leaseTime, String proposedLeaseId, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginAcquireLease(leaseTime, proposedLeaseId, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndAcquireLease);
        }
        public static Task RenewLeaseAsync(this ICloudBlob instance, AccessCondition accessCondition)
        {
            var ar = instance.BeginRenewLease(accessCondition, null, null);
            return Task.Factory.FromAsync(ar, instance.EndRenewLease);
        }
        public static Task RenewLeaseAsync(this ICloudBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginRenewLease(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndRenewLease);
        }
        public static Task<String> ChangeLeaseAsync(this ICloudBlob instance, String proposedLeaseId, AccessCondition accessCondition)
        {
            var ar = instance.BeginChangeLease(proposedLeaseId, accessCondition, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndChangeLease);
        }
        public static Task<String> ChangeLeaseAsync(this ICloudBlob instance, String proposedLeaseId, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginChangeLease(proposedLeaseId, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndChangeLease);
        }
        public static Task ReleaseLeaseAsync(this ICloudBlob instance, AccessCondition accessCondition)
        {
            var ar = instance.BeginReleaseLease(accessCondition, null, null);
            return Task.Factory.FromAsync(ar, instance.EndReleaseLease);
        }
        public static Task ReleaseLeaseAsync(this ICloudBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginReleaseLease(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndReleaseLease);
        }
        public static Task<TimeSpan> BreakLeaseAsync(this ICloudBlob instance, TimeSpan? breakPeriod)
        {
            var ar = instance.BeginBreakLease(breakPeriod, null, null);
            return Task.Factory.FromAsync<TimeSpan>(ar, instance.EndBreakLease);
        }
        public static Task<TimeSpan> BreakLeaseAsync(this ICloudBlob instance, TimeSpan? breakPeriod, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginBreakLease(breakPeriod, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<TimeSpan>(ar, instance.EndBreakLease);
        }
        public static Task<String> StartCopyFromBlobAsync(this ICloudBlob instance, Uri source)
        {
            var ar = instance.BeginStartCopyFromBlob(source, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndStartCopyFromBlob);
        }
        public static Task<String> StartCopyFromBlobAsync(this ICloudBlob instance, Uri source, AccessCondition sourceAccessCondition, AccessCondition destAccessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginStartCopyFromBlob(source, sourceAccessCondition, destAccessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndStartCopyFromBlob);
        }
        public static Task AbortCopyAsync(this ICloudBlob instance, String copyId)
        {
            var ar = instance.BeginAbortCopy(copyId, null, null);
            return Task.Factory.FromAsync(ar, instance.EndAbortCopy);
        }
        public static Task AbortCopyAsync(this ICloudBlob instance, String copyId, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginAbortCopy(copyId, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndAbortCopy);
        }
    }
}
