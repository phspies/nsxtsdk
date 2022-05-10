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
    public class DfwSecurityPolicy
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public DfwSecurityPolicy(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTRuleType> GlobalGlobalInfraReadSecurityRule(string DomainId, string SecurityPolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GlobalInfraReadSecurityRuleServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/security-policies/{security-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadSecurityRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadSecurityRuleServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadSecurityRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadSecurityRuleServiceURL.ToString();
            RestResponse<NSXTRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadSecurityRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleStatisticsListResultType> GetRuleStatistics(string DomainId, string SecurityPolicyId, string RuleId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GetRuleStatisticsServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/rules/{rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetRuleStatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetRuleStatisticsServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            GetRuleStatisticsServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetRuleStatisticsServiceURL.ToString();
            RestResponse<NSXTRuleStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRuleStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleListResultType> ListSecurityRules(string DomainId, string SecurityPolicyId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            StringBuilder ListSecurityRulesServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListSecurityRulesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListSecurityRulesServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListSecurityRulesServiceURL.ToString();
            RestResponse<NSXTRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSecurityRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyStatisticsListResultType> GlobalGlobalInfraGetSecurityPolicyStatistics(string DomainId, string SecurityPolicyId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            StringBuilder GlobalInfraGetSecurityPolicyStatisticsServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/security-policies/{security-policy-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetSecurityPolicyStatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetSecurityPolicyStatisticsServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraGetSecurityPolicyStatisticsServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSecurityPolicyStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyType> ReviseSecurityPolicies(string DomainId, string SecurityPolicyId, NSXTSecurityPolicyType SecurityPolicy, string? AnchorPath = null, string? Operation = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (SecurityPolicy == null) { throw new System.ArgumentNullException("SecurityPolicy cannot be null"); }
            StringBuilder ReviseSecurityPoliciesServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseSecurityPoliciesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseSecurityPoliciesServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SecurityPolicy);
            if (AnchorPath != null) { request.AddQueryParameter("anchor_path", AnchorPath.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseSecurityPoliciesServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseSecurityPoliciesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResetRuleStats(string Category, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (Category == null) { throw new System.ArgumentNullException("Category cannot be null"); }
            StringBuilder ResetRuleStatsServiceURL = new StringBuilder("/infra/settings/firewall/stats?action=reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (Category != null) { request.AddQueryParameter("category", Category.ToString()); }
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ResetRuleStatsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetRuleStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyContainerClusterListResultType> ListContainerClustersForSecurityPolicy(string DomainId, string SecurityPolicyId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            StringBuilder ListContainerClustersForSecurityPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/container-cluster-span");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListContainerClustersForSecurityPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListContainerClustersForSecurityPolicyServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListContainerClustersForSecurityPolicyServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyContainerClusterListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyContainerClusterListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListContainerClustersForSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyStatisticsListResultType> GetSecurityPolicyStatistics(string DomainId, string SecurityPolicyId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            StringBuilder GetSecurityPolicyStatisticsServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSecurityPolicyStatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GetSecurityPolicyStatisticsServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetSecurityPolicyStatisticsServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSecurityPolicyStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleType> UpdateSecurityRule(string DomainId, string SecurityPolicyId, string RuleId, NSXTRuleType Rule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (Rule == null) { throw new System.ArgumentNullException("Rule cannot be null"); }
            StringBuilder UpdateSecurityRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateSecurityRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateSecurityRuleServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateSecurityRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Rule);
            request.Resource = UpdateSecurityRuleServiceURL.ToString();
            RestResponse<NSXTRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSecurityRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleType> ReadSecurityRule(string DomainId, string SecurityPolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder ReadSecurityRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadSecurityRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadSecurityRuleServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadSecurityRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadSecurityRuleServiceURL.ToString();
            RestResponse<NSXTRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSecurityRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSecurityRule(string DomainId, string SecurityPolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder DeleteSecurityRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSecurityRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSecurityRuleServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSecurityRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSecurityRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSecurityRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchSecurityRule(string DomainId, string SecurityPolicyId, string RuleId, NSXTRuleType Rule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (Rule == null) { throw new System.ArgumentNullException("Rule cannot be null"); }
            StringBuilder PatchSecurityRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchSecurityRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSecurityRuleServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSecurityRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Rule);
            request.Resource = PatchSecurityRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSecurityRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyType> GlobalGlobalInfraReadSecurityPolicyForDomain(string DomainId, string SecurityPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            StringBuilder GlobalInfraReadSecurityPolicyForDomainServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/security-policies/{security-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadSecurityPolicyForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadSecurityPolicyForDomainServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadSecurityPolicyForDomainServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadSecurityPolicyForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyContainerClusterType> ReadContainerClusterSpanForSecurityPolicy(string DomainId, string SecurityPolicyId, string AntreaCluster1)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (AntreaCluster1 == null) { throw new System.ArgumentNullException("AntreaCluster1 cannot be null"); }
            StringBuilder ReadContainerClusterSpanForSecurityPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/container-cluster-span/{antrea-cluster-1}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadContainerClusterSpanForSecurityPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadContainerClusterSpanForSecurityPolicyServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadContainerClusterSpanForSecurityPolicyServiceURL.Replace("{antrea-cluster-1}", System.Uri.EscapeDataString(Helpers.ConvertToString(AntreaCluster1, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadContainerClusterSpanForSecurityPolicyServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyContainerClusterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyContainerClusterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadContainerClusterSpanForSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteClusterContainerForSecurityPolicy(string DomainId, string SecurityPolicyId, string AntreaCluster1)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (AntreaCluster1 == null) { throw new System.ArgumentNullException("AntreaCluster1 cannot be null"); }
            StringBuilder DeleteClusterContainerForSecurityPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/container-cluster-span/{antrea-cluster-1}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteClusterContainerForSecurityPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteClusterContainerForSecurityPolicyServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteClusterContainerForSecurityPolicyServiceURL.Replace("{antrea-cluster-1}", System.Uri.EscapeDataString(Helpers.ConvertToString(AntreaCluster1, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteClusterContainerForSecurityPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteClusterContainerForSecurityPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyType> UpdateSecurityPolicyForDomain(string DomainId, string SecurityPolicyId, NSXTSecurityPolicyType SecurityPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (SecurityPolicy == null) { throw new System.ArgumentNullException("SecurityPolicy cannot be null"); }
            StringBuilder UpdateSecurityPolicyForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateSecurityPolicyForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateSecurityPolicyForDomainServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SecurityPolicy);
            request.Resource = UpdateSecurityPolicyForDomainServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSecurityPolicyForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchSecurityPolicyForDomain(string DomainId, string SecurityPolicyId, NSXTSecurityPolicyType SecurityPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (SecurityPolicy == null) { throw new System.ArgumentNullException("SecurityPolicy cannot be null"); }
            StringBuilder PatchSecurityPolicyForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchSecurityPolicyForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchSecurityPolicyForDomainServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SecurityPolicy);
            request.Resource = PatchSecurityPolicyForDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchSecurityPolicyForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyType> ReadSecurityPolicyForDomain(string DomainId, string SecurityPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            StringBuilder ReadSecurityPolicyForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadSecurityPolicyForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadSecurityPolicyForDomainServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadSecurityPolicyForDomainServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadSecurityPolicyForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSecurityPolicyForDomain(string DomainId, string SecurityPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            StringBuilder DeleteSecurityPolicyForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSecurityPolicyForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteSecurityPolicyForDomainServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteSecurityPolicyForDomainServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSecurityPolicyForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyListResultType> ListSecurityPoliciesForDomain(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, bool? IncludeRuleCount = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder ListSecurityPoliciesForDomainServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListSecurityPoliciesForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludeRuleCount != null) { request.AddQueryParameter("include_rule_count", IncludeRuleCount.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListSecurityPoliciesForDomainServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSecurityPoliciesForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyContainerClusterType> AddContainerClusterSpan(string DomainId, string SecurityPolicyId, string ContainerClusterId, NSXTSecurityPolicyContainerClusterType SecurityPolicyContainerCluster)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (ContainerClusterId == null) { throw new System.ArgumentNullException("ContainerClusterId cannot be null"); }
            if (SecurityPolicyContainerCluster == null) { throw new System.ArgumentNullException("SecurityPolicyContainerCluster cannot be null"); }
            StringBuilder AddContainerClusterSpanServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/container-cluster-span/{container-cluster-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            AddContainerClusterSpanServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            AddContainerClusterSpanServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            AddContainerClusterSpanServiceURL.Replace("{container-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContainerClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SecurityPolicyContainerCluster);
            request.Resource = AddContainerClusterSpanServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyContainerClusterType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyContainerClusterType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + AddContainerClusterSpanServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchContainerClusterSpan(string DomainId, string SecurityPolicyId, string ContainerClusterId, NSXTSecurityPolicyContainerClusterType SecurityPolicyContainerCluster)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (ContainerClusterId == null) { throw new System.ArgumentNullException("ContainerClusterId cannot be null"); }
            if (SecurityPolicyContainerCluster == null) { throw new System.ArgumentNullException("SecurityPolicyContainerCluster cannot be null"); }
            StringBuilder PatchContainerClusterSpanServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/container-cluster-span/{container-cluster-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchContainerClusterSpanServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchContainerClusterSpanServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchContainerClusterSpanServiceURL.Replace("{container-cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContainerClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(SecurityPolicyContainerCluster);
            request.Resource = PatchContainerClusterSpanServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchContainerClusterSpanServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleType> ReviseSecurityRule(string DomainId, string SecurityPolicyId, string RuleId, NSXTRuleType Rule, string? AnchorPath = null, string? Operation = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (Rule == null) { throw new System.ArgumentNullException("Rule cannot be null"); }
            StringBuilder ReviseSecurityRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/security-policies/{security-policy-id}/rules/{rule-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseSecurityRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseSecurityRuleServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseSecurityRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(Rule);
            if (AnchorPath != null) { request.AddQueryParameter("anchor_path", AnchorPath.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseSecurityRuleServiceURL.ToString();
            RestResponse<NSXTRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseSecurityRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleListResultType> GlobalGlobalInfraListSecurityRules(string DomainId, string SecurityPolicyId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            StringBuilder GlobalInfraListSecurityRulesServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/security-policies/{security-policy-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListSecurityRulesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListSecurityRulesServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListSecurityRulesServiceURL.ToString();
            RestResponse<NSXTRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListSecurityRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleStatisticsListResultType> GlobalGlobalInfraGetRuleStatistics(string DomainId, string SecurityPolicyId, string RuleId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (SecurityPolicyId == null) { throw new System.ArgumentNullException("SecurityPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GlobalInfraGetRuleStatisticsServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/security-policies/{security-policy-id}/rules/{rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetRuleStatisticsServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetRuleStatisticsServiceURL.Replace("{security-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SecurityPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetRuleStatisticsServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraGetRuleStatisticsServiceURL.ToString();
            RestResponse<NSXTRuleStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetRuleStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSecurityPolicyListResultType> GlobalGlobalInfraListSecurityPoliciesForDomain(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, bool? IncludeRuleCount = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder GlobalInfraListSecurityPoliciesForDomainServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/security-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListSecurityPoliciesForDomainServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludeRuleCount != null) { request.AddQueryParameter("include_rule_count", IncludeRuleCount.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListSecurityPoliciesForDomainServiceURL.ToString();
            RestResponse<NSXTSecurityPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSecurityPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListSecurityPoliciesForDomainServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraResetRuleStats(string Category, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (Category == null) { throw new System.ArgumentNullException("Category cannot be null"); }
            StringBuilder GlobalInfraResetRuleStatsServiceURL = new StringBuilder("/global-infra/settings/firewall/stats?action=reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (Category != null) { request.AddQueryParameter("category", Category.ToString()); }
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraResetRuleStatsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GlobalInfraResetRuleStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
