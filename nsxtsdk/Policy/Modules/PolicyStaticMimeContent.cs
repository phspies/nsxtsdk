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
    public class PolicyStaticMimeContent
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyStaticMimeContent(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTStaticMimeContentListResultType> ListPolicyStaticMimeContents(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyStaticMimeContentsServiceURL = new StringBuilder("/infra/static-mime-contents");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyStaticMimeContentsServiceURL.ToString();
            RestResponse<NSXTStaticMimeContentListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticMimeContentListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyStaticMimeContentsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticMimeContentType> CreateOrUpdatePolicyStaticMimeContent(string StaticMimeContentId, NSXTStaticMimeContentType StaticMimeContent, bool? Override = null)
        {
            if (StaticMimeContentId == null) { throw new System.ArgumentNullException("StaticMimeContentId cannot be null"); }
            if (StaticMimeContent == null) { throw new System.ArgumentNullException("StaticMimeContent cannot be null"); }
            StringBuilder CreateOrUpdatePolicyStaticMimeContentServiceURL = new StringBuilder("/infra/static-mime-contents/{static-mime-content-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdatePolicyStaticMimeContentServiceURL.Replace("{static-mime-content-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(StaticMimeContentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticMimeContent);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = CreateOrUpdatePolicyStaticMimeContentServiceURL.ToString();
            RestResponse<NSXTStaticMimeContentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticMimeContentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdatePolicyStaticMimeContentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticMimeContentType> GetPolicyStaticMimeContent(string StaticMimeContentId)
        {
            if (StaticMimeContentId == null) { throw new System.ArgumentNullException("StaticMimeContentId cannot be null"); }
            StringBuilder GetPolicyStaticMimeContentServiceURL = new StringBuilder("/infra/static-mime-contents/{static-mime-content-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyStaticMimeContentServiceURL.Replace("{static-mime-content-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(StaticMimeContentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyStaticMimeContentServiceURL.ToString();
            RestResponse<NSXTStaticMimeContentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticMimeContentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyStaticMimeContentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStaticMimeContentType> PatchPolicyStaticMimeContent(string StaticMimeContentId, NSXTStaticMimeContentType StaticMimeContent, bool? Override = null)
        {
            if (StaticMimeContentId == null) { throw new System.ArgumentNullException("StaticMimeContentId cannot be null"); }
            if (StaticMimeContent == null) { throw new System.ArgumentNullException("StaticMimeContent cannot be null"); }
            StringBuilder PatchPolicyStaticMimeContentServiceURL = new StringBuilder("/infra/static-mime-contents/{static-mime-content-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyStaticMimeContentServiceURL.Replace("{static-mime-content-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(StaticMimeContentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(StaticMimeContent);
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = PatchPolicyStaticMimeContentServiceURL.ToString();
            RestResponse<NSXTStaticMimeContentType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStaticMimeContentType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyStaticMimeContentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyStaticMimeContent(string StaticMimeContentId, bool? Override = null)
        {
            if (StaticMimeContentId == null) { throw new System.ArgumentNullException("StaticMimeContentId cannot be null"); }
            StringBuilder DeletePolicyStaticMimeContentServiceURL = new StringBuilder("/infra/static-mime-contents/{static-mime-content-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyStaticMimeContentServiceURL.Replace("{static-mime-content-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(StaticMimeContentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Override != null) { request.AddQueryParameter("override", Override.ToString()); }
            request.Resource = DeletePolicyStaticMimeContentServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyStaticMimeContentServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
