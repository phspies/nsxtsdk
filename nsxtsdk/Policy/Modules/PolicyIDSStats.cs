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
    public class PolicyIDSStats
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyIDSStats(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task ResetIdsRuleStats(string? Category = null, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            StringBuilder ResetIdsRuleStatsServiceURL = new StringBuilder("/infra/settings/firewall/security/intrusion-services/stats?action=reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (Category != null) { request.AddQueryParameter("category", Category.ToString()); }
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ResetIdsRuleStatsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetIdsRuleStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsSecurityPolicyStatisticsListResultType> GetIdsGatewayPolicyStatistics(string DomainId, string PolicyId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            StringBuilder GetIdsGatewayPolicyStatisticsServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIdsGatewayPolicyStatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetIdsGatewayPolicyStatisticsServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetIdsGatewayPolicyStatisticsServiceURL.ToString();
            RestResponse<NSXTIdsSecurityPolicyStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsSecurityPolicyStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsGatewayPolicyStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsRuleStatisticsListResultType> GetIdsRuleStatistics(string DomainId, string IdsPolicyId, string RuleId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (IdsPolicyId == null) { throw new System.ArgumentNullException("IdsPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GetIdsRuleStatisticsServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{ids-policy-id}/rules/{rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIdsRuleStatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetIdsRuleStatisticsServiceURL.Replace("{ids-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IdsPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            GetIdsRuleStatisticsServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetIdsRuleStatisticsServiceURL.ToString();
            RestResponse<NSXTIdsRuleStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsRuleStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsRuleStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsRuleStatisticsListResultType> GetIdsGatewayRuleStatistics(string DomainId, string PolicyId, string RuleId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GetIdsGatewayRuleStatisticsServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}/rules/{rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIdsGatewayRuleStatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetIdsGatewayRuleStatisticsServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            GetIdsGatewayRuleStatisticsServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetIdsGatewayRuleStatisticsServiceURL.ToString();
            RestResponse<NSXTIdsRuleStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsRuleStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsGatewayRuleStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsSecurityPolicyStatisticsListResultType> GetIdsSecurityPolicyStatistics(string DomainId, string IdsPolicyId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (IdsPolicyId == null) { throw new System.ArgumentNullException("IdsPolicyId cannot be null"); }
            StringBuilder GetIdsSecurityPolicyStatisticsServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-policies/{ids-policy-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIdsSecurityPolicyStatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetIdsSecurityPolicyStatisticsServiceURL.Replace("{ids-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(IdsPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetIdsSecurityPolicyStatisticsServiceURL.ToString();
            RestResponse<NSXTIdsSecurityPolicyStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsSecurityPolicyStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIdsSecurityPolicyStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
