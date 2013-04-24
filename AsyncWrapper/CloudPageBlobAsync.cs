namespace Microsoft.WindowsAzure.Storage.Blob
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Data.Services.Client;
    using System.IO;
    using Protocol;
    using Shared.Protocol;
    
    public static class CloudPageBlobAsync
    {
        public static Task<Stream> OpenWriteAsync(this CloudPageBlob instance, Int64? size)
        {
            var ar = instance.BeginOpenWrite(size, null, null);
            return Task.Factory.FromAsync<Stream>(ar, instance.EndOpenWrite);
        }
        public static Task<Stream> OpenWriteAsync(this CloudPageBlob instance, Int64? size, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginOpenWrite(size, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<Stream>(ar, instance.EndOpenWrite);
        }
        public static Task DownloadToStreamAsync(this CloudPageBlob instance, Stream target)
        {
            var ar = instance.BeginDownloadToStream(target, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDownloadToStream);
        }
        public static Task DownloadToStreamAsync(this CloudPageBlob instance, Stream target, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDownloadToStream(target, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDownloadToStream);
        }
        public static Task DownloadRangeToStreamAsync(this CloudPageBlob instance, Stream target, Int64? offset, Int64? length)
        {
            var ar = instance.BeginDownloadRangeToStream(target, offset, length, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDownloadRangeToStream);
        }
        public static Task DownloadRangeToStreamAsync(this CloudPageBlob instance, Stream target, Int64? offset, Int64? length, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDownloadRangeToStream(target, offset, length, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDownloadRangeToStream);
        }
        public static Task UploadFromStreamAsync(this CloudPageBlob instance, Stream source)
        {
            var ar = instance.BeginUploadFromStream(source, null, null);
            return Task.Factory.FromAsync(ar, instance.EndUploadFromStream);
        }
        public static Task UploadFromStreamAsync(this CloudPageBlob instance, Stream source, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginUploadFromStream(source, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndUploadFromStream);
        }
        public static Task CreateAsync(this CloudPageBlob instance, Int64 size)
        {
            var ar = instance.BeginCreate(size, null, null);
            return Task.Factory.FromAsync(ar, instance.EndCreate);
        }
        public static Task CreateAsync(this CloudPageBlob instance, Int64 size, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginCreate(size, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndCreate);
        }
        public static Task ResizeAsync(this CloudPageBlob instance, Int64 size)
        {
            var ar = instance.BeginResize(size, null, null);
            return Task.Factory.FromAsync(ar, instance.EndResize);
        }
        public static Task ResizeAsync(this CloudPageBlob instance, Int64 size, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginResize(size, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndResize);
        }
        public static Task<Boolean> ExistsAsync(this CloudPageBlob instance)
        {
            var ar = instance.BeginExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndExists);
        }
        public static Task<Boolean> ExistsAsync(this CloudPageBlob instance, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginExists(options, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndExists);
        }
        public static Task FetchAttributesAsync(this CloudPageBlob instance)
        {
            var ar = instance.BeginFetchAttributes(null, null);
            return Task.Factory.FromAsync(ar, instance.EndFetchAttributes);
        }
        public static Task FetchAttributesAsync(this CloudPageBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginFetchAttributes(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndFetchAttributes);
        }
        public static Task<IEnumerable<PageRange>> GetPageRangesAsync(this CloudPageBlob instance)
        {
            var ar = instance.BeginGetPageRanges(null, null);
            return Task.Factory.FromAsync<IEnumerable<PageRange>>(ar, instance.EndGetPageRanges);
        }
        public static Task<IEnumerable<PageRange>> GetPageRangesAsync(this CloudPageBlob instance, Int64? offset, Int64? length, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginGetPageRanges(offset, length, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<IEnumerable<PageRange>>(ar, instance.EndGetPageRanges);
        }
        public static Task SetMetadataAsync(this CloudPageBlob instance)
        {
            var ar = instance.BeginSetMetadata(null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetMetadata);
        }
        public static Task SetMetadataAsync(this CloudPageBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginSetMetadata(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetMetadata);
        }
        public static Task SetPropertiesAsync(this CloudPageBlob instance)
        {
            var ar = instance.BeginSetProperties(null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetProperties);
        }
        public static Task SetPropertiesAsync(this CloudPageBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginSetProperties(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndSetProperties);
        }
        public static Task DeleteAsync(this CloudPageBlob instance)
        {
            var ar = instance.BeginDelete(null, null);
            return Task.Factory.FromAsync(ar, instance.EndDelete);
        }
        public static Task DeleteAsync(this CloudPageBlob instance, DeleteSnapshotsOption deleteSnapshotsOption, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDelete(deleteSnapshotsOption, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndDelete);
        }
        public static Task<Boolean> DeleteIfExistsAsync(this CloudPageBlob instance)
        {
            var ar = instance.BeginDeleteIfExists(null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndDeleteIfExists);
        }
        public static Task<Boolean> DeleteIfExistsAsync(this CloudPageBlob instance, DeleteSnapshotsOption deleteSnapshotsOption, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginDeleteIfExists(deleteSnapshotsOption, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<Boolean>(ar, instance.EndDeleteIfExists);
        }
        public static Task<CloudPageBlob> CreateSnapshotAsync(this CloudPageBlob instance)
        {
            var ar = instance.BeginCreateSnapshot(null, null);
            return Task.Factory.FromAsync<CloudPageBlob>(ar, instance.EndCreateSnapshot);
        }
        public static Task<CloudPageBlob> CreateSnapshotAsync(this CloudPageBlob instance, IDictionary<String,String> metadata, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginCreateSnapshot(metadata, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<CloudPageBlob>(ar, instance.EndCreateSnapshot);
        }
        public static Task<String> AcquireLeaseAsync(this CloudPageBlob instance, TimeSpan? leaseTime, String proposedLeaseId)
        {
            var ar = instance.BeginAcquireLease(leaseTime, proposedLeaseId, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndAcquireLease);
        }
        public static Task<String> AcquireLeaseAsync(this CloudPageBlob instance, TimeSpan? leaseTime, String proposedLeaseId, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginAcquireLease(leaseTime, proposedLeaseId, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndAcquireLease);
        }
        public static Task RenewLeaseAsync(this CloudPageBlob instance, AccessCondition accessCondition)
        {
            var ar = instance.BeginRenewLease(accessCondition, null, null);
            return Task.Factory.FromAsync(ar, instance.EndRenewLease);
        }
        public static Task RenewLeaseAsync(this CloudPageBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginRenewLease(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndRenewLease);
        }
        public static Task<String> ChangeLeaseAsync(this CloudPageBlob instance, String proposedLeaseId, AccessCondition accessCondition)
        {
            var ar = instance.BeginChangeLease(proposedLeaseId, accessCondition, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndChangeLease);
        }
        public static Task<String> ChangeLeaseAsync(this CloudPageBlob instance, String proposedLeaseId, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginChangeLease(proposedLeaseId, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndChangeLease);
        }
        public static Task ReleaseLeaseAsync(this CloudPageBlob instance, AccessCondition accessCondition)
        {
            var ar = instance.BeginReleaseLease(accessCondition, null, null);
            return Task.Factory.FromAsync(ar, instance.EndReleaseLease);
        }
        public static Task ReleaseLeaseAsync(this CloudPageBlob instance, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginReleaseLease(accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndReleaseLease);
        }
        public static Task<TimeSpan> BreakLeaseAsync(this CloudPageBlob instance, TimeSpan? breakPeriod)
        {
            var ar = instance.BeginBreakLease(breakPeriod, null, null);
            return Task.Factory.FromAsync<TimeSpan>(ar, instance.EndBreakLease);
        }
        public static Task<TimeSpan> BreakLeaseAsync(this CloudPageBlob instance, TimeSpan? breakPeriod, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginBreakLease(breakPeriod, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<TimeSpan>(ar, instance.EndBreakLease);
        }
        public static Task WritePagesAsync(this CloudPageBlob instance, Stream pageData, Int64 startOffset, String contentMD5)
        {
            var ar = instance.BeginWritePages(pageData, startOffset, contentMD5, null, null);
            return Task.Factory.FromAsync(ar, instance.EndWritePages);
        }
        public static Task WritePagesAsync(this CloudPageBlob instance, Stream pageData, Int64 startOffset, String contentMD5, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginWritePages(pageData, startOffset, contentMD5, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndWritePages);
        }
        public static Task ClearPagesAsync(this CloudPageBlob instance, Int64 startOffset, Int64 length)
        {
            var ar = instance.BeginClearPages(startOffset, length, null, null);
            return Task.Factory.FromAsync(ar, instance.EndClearPages);
        }
        public static Task ClearPagesAsync(this CloudPageBlob instance, Int64 startOffset, Int64 length, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginClearPages(startOffset, length, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndClearPages);
        }
        public static Task<String> StartCopyFromBlobAsync(this CloudPageBlob instance, Uri source)
        {
            var ar = instance.BeginStartCopyFromBlob(source, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndStartCopyFromBlob);
        }
        public static Task<String> StartCopyFromBlobAsync(this CloudPageBlob instance, CloudPageBlob source)
        {
            var ar = instance.BeginStartCopyFromBlob(source, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndStartCopyFromBlob);
        }
        public static Task<String> StartCopyFromBlobAsync(this CloudPageBlob instance, Uri source, AccessCondition sourceAccessCondition, AccessCondition destAccessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginStartCopyFromBlob(source, sourceAccessCondition, destAccessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndStartCopyFromBlob);
        }
        public static Task<String> StartCopyFromBlobAsync(this CloudPageBlob instance, CloudPageBlob source, AccessCondition sourceAccessCondition, AccessCondition destAccessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginStartCopyFromBlob(source, sourceAccessCondition, destAccessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync<String>(ar, instance.EndStartCopyFromBlob);
        }
        public static Task AbortCopyAsync(this CloudPageBlob instance, String copyId)
        {
            var ar = instance.BeginAbortCopy(copyId, null, null);
            return Task.Factory.FromAsync(ar, instance.EndAbortCopy);
        }
        public static Task AbortCopyAsync(this CloudPageBlob instance, String copyId, AccessCondition accessCondition, BlobRequestOptions options, OperationContext operationContext)
        {
            var ar = instance.BeginAbortCopy(copyId, accessCondition, options, operationContext, null, null);
            return Task.Factory.FromAsync(ar, instance.EndAbortCopy);
        }
    }
}
