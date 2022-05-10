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
    public class PolicyReaction
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyReaction(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTReactionListResultType> ListInfraReactions(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListInfraReactionsServiceURL = new StringBuilder("/infra/reactions");
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
            request.Resource = ListInfraReactionsServiceURL.ToString();
            RestResponse<NSXTReactionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTReactionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListInfraReactionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTReactionType> CreateOrUpdateInfraReaction(string ReactionId, NSXTReactionType Reaction)
        {
            if (ReactionId == null) { throw new System.ArgumentNullException("ReactionId cannot be null"); }
            if (Reaction == null) { throw new System.ArgumentNullException("Reaction cannot be null"); }
            StringBuilder CreateOrUpdateInfraReactionServiceURL = new StringBuilder("/infra/reactions/{reaction-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateInfraReactionServiceURL.Replace("{reaction-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ReactionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Reaction);
            request.Resource = CreateOrUpdateInfraReactionServiceURL.ToString();
            RestResponse<NSXTReactionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTReactionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateInfraReactionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task CreateOrPatchInfraReaction(string ReactionId, NSXTReactionType Reaction)
        {
            if (ReactionId == null) { throw new System.ArgumentNullException("ReactionId cannot be null"); }
            if (Reaction == null) { throw new System.ArgumentNullException("Reaction cannot be null"); }
            StringBuilder CreateOrPatchInfraReactionServiceURL = new StringBuilder("/infra/reactions/{reaction-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            CreateOrPatchInfraReactionServiceURL.Replace("{reaction-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ReactionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Reaction);
            request.Resource = CreateOrPatchInfraReactionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + CreateOrPatchInfraReactionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteInfraReaction(string ReactionId)
        {
            if (ReactionId == null) { throw new System.ArgumentNullException("ReactionId cannot be null"); }
            StringBuilder DeleteInfraReactionServiceURL = new StringBuilder("/infra/reactions/{reaction-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteInfraReactionServiceURL.Replace("{reaction-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ReactionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteInfraReactionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteInfraReactionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTReactionType> GetInfraReaction(string ReactionId)
        {
            if (ReactionId == null) { throw new System.ArgumentNullException("ReactionId cannot be null"); }
            StringBuilder GetInfraReactionServiceURL = new StringBuilder("/infra/reactions/{reaction-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetInfraReactionServiceURL.Replace("{reaction-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ReactionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetInfraReactionServiceURL.ToString();
            RestResponse<NSXTReactionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTReactionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInfraReactionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
