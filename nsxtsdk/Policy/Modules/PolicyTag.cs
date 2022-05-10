using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using nsxtsdk;
using nsxtsdk.Models;
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class PolicyTag
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyTag(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyResourceReferenceListResultType> ListTaggedObjects(string? Cursor = null, string? FilterText = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, string? Scope = null, bool? SortAscending = null, string? SortBy = null, string? Tag = null)
        {
            StringBuilder ListTaggedObjectsServiceURL = new StringBuilder("/infra/tags/effective-resources");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (FilterText != null) { request.AddQueryParameter("filter_text", FilterText.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Scope != null) { request.AddQueryParameter("scope", Scope.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Tag != null) { request.AddQueryParameter("tag", Tag.ToString()); }
            request.Resource = ListTaggedObjectsServiceURL.ToString();
            RestResponse<NSXTPolicyResourceReferenceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyResourceReferenceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTaggedObjectsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTagBulkOperationType> TagBulkUpdate(string OperationId, NSXTTagBulkOperationType TagBulkOperation)
        {
            if (OperationId == null) { throw new System.ArgumentNullException("OperationId cannot be null"); }
            if (TagBulkOperation == null) { throw new System.ArgumentNullException("TagBulkOperation cannot be null"); }
            StringBuilder TagBulkUpdateServiceURL = new StringBuilder("/infra/tags/tag-operations/{operation-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            TagBulkUpdateServiceURL.Replace("{operation-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(OperationId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TagBulkOperation);
            request.Resource = TagBulkUpdateServiceURL.ToString();
            RestResponse<NSXTTagBulkOperationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTagBulkOperationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + TagBulkUpdateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTagBulkOperationType> GetTagBulkOperation(string OperationId)
        {
            if (OperationId == null) { throw new System.ArgumentNullException("OperationId cannot be null"); }
            StringBuilder GetTagBulkOperationServiceURL = new StringBuilder("/infra/tags/tag-operations/{operation-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTagBulkOperationServiceURL.Replace("{operation-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(OperationId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTagBulkOperationServiceURL.ToString();
            RestResponse<NSXTTagBulkOperationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTagBulkOperationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTagBulkOperationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTagBulkOperationStatusType> GetTagBulkOperationStatus(string OperationId)
        {
            if (OperationId == null) { throw new System.ArgumentNullException("OperationId cannot be null"); }
            StringBuilder GetTagBulkOperationStatusServiceURL = new StringBuilder("/infra/tags/tag-operations/{operation-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTagBulkOperationStatusServiceURL.Replace("{operation-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(OperationId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetTagBulkOperationStatusServiceURL.ToString();
            RestResponse<NSXTTagBulkOperationStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTagBulkOperationStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTagBulkOperationStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTagInfoListResultType> ListAllTags(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, string? Scope = null, bool? SortAscending = null, string? SortBy = null, string? Source = null, string? Tag = null)
        {
            StringBuilder ListAllTagsServiceURL = new StringBuilder("/infra/tags");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Scope != null) { request.AddQueryParameter("scope", Scope.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            if (Tag != null) { request.AddQueryParameter("tag", Tag.ToString()); }
            request.Resource = ListAllTagsServiceURL.ToString();
            RestResponse<NSXTTagInfoListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTagInfoListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAllTagsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
