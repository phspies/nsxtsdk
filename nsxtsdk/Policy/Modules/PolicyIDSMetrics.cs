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
    public class PolicyIDSMetrics
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyIDSMetrics(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyIdsEventsBySignatureResultType> GetPolicyAllIdsEvents(NSXTPolicyIdsEventDataRequestType PolicyIdsEventDataRequest)
        {
            if (PolicyIdsEventDataRequest == null) { throw new System.ArgumentNullException("PolicyIdsEventDataRequest cannot be null"); }
            StringBuilder GetPolicyAllIdsEventsServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/ids-events");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PolicyIdsEventDataRequest);
            request.Resource = GetPolicyAllIdsEventsServiceURL.ToString();
            RestResponse<NSXTPolicyIdsEventsBySignatureResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIdsEventsBySignatureResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetPolicyAllIdsEventsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyIdsVmListType> GetPolicyAffectedVms(NSXTPolicyIdsEventDataRequestType PolicyIdsEventDataRequest, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (PolicyIdsEventDataRequest == null) { throw new System.ArgumentNullException("PolicyIdsEventDataRequest cannot be null"); }
            StringBuilder GetPolicyAffectedVmsServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/affected-vms");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PolicyIdsEventDataRequest);
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyAffectedVmsServiceURL.ToString();
            RestResponse<NSXTPolicyIdsVmListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIdsVmListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetPolicyAffectedVmsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyIdsUserListType> GetPolicyAffectedUsers(NSXTPolicyIdsEventDataRequestType PolicyIdsEventDataRequest, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (PolicyIdsEventDataRequest == null) { throw new System.ArgumentNullException("PolicyIdsEventDataRequest cannot be null"); }
            StringBuilder GetPolicyAffectedUsersServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/affected-users");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PolicyIdsEventDataRequest);
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyAffectedUsersServiceURL.ToString();
            RestResponse<NSXTPolicyIdsUserListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIdsUserListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetPolicyAffectedUsersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyIdsIpListType> GetPolicyAffectedIps(NSXTPolicyIdsEventDataRequestType PolicyIdsEventDataRequest, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (PolicyIdsEventDataRequest == null) { throw new System.ArgumentNullException("PolicyIdsEventDataRequest cannot be null"); }
            StringBuilder GetPolicyAffectedIpsServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/affected-ips");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PolicyIdsEventDataRequest);
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyAffectedIpsServiceURL.ToString();
            RestResponse<NSXTPolicyIdsIpListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIdsIpListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetPolicyAffectedIpsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyIdsSummaryListResultType> GetPolicyIdsDashboardSummary(NSXTPolicyIdsEventDataRequestType PolicyIdsEventDataRequest, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (PolicyIdsEventDataRequest == null) { throw new System.ArgumentNullException("PolicyIdsEventDataRequest cannot be null"); }
            StringBuilder GetPolicyIdsDashboardSummaryServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/ids-summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(PolicyIdsEventDataRequest);
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GetPolicyIdsDashboardSummaryServiceURL.ToString();
            RestResponse<NSXTPolicyIdsSummaryListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIdsSummaryListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetPolicyIdsDashboardSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
