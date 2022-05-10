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
    public class PolicyDraft
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyDraft(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyDraftPaginatedAggregatedConfigurationResultType> GetPolicyDraftPaginatedAggregatedConfigurationResult(string DraftId, string? RequestId = null, string? RootPath = null)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            StringBuilder GetPolicyDraftPaginatedAggregatedConfigurationResultServiceURL = new StringBuilder("/infra/drafts/{draft-id}/aggregated_with_pagination");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyDraftPaginatedAggregatedConfigurationResultServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            if (RootPath != null) { request.AddQueryParameter("root_path", RootPath.ToString()); }
            request.Resource = GetPolicyDraftPaginatedAggregatedConfigurationResultServiceURL.ToString();
            RestResponse<NSXTPolicyDraftPaginatedAggregatedConfigurationResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDraftPaginatedAggregatedConfigurationResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyDraftPaginatedAggregatedConfigurationResultServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDraftType> PutDraft(string DraftId, NSXTPolicyDraftType PolicyDraft)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            if (PolicyDraft == null) { throw new System.ArgumentNullException("PolicyDraft cannot be null"); }
            StringBuilder PutDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            PutDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyDraft);
            request.Resource = PutDraftServiceURL.ToString();
            RestResponse<NSXTPolicyDraftType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDraftType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PutDraftServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteDraft(string DraftId)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            StringBuilder DeleteDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteDraftServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteDraftServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchDraft(string DraftId, NSXTPolicyDraftType PolicyDraft)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            if (PolicyDraft == null) { throw new System.ArgumentNullException("PolicyDraft cannot be null"); }
            StringBuilder PatchDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyDraft);
            request.Resource = PatchDraftServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchDraftServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDraftType> ReadDraft(string DraftId)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            StringBuilder ReadDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadDraftServiceURL.ToString();
            RestResponse<NSXTPolicyDraftType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDraftType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadDraftServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInfraType> GetAggregatedConfigurationToBePublishedForDraft(string DraftId)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            StringBuilder GetAggregatedConfigurationToBePublishedForDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}/aggregated");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetAggregatedConfigurationToBePublishedForDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetAggregatedConfigurationToBePublishedForDraftServiceURL.ToString();
            RestResponse<NSXTInfraType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInfraType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetAggregatedConfigurationToBePublishedForDraftServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyDraftListResultType> ListDrafts(bool? AutoDrafts = null, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListDraftsServiceURL = new StringBuilder("/infra/drafts");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AutoDrafts != null) { request.AddQueryParameter("auto_drafts", AutoDrafts.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListDraftsServiceURL.ToString();
            RestResponse<NSXTPolicyDraftListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyDraftListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListDraftsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PublishDraft(string DraftId, NSXTInfraType Infra)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            if (Infra == null) { throw new System.ArgumentNullException("Infra cannot be null"); }
            StringBuilder PublishDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}?action=publish");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            PublishDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Infra);
            request.Resource = PublishDraftServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + PublishDraftServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInfraType> GetPreviewOfConfigurationAfterPublishOfDraft(string DraftId)
        {
            if (DraftId == null) { throw new System.ArgumentNullException("DraftId cannot be null"); }
            StringBuilder GetPreviewOfConfigurationAfterPublishOfDraftServiceURL = new StringBuilder("/infra/drafts/{draft-id}/complete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPreviewOfConfigurationAfterPublishOfDraftServiceURL.Replace("{draft-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DraftId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPreviewOfConfigurationAfterPublishOfDraftServiceURL.ToString();
            RestResponse<NSXTInfraType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInfraType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPreviewOfConfigurationAfterPublishOfDraftServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
