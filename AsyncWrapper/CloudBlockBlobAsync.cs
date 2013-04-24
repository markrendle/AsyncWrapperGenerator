namespace Microsoft.WindowsAzure.Storage.Blob
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class CloudBlockBlobAsync
    {
        public static Task<Stream> OpenWriteAsync(this CloudBlockBlob instance)
        {
            var ar = instance.BeginOpenWrite(null, null);
            return Task.Factory.FromAsync<Stream>(ar, instance.EndOpenWrite);
        }
        public static Task<Stream> OpenWriteAsync(this CloudBlockBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginOpenWrite(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<Stream>(ar, instance.EndOpenWrite);
        }
        public static Task UploadFromStreamAsync(this CloudBlockBlob instance, Stream source)
        {
            var ar = instance.BeginUploadFromStream(source, null, null);
            return Task.Factory.FromAsync(ar, instance.EndUploadFromStream);
        }
        public static Task UploadFromStreamAsync(this CloudBlockBlob instance, Stream source, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginUploadFromStream(source, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndUploadFromStream);
        }
        public static Task DownloadToStreamAsync(this CloudBlockBlob instance, Stream target)
        {
            var ar = instance.BeginDownloadToStream(target, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDownloadToStream);
        }
        public static Task DownloadToStreamAsync(this CloudBlockBlob instance, Stream target, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDownloadToStream(target, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDownloadToStream);
        }
        public static Task DownloadRangeToStreamAsync(this CloudBlockBlob instance, Stream target, Int64? offset, Int64? length)
        {
            var ar = instance.BeginDownloadRangeToStream(target, offset, length, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDownloadRangeToStream);
        }
        public static Task DownloadRangeToStreamAsync(this CloudBlockBlob instance, Stream target, Int64? offset, Int64? length, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDownloadRangeToStream(target, offset, length, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDownloadRangeToStream);
        }
        public static Task<Boolean> ExistsAsync(this CloudBlockBlob instance)
        {
            var ar = instance.BeginExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndExists);
        }
        public static Task<Boolean> ExistsAsync(this CloudBlockBlob instance, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginExists(options, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndExists);
        }
        public static Task FetchAttributesAsync(this CloudBlockBlob instance)
        {
            var ar = instance.BeginFetchAttributes(null, null);
            return Task.Factory.FromAsync(ar, instance.EndFetchAttributes);
        }
        public static Task FetchAttributesAsync(this CloudBlockBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginFetchAttributes(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndFetchAttributes);
        }
        public static Task SetMetadataAsync(this CloudBlockBlob instance)
        {
            var ar = instance.BeginSetMetadata(null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetMetadata);
        }
        public static Task SetMetadataAsync(this CloudBlockBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginSetMetadata(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetMetadata);
        }
        public static Task SetPropertiesAsync(this CloudBlockBlob instance)
        {
            var ar = instance.BeginSetProperties(null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetProperties);
        }
        public static Task SetPropertiesAsync(this CloudBlockBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginSetProperties(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetProperties);
        }
        public static Task DeleteAsync(this CloudBlockBlob instance)
        {
            var ar = instance.BeginDelete(null, null);
            return Task.Factory.FromAsync(ar, instance.EndDelete);
        }
        public static Task DeleteAsync(this CloudBlockBlob instance, DeleteSnapshotsOption deleteSnapshotsOption, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDelete(deleteSnapshotsOption, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDelete);
        }
        public static Task<Boolean> DeleteIfExistsAsync(this CloudBlockBlob instance)
        {
            var ar = instance.BeginDeleteIfExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndDeleteIfExists);
        }
        public static Task<Boolean> DeleteIfExistsAsync(this CloudBlockBlob instance, DeleteSnapshotsOption deleteSnapshotsOption, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDeleteIfExists(deleteSnapshotsOption, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndDeleteIfExists);
        }
        public static Task<CloudBlockBlob> CreateSnapshotAsync(this CloudBlockBlob instance)
        {
            var ar = instance.BeginCreateSnapshot(null, null);
            return Task.Factory.FromAsync<CloudBlockBlob>(ar, instance.EndCreateSnapshot);
        }
        public static Task<CloudBlockBlob> CreateSnapshotAsync(this CloudBlockBlob instance, IDictionary<String,String> metadata, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginCreateSnapshot(metadata, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<CloudBlockBlob>(ar, instance.EndCreateSnapshot);
        }
        public static Task<String> AcquireLeaseAsync(this CloudBlockBlob instance, TimeSpan? leaseTime, String proposedLeaseId)
        {
            var ar = instance.BeginAcquireLease(leaseTime, proposedLeaseId, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndAcquireLease);
        }
        public static Task<String> AcquireLeaseAsync(this CloudBlockBlob instance, TimeSpan? leaseTime, String proposedLeaseId, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginAcquireLease(leaseTime, proposedLeaseId, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndAcquireLease);
        }
        public static Task RenewLeaseAsync(this CloudBlockBlob instance, AccessCondition accessCondition)
        {
            var ar = instance.BeginRenewLease(accessCondition, null, null);
            return Task.Factory.FromAsync(ar, instance.EndRenewLease);
        }
        public static Task RenewLeaseAsync(this CloudBlockBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginRenewLease(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndRenewLease);
        }
        public static Task<String> ChangeLeaseAsync(this CloudBlockBlob instance, String proposedLeaseId, AccessCondition accessCondition)
        {
            var ar = instance.BeginChangeLease(proposedLeaseId, accessCondition, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndChangeLease);
        }
        public static Task<String> ChangeLeaseAsync(this CloudBlockBlob instance, String proposedLeaseId, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginChangeLease(proposedLeaseId, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndChangeLease);
        }
        public static Task ReleaseLeaseAsync(this CloudBlockBlob instance, AccessCondition accessCondition)
        {
            var ar = instance.BeginReleaseLease(accessCondition, null, null);
            return Task.Factory.FromAsync(ar, instance.EndReleaseLease);
        }
        public static Task ReleaseLeaseAsync(this CloudBlockBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginReleaseLease(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndReleaseLease);
        }
        public static Task<TimeSpan> BreakLeaseAsync(this CloudBlockBlob instance, TimeSpan? breakPeriod)
        {
            var ar = instance.BeginBreakLease(breakPeriod, null, null);
            return Task.Factory.FromAsync<TimeSpan>(ar, instance.EndBreakLease);
        }
        public static Task<TimeSpan> BreakLeaseAsync(this CloudBlockBlob instance, TimeSpan? breakPeriod, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginBreakLease(breakPeriod, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<TimeSpan>(ar, instance.EndBreakLease);
        }
        public static Task PutBlockAsync(this CloudBlockBlob instance, String blockId, Stream blockData, String contentMD5)
        {
            var ar = instance.BeginPutBlock(blockId, blockData, contentMD5, null, null);
            return Task.Factory.FromAsync(ar, instance.EndPutBlock);
        }
        public static Task PutBlockAsync(this CloudBlockBlob instance, String blockId, Stream blockData, String contentMD5, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginPutBlock(blockId, blockData, contentMD5, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndPutBlock);
        }
        public static Task PutBlockListAsync(this CloudBlockBlob instance, IEnumerable<String> blockList)
        {
            var ar = instance.BeginPutBlockList(blockList, null, null);
            return Task.Factory.FromAsync(ar, instance.EndPutBlockList);
        }
        public static Task PutBlockListAsync(this CloudBlockBlob instance, IEnumerable<String> blockList, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginPutBlockList(blockList, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndPutBlockList);
        }
        public static Task<IEnumerable<ListBlockItem>> DownloadBlockListAsync(this CloudBlockBlob instance)
        {
            var ar = instance.BeginDownloadBlockList(null, null);
            return Task.Factory.FromAsync<IEnumerable<ListBlockItem>>(ar, instance.EndDownloadBlockList);
        }
        public static Task<IEnumerable<ListBlockItem>> DownloadBlockListAsync(this CloudBlockBlob instance, BlockListingFilter blockListingFilter, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDownloadBlockList(blockListingFilter, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<IEnumerable<ListBlockItem>>(ar, instance.EndDownloadBlockList);
        }
        public static Task<String> StartCopyFromBlobAsync(this CloudBlockBlob instance, Uri source)
        {
            var ar = instance.BeginStartCopyFromBlob(source, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndStartCopyFromBlob);
        }
        public static Task<String> StartCopyFromBlobAsync(this CloudBlockBlob instance, CloudBlockBlob source)
        {
            var ar = instance.BeginStartCopyFromBlob(source, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndStartCopyFromBlob);
        }
        public static Task<String> StartCopyFromBlobAsync(this CloudBlockBlob instance, Uri source, AccessCondition sourceAccessCondition, AccessCondition destAccessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginStartCopyFromBlob(source, sourceAccessCondition, destAccessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndStartCopyFromBlob);
        }
        public static Task<String> StartCopyFromBlobAsync(this CloudBlockBlob instance, CloudBlockBlob source, AccessCondition sourceAccessCondition, AccessCondition destAccessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginStartCopyFromBlob(source, sourceAccessCondition, destAccessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndStartCopyFromBlob);
        }
        public static Task AbortCopyAsync(this CloudBlockBlob instance, String copyId)
        {
            var ar = instance.BeginAbortCopy(copyId, null, null);
            return Task.Factory.FromAsync(ar, instance.EndAbortCopy);
        }
        public static Task AbortCopyAsync(this CloudBlockBlob instance, String copyId, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginAbortCopy(copyId, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndAbortCopy);
        }
    }
}
