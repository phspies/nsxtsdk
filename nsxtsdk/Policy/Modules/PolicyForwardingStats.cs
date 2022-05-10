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
    public class PolicyForwardingStats
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyForwardingStats(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task ResetForwardingStats(string DomainId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder ResetForwardingStatsServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/stats?action=reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ResetForwardingStatsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ResetForwardingStatsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetForwardingStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTForwardingPolicyStatisticsListResultType> GetForwardingPolicyStats(string DomainId, string ForwardingPolicyId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            StringBuilder GetForwardingPolicyStatsServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetForwardingPolicyStatsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetForwardingPolicyStatsServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetForwardingPolicyStatsServiceURL.ToString();
            RestResponse<NSXTForwardingPolicyStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTForwardingPolicyStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetForwardingPolicyStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTForwardingRuleStatisticsListResultType> GetForwardingRuleStats(string DomainId, string ForwardingPolicyId, string ForwardingRuleId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            if (ForwardingRuleId == null) { throw new System.ArgumentNullException("ForwardingRuleId cannot be null"); }
            StringBuilder GetForwardingRuleStatsServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}/rules/{forwarding-rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetForwardingRuleStatsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetForwardingRuleStatsServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            GetForwardingRuleStatsServiceURL.Replace("{forwarding-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetForwardingRuleStatsServiceURL.ToString();
            RestResponse<NSXTForwardingRuleStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTForwardingRuleStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetForwardingRuleStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
