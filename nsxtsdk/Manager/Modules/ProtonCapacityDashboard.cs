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
    public class ProtonCapacityDashboard
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ProtonCapacityDashboard(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTCapacityThresholdListType> UpdateProtonCapacityThresholds(NSXTCapacityThresholdListType CapacityThresholdList)
        {
            if (CapacityThresholdList == null) { throw new System.ArgumentNullException("CapacityThresholdList cannot be null"); }
            StringBuilder UpdateProtonCapacityThresholdsServiceURL = new StringBuilder("/capacity/threshold");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(CapacityThresholdList);
            request.Resource = UpdateProtonCapacityThresholdsServiceURL.ToString();
            RestResponse<NSXTCapacityThresholdListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCapacityThresholdListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateProtonCapacityThresholdsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCapacityThresholdListType> GetProtonCapacityThresholds()
        {
            StringBuilder GetProtonCapacityThresholdsServiceURL = new StringBuilder("/capacity/threshold");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetProtonCapacityThresholdsServiceURL.ToString();
            RestResponse<NSXTCapacityThresholdListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCapacityThresholdListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetProtonCapacityThresholdsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCapacityUsageResponseType> GetProtonCapacityUsage(string? Category = null, string? Cursor = null, bool? Force = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetProtonCapacityUsageServiceURL = new StringBuilder("/capacity/usage");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Category != null) { request.AddQueryParameter("category", Category.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetProtonCapacityUsageServiceURL.ToString();
            RestResponse<NSXTCapacityUsageResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCapacityUsageResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetProtonCapacityUsageServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
