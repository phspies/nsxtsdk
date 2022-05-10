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
    public class PolicyFirewallScheduler
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyFirewallScheduler(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyFirewallSchedulerType> UpdatePolicyFirewallScheduler(string FirewallSchedulerId, NSXTPolicyFirewallSchedulerType PolicyFirewallScheduler)
        {
            if (FirewallSchedulerId == null) { throw new System.ArgumentNullException("FirewallSchedulerId cannot be null"); }
            if (PolicyFirewallScheduler == null) { throw new System.ArgumentNullException("PolicyFirewallScheduler cannot be null"); }
            StringBuilder UpdatePolicyFirewallSchedulerServiceURL = new StringBuilder("/infra/firewall-schedulers/{firewall-scheduler-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdatePolicyFirewallSchedulerServiceURL.Replace("{firewall-scheduler-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSchedulerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallScheduler);
            request.Resource = UpdatePolicyFirewallSchedulerServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSchedulerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSchedulerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdatePolicyFirewallSchedulerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSchedulerType> GetPolicyFirewallScheduler(string FirewallSchedulerId)
        {
            if (FirewallSchedulerId == null) { throw new System.ArgumentNullException("FirewallSchedulerId cannot be null"); }
            StringBuilder GetPolicyFirewallSchedulerServiceURL = new StringBuilder("/infra/firewall-schedulers/{firewall-scheduler-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyFirewallSchedulerServiceURL.Replace("{firewall-scheduler-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSchedulerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyFirewallSchedulerServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSchedulerType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSchedulerType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyFirewallSchedulerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyFirewallScheduler(string FirewallSchedulerId, bool? Force = null)
        {
            if (FirewallSchedulerId == null) { throw new System.ArgumentNullException("FirewallSchedulerId cannot be null"); }
            StringBuilder DeletePolicyFirewallSchedulerServiceURL = new StringBuilder("/infra/firewall-schedulers/{firewall-scheduler-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyFirewallSchedulerServiceURL.Replace("{firewall-scheduler-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSchedulerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Force != null) { request.AddQueryParameter("force", Force.ToString()); }
            request.Resource = DeletePolicyFirewallSchedulerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyFirewallSchedulerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyFirewallScheduler(string FirewallSchedulerId, NSXTPolicyFirewallSchedulerType PolicyFirewallScheduler)
        {
            if (FirewallSchedulerId == null) { throw new System.ArgumentNullException("FirewallSchedulerId cannot be null"); }
            if (PolicyFirewallScheduler == null) { throw new System.ArgumentNullException("PolicyFirewallScheduler cannot be null"); }
            StringBuilder PatchPolicyFirewallSchedulerServiceURL = new StringBuilder("/infra/firewall-schedulers/{firewall-scheduler-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyFirewallSchedulerServiceURL.Replace("{firewall-scheduler-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FirewallSchedulerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyFirewallScheduler);
            request.Resource = PatchPolicyFirewallSchedulerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyFirewallSchedulerServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyFirewallSchedulerListResultType> ListPolicyFirewallSchedulers(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListPolicyFirewallSchedulersServiceURL = new StringBuilder("/infra/firewall-schedulers");
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
            request.Resource = ListPolicyFirewallSchedulersServiceURL.ToString();
            RestResponse<NSXTPolicyFirewallSchedulerListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyFirewallSchedulerListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyFirewallSchedulersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
