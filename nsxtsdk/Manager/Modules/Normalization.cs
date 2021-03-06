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
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class Normalization
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Normalization(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNormalizedResourceListResultType> GetNormalizations(string PreferredNormalizationType, string ResourceId, string ResourceType, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (PreferredNormalizationType == null) { throw new System.ArgumentNullException("PreferredNormalizationType cannot be null"); }
            if (ResourceId == null) { throw new System.ArgumentNullException("ResourceId cannot be null"); }
            if (ResourceType == null) { throw new System.ArgumentNullException("ResourceType cannot be null"); }
            StringBuilder GetNormalizationsServiceURL = new StringBuilder("/normalizations");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (PreferredNormalizationType != null) { request.AddQueryParameter("preferred_normalization_type", PreferredNormalizationType.ToString()); }
            if (ResourceId != null) { request.AddQueryParameter("resource_id", ResourceId.ToString()); }
            if (ResourceType != null) { request.AddQueryParameter("resource_type", ResourceType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetNormalizationsServiceURL.ToString();
            RestResponse<NSXTNormalizedResourceListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNormalizedResourceListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNormalizationsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
