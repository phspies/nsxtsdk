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
    public class PolicyCapacityDashboard
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyCapacityDashboard(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTCapacityThresholdListType> UpdatePolicyCapacityThresholds(NSXTCapacityThresholdListType CapacityThresholdList)
        {
            if (CapacityThresholdList == null) { throw new System.ArgumentNullException("CapacityThresholdList cannot be null"); }
            StringBuilder UpdatePolicyCapacityThresholdsServiceURL = new StringBuilder("/infra/capacity/threshold");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(CapacityThresholdList);
            request.Resource = UpdatePolicyCapacityThresholdsServiceURL.ToString();
            RestResponse<NSXTCapacityThresholdListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCapacityThresholdListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePolicyCapacityThresholdsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCapacityThresholdListType> GetPolicyCapacityThresholds()
        {
            StringBuilder GetPolicyCapacityThresholdsServiceURL = new StringBuilder("/infra/capacity/threshold");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetPolicyCapacityThresholdsServiceURL.ToString();
            RestResponse<NSXTCapacityThresholdListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCapacityThresholdListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyCapacityThresholdsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyCapacityThresholds(NSXTCapacityThresholdType CapacityThreshold)
        {
            if (CapacityThreshold == null) { throw new System.ArgumentNullException("CapacityThreshold cannot be null"); }
            StringBuilder PatchPolicyCapacityThresholdsServiceURL = new StringBuilder("/infra/capacity/threshold");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(CapacityThreshold);
            request.Resource = PatchPolicyCapacityThresholdsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyCapacityThresholdsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCapacityUsageResponseType> GetPolicyCapacityDashboardUsage(string? Category = null, string? Cursor = null, bool? Force = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetPolicyCapacityDashboardUsageServiceURL = new StringBuilder("/infra/capacity/dashboard/usage");
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
            request.Resource = GetPolicyCapacityDashboardUsageServiceURL.ToString();
            RestResponse<NSXTCapacityUsageResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCapacityUsageResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyCapacityDashboardUsageServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyCapacityUsageResponseType> GetPolicyCapacityUsage(string? Category = null, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder GetPolicyCapacityUsageServiceURL = new StringBuilder("/infra/capacity/usage");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Category != null) { request.AddQueryParameter("category", Category.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyCapacityUsageServiceURL.ToString();
            RestResponse<NSXTPolicyCapacityUsageResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyCapacityUsageResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyCapacityUsageServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
