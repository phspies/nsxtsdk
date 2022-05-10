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
    public class PolicyEdgeFirewall
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyEdgeFirewall(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTGatewayPolicyListResultType> GlobalGlobalInfraViewTier1LocaleServicesGatewayFirewall(string Tier1Id, string LocaleServicesId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GlobalInfraViewTier1LocaleServicesGatewayFirewallServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/gateway-firewall");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraViewTier1LocaleServicesGatewayFirewallServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraViewTier1LocaleServicesGatewayFirewallServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraViewTier1LocaleServicesGatewayFirewallServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraViewTier1LocaleServicesGatewayFirewallServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyType> CreateOrReplaceGatewayPolicyForDomain(string DomainId, string GatewayPolicyId, NSXTGatewayPolicyType GatewayPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            if (GatewayPolicy == null) { throw new System.ArgumentNullException("GatewayPolicy cannot be null"); }
            StringBuilder CreateOrReplaceGatewayPolicyForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceGatewayPolicyForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceGatewayPolicyForDomainServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GatewayPolicy);
            request.Resource = CreateOrReplaceGatewayPolicyForDomainServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceGatewayPolicyForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteGatewayPolicy(string DomainId, string GatewayPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            StringBuilder DeleteGatewayPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteGatewayPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGatewayPolicyServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteGatewayPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteGatewayPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchGatewayPolicyForDomain(string DomainId, string GatewayPolicyId, NSXTGatewayPolicyType GatewayPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            if (GatewayPolicy == null) { throw new System.ArgumentNullException("GatewayPolicy cannot be null"); }
            StringBuilder PatchGatewayPolicyForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchGatewayPolicyForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGatewayPolicyForDomainServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GatewayPolicy);
            request.Resource = PatchGatewayPolicyForDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchGatewayPolicyForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyType> ReadGatewayPolicyForDomain(string DomainId, string GatewayPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            StringBuilder ReadGatewayPolicyForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadGatewayPolicyForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadGatewayPolicyForDomainServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadGatewayPolicyForDomainServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadGatewayPolicyForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupType> GlobalGlobalInfraReadTier0Group(string Tier0Id, string GroupId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder GlobalInfraReadTier0GroupServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadTier0GroupServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadTier0GroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadTier0GroupServiceURL.ToString();
            RestResponse<NSXTGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadTier0GroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleStatisticsListResultType> GetGatewayRuleStatistics(string DomainId, string GatewayPolicyId, string RuleId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GetGatewayRuleStatisticsServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}/rules/{rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetGatewayRuleStatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetGatewayRuleStatisticsServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            GetGatewayRuleStatisticsServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetGatewayRuleStatisticsServiceURL.ToString();
            RestResponse<NSXTRuleStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetGatewayRuleStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyListResultType> ViewTier1GatewayFirewall(string Tier1Id)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ViewTier1GatewayFirewallServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/gateway-firewall");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ViewTier1GatewayFirewallServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ViewTier1GatewayFirewallServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ViewTier1GatewayFirewallServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyType> ReviseGatewayPolicy(string DomainId, string GatewayPolicyId, NSXTGatewayPolicyType GatewayPolicy, string? AnchorPath = null, string? Operation = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            if (GatewayPolicy == null) { throw new System.ArgumentNullException("GatewayPolicy cannot be null"); }
            StringBuilder ReviseGatewayPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseGatewayPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseGatewayPolicyServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(GatewayPolicy);
            if (AnchorPath != null) { request.AddQueryParameter("anchor_path", AnchorPath.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseGatewayPolicyServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseGatewayPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyListResultType> GlobalGlobalInfraViewTier0LocaleServicesGatewayFirewall(string Tier0Id, string LocaleServicesId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder GlobalInfraViewTier0LocaleServicesGatewayFirewallServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/gateway-firewall");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraViewTier0LocaleServicesGatewayFirewallServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraViewTier0LocaleServicesGatewayFirewallServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraViewTier0LocaleServicesGatewayFirewallServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraViewTier0LocaleServicesGatewayFirewallServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleType> GlobalGlobalInfraReadGatewayRule(string DomainId, string GatewayPolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GlobalInfraReadGatewayRuleServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadGatewayRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadGatewayRuleServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadGatewayRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadGatewayRuleServiceURL.ToString();
            RestResponse<NSXTRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadGatewayRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupType> CreateOrReplaceTier0Group(string Tier0Id, string GroupId, NSXTGroupType Group)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (Group == null) { throw new System.ArgumentNullException("Group cannot be null"); }
            StringBuilder CreateOrReplaceTier0GroupServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTier0GroupServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceTier0GroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Group);
            request.Resource = CreateOrReplaceTier0GroupServiceURL.ToString();
            RestResponse<NSXTGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTier0GroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTier0Group(string Tier0Id, string GroupId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder DeleteTier0GroupServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTier0GroupServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTier0GroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTier0GroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTier0GroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchTier0Group(string Tier0Id, string GroupId, NSXTGroupType Group)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            if (Group == null) { throw new System.ArgumentNullException("Group cannot be null"); }
            StringBuilder PatchTier0GroupServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTier0GroupServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTier0GroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Group);
            request.Resource = PatchTier0GroupServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTier0GroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupType> ReadTier0Group(string Tier0Id, string GroupId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (GroupId == null) { throw new System.ArgumentNullException("GroupId cannot be null"); }
            StringBuilder ReadTier0GroupServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/groups/{group-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTier0GroupServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTier0GroupServiceURL.Replace("{group-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GroupId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTier0GroupServiceURL.ToString();
            RestResponse<NSXTGroupType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTier0GroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyListResultType> ViewTier0GatewayFirewall(string Tier0Id)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ViewTier0GatewayFirewallServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/gateway-firewall");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ViewTier0GatewayFirewallServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ViewTier0GatewayFirewallServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ViewTier0GatewayFirewallServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupListResultType> ListTier0Group(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, string? MemberTypes = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ListTier0GroupServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTier0GroupServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (MemberTypes != null) { request.AddQueryParameter("member_types", MemberTypes.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTier0GroupServiceURL.ToString();
            RestResponse<NSXTGroupListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTier0GroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleStatisticsListResultType> GlobalGlobalInfraGetGatewayRuleStatistics(string DomainId, string GatewayPolicyId, string RuleId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GlobalInfraGetGatewayRuleStatisticsServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}/rules/{rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetGatewayRuleStatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetGatewayRuleStatisticsServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetGatewayRuleStatisticsServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraGetGatewayRuleStatisticsServiceURL.ToString();
            RestResponse<NSXTRuleStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetGatewayRuleStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyListResultType> GlobalGlobalInfraListGatewayPoliciesForDomain(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, bool? IncludeRuleCount = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder GlobalInfraListGatewayPoliciesForDomainServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/gateway-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListGatewayPoliciesForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludeRuleCount != null) { request.AddQueryParameter("include_rule_count", IncludeRuleCount.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListGatewayPoliciesForDomainServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListGatewayPoliciesForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyListResultType> ViewTier1LocaleServicesGatewayFirewall(string Tier1Id, string LocaleServicesId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder ViewTier1LocaleServicesGatewayFirewallServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-services-id}/gateway-firewall");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ViewTier1LocaleServicesGatewayFirewallServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ViewTier1LocaleServicesGatewayFirewallServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ViewTier1LocaleServicesGatewayFirewallServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ViewTier1LocaleServicesGatewayFirewallServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleListResultType> ListGatewayRules(string DomainId, string GatewayPolicyId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            StringBuilder ListGatewayRulesServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListGatewayRulesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListGatewayRulesServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListGatewayRulesServiceURL.ToString();
            RestResponse<NSXTRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListGatewayRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyListResultType> ViewTier0LocaleServicesGatewayFirewall(string Tier0Id, string LocaleServicesId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServicesId == null) { throw new System.ArgumentNullException("LocaleServicesId cannot be null"); }
            StringBuilder ViewTier0LocaleServicesGatewayFirewallServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-services-id}/gateway-firewall");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ViewTier0LocaleServicesGatewayFirewallServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ViewTier0LocaleServicesGatewayFirewallServiceURL.Replace("{locale-services-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServicesId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ViewTier0LocaleServicesGatewayFirewallServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ViewTier0LocaleServicesGatewayFirewallServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyListResultType> GlobalGlobalInfraViewTier1GatewayFirewall(string Tier1Id)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraViewTier1GatewayFirewallServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/gateway-firewall");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraViewTier1GatewayFirewallServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraViewTier1GatewayFirewallServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraViewTier1GatewayFirewallServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyType> GlobalGlobalInfraReadGatewayPolicyForDomain(string DomainId, string GatewayPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            StringBuilder GlobalInfraReadGatewayPolicyForDomainServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadGatewayPolicyForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadGatewayPolicyForDomainServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadGatewayPolicyForDomainServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadGatewayPolicyForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyListResultType> GlobalGlobalInfraViewTier0GatewayFirewall(string Tier0Id)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraViewTier0GatewayFirewallServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/gateway-firewall");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraViewTier0GatewayFirewallServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraViewTier0GatewayFirewallServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraViewTier0GatewayFirewallServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleListResultType> GlobalGlobalInfraListGatewayRules(string DomainId, string GatewayPolicyId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            StringBuilder GlobalInfraListGatewayRulesServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListGatewayRulesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListGatewayRulesServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListGatewayRulesServiceURL.ToString();
            RestResponse<NSXTRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListGatewayRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleType> ReviseGatewayRule(string DomainId, string GatewayPolicyId, string RuleId, NSXTRuleType Rule, string? AnchorPath = null, string? Operation = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (Rule == null) { throw new System.ArgumentNullException("Rule cannot be null"); }
            StringBuilder ReviseGatewayRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}/rules/{rule-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseGatewayRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseGatewayRuleServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseGatewayRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Rule);
            if (AnchorPath != null) { request.AddQueryParameter("anchor_path", AnchorPath.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseGatewayRuleServiceURL.ToString();
            RestResponse<NSXTRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseGatewayRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyStatisticsListResultType> GlobalGlobalInfraGetGatewayPolicyStatistics(string DomainId, string GatewayPolicyId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            StringBuilder GlobalInfraGetGatewayPolicyStatisticsServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetGatewayPolicyStatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetGatewayPolicyStatisticsServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraGetGatewayPolicyStatisticsServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetGatewayPolicyStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGatewayPolicyListResultType> ListGatewayPoliciesForDomain(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, bool? IncludeRuleCount = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder ListGatewayPoliciesForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListGatewayPoliciesForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludeRuleCount != null) { request.AddQueryParameter("include_rule_count", IncludeRuleCount.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListGatewayPoliciesForDomainServiceURL.ToString();
            RestResponse<NSXTGatewayPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGatewayPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListGatewayPoliciesForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleType> CreateOrReplaceGatewayRule(string DomainId, string GatewayPolicyId, string RuleId, NSXTRuleType Rule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (Rule == null) { throw new System.ArgumentNullException("Rule cannot be null"); }
            StringBuilder CreateOrReplaceGatewayRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceGatewayRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceGatewayRuleServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceGatewayRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Rule);
            request.Resource = CreateOrReplaceGatewayRuleServiceURL.ToString();
            RestResponse<NSXTRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceGatewayRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleType> ReadGatewayRule(string DomainId, string GatewayPolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder ReadGatewayRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadGatewayRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadGatewayRuleServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadGatewayRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadGatewayRuleServiceURL.ToString();
            RestResponse<NSXTRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadGatewayRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteGatewayRule(string DomainId, string GatewayPolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder DeleteGatewayRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteGatewayRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGatewayRuleServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteGatewayRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteGatewayRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteGatewayRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchGatewayRule(string DomainId, string GatewayPolicyId, string RuleId, NSXTRuleType Rule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (Rule == null) { throw new System.ArgumentNullException("Rule cannot be null"); }
            StringBuilder PatchGatewayRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchGatewayRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGatewayRuleServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchGatewayRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Rule);
            request.Resource = PatchGatewayRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchGatewayRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTGroupListResultType> GlobalGlobalInfraListTier0Group(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, string? MemberTypes = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraListTier0GroupServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/groups");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListTier0GroupServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (MemberTypes != null) { request.AddQueryParameter("member_types", MemberTypes.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListTier0GroupServiceURL.ToString();
            RestResponse<NSXTGroupListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTGroupListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListTier0GroupServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyStatisticsListResultType> GetGatewayPolicyStatistics(string DomainId, string GatewayPolicyId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (GatewayPolicyId == null) { throw new System.ArgumentNullException("GatewayPolicyId cannot be null"); }
            StringBuilder GetGatewayPolicyStatisticsServiceURL = new StringBuilder("/infra/domains/{domain-id}/gateway-policies/{gateway-policy-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetGatewayPolicyStatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetGatewayPolicyStatisticsServiceURL.Replace("{gateway-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(GatewayPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetGatewayPolicyStatisticsServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetGatewayPolicyStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
