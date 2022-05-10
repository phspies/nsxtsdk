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
    public class PolicyFirewallConfiguration
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyFirewallConfiguration(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyResourceReferenceType> FilterFirewallExcludeList(string IntentPath, bool? DeepCheck = null, string? EnforcementPointPath = null)
        {
            if (IntentPath == null) { throw new System.ArgumentNullException("IntentPath cannot be null"); }
            StringBuilder FilterFirewallExcludeListServiceURL = new StringBuilder("/infra/settings/firewall/security/exclude-list?action=filter");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (DeepCheck != null) { request.AddQueryParameter("deep_check", DeepCheck.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IntentPath != null) { request.AddQueryParameter("intent_path", IntentPath.ToString()); }
            request.Resource = FilterFirewallExcludeListServiceURL.ToString();
            RestResponse<NSXTPolicyResourceReferenceType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyResourceReferenceType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FilterFirewallExcludeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDfwFirewallConfigurationType> PutDfwFirewallConfiguration(NSXTDfwFirewallConfigurationType DfwFirewallConfiguration)
        {
            if (DfwFirewallConfiguration == null) { throw new System.ArgumentNullException("DfwFirewallConfiguration cannot be null"); }
            StringBuilder PutDfwFirewallConfigurationServiceURL = new StringBuilder("/infra/settings/firewall/security");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(DfwFirewallConfiguration);
            request.Resource = PutDfwFirewallConfigurationServiceURL.ToString();
            RestResponse<NSXTDfwFirewallConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDfwFirewallConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PutDfwFirewallConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchDfwFirewallConfiguration(NSXTDfwFirewallConfigurationType DfwFirewallConfiguration)
        {
            if (DfwFirewallConfiguration == null) { throw new System.ArgumentNullException("DfwFirewallConfiguration cannot be null"); }
            StringBuilder PatchDfwFirewallConfigurationServiceURL = new StringBuilder("/infra/settings/firewall/security");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(DfwFirewallConfiguration);
            request.Resource = PatchDfwFirewallConfigurationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchDfwFirewallConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDfwFirewallConfigurationType> GetDfwFirewallConfiguration()
        {
            StringBuilder GetDfwFirewallConfigurationServiceURL = new StringBuilder("/infra/settings/firewall/security");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetDfwFirewallConfigurationServiceURL.ToString();
            RestResponse<NSXTDfwFirewallConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDfwFirewallConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDfwFirewallConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyExcludeListType> GetInternalFirewallExcludeList()
        {
            StringBuilder GetInternalFirewallExcludeListServiceURL = new StringBuilder("/infra/settings/firewall/security/exclude-list?system_owned=true");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetInternalFirewallExcludeListServiceURL.ToString();
            RestResponse<NSXTPolicyExcludeListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyExcludeListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetInternalFirewallExcludeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyResourceReferenceForEPListResultType> GlobalGlobalInfraGetFilteredRules(string Scope, string? EnforcementPointPath = null, string? ParentPath = null)
        {
            if (Scope == null) { throw new System.ArgumentNullException("Scope cannot be null"); }
            StringBuilder GlobalInfraGetFilteredRulesServiceURL = new StringBuilder("/global-infra/firewall/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (ParentPath != null) { request.AddQueryParameter("parent_path", ParentPath.ToString()); }
            if (Scope != null) { request.AddQueryParameter("scope", Scope.ToString()); }
            request.Resource = GlobalInfraGetFilteredRulesServiceURL.ToString();
            RestResponse<NSXTPolicyResourceReferenceForEPListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyResourceReferenceForEPListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetFilteredRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDependentServicesType> GetDistributedFirewallDependentServices()
        {
            StringBuilder GetDistributedFirewallDependentServicesServiceURL = new StringBuilder("/infra/settings/firewall/security/dependent-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetDistributedFirewallDependentServicesServiceURL.ToString();
            RestResponse<NSXTDependentServicesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDependentServicesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDistributedFirewallDependentServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyResourceReferenceForEPListResultType> GetFilteredRules(string Scope, string? EnforcementPointPath = null, string? ParentPath = null)
        {
            if (Scope == null) { throw new System.ArgumentNullException("Scope cannot be null"); }
            StringBuilder GetFilteredRulesServiceURL = new StringBuilder("/infra/firewall/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (ParentPath != null) { request.AddQueryParameter("parent_path", ParentPath.ToString()); }
            if (Scope != null) { request.AddQueryParameter("scope", Scope.ToString()); }
            request.Resource = GetFilteredRulesServiceURL.ToString();
            RestResponse<NSXTPolicyResourceReferenceForEPListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyResourceReferenceForEPListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFilteredRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStandaloneHostIdfwConfigurationType> PutStandaloneHostIdfwConfiguration(NSXTStandaloneHostIdfwConfigurationType StandaloneHostIdfwConfiguration)
        {
            if (StandaloneHostIdfwConfiguration == null) { throw new System.ArgumentNullException("StandaloneHostIdfwConfiguration cannot be null"); }
            StringBuilder PutStandaloneHostIdfwConfigurationServiceURL = new StringBuilder("/infra/settings/firewall/idfw/standalone-host-switch-setting");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(StandaloneHostIdfwConfiguration);
            request.Resource = PutStandaloneHostIdfwConfigurationServiceURL.ToString();
            RestResponse<NSXTStandaloneHostIdfwConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStandaloneHostIdfwConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PutStandaloneHostIdfwConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchStandaloneHostIdfwConfiguration(NSXTStandaloneHostIdfwConfigurationType StandaloneHostIdfwConfiguration)
        {
            if (StandaloneHostIdfwConfiguration == null) { throw new System.ArgumentNullException("StandaloneHostIdfwConfiguration cannot be null"); }
            StringBuilder PatchStandaloneHostIdfwConfigurationServiceURL = new StringBuilder("/infra/settings/firewall/idfw/standalone-host-switch-setting");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(StandaloneHostIdfwConfiguration);
            request.Resource = PatchStandaloneHostIdfwConfigurationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchStandaloneHostIdfwConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTStandaloneHostIdfwConfigurationType> GetStandaloneHostIdfwConfiguration()
        {
            StringBuilder GetStandaloneHostIdfwConfigurationServiceURL = new StringBuilder("/infra/settings/firewall/idfw/standalone-host-switch-setting");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetStandaloneHostIdfwConfigurationServiceURL.ToString();
            RestResponse<NSXTStandaloneHostIdfwConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTStandaloneHostIdfwConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetStandaloneHostIdfwConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDependentServicesType> GetGatewayFirewallDependentServices()
        {
            StringBuilder GetGatewayFirewallDependentServicesServiceURL = new StringBuilder("/infra/settings/firewall/gateway/dependent-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetGatewayFirewallDependentServicesServiceURL.ToString();
            RestResponse<NSXTDependentServicesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDependentServicesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetGatewayFirewallDependentServicesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyResourceReferenceForEPListResultType> GetFilteredPolicies(string Scope, string? EnforcementPointPath = null, string? ParentPath = null)
        {
            if (Scope == null) { throw new System.ArgumentNullException("Scope cannot be null"); }
            StringBuilder GetFilteredPoliciesServiceURL = new StringBuilder("/infra/firewall/policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (ParentPath != null) { request.AddQueryParameter("parent_path", ParentPath.ToString()); }
            if (Scope != null) { request.AddQueryParameter("scope", Scope.ToString()); }
            request.Resource = GetFilteredPoliciesServiceURL.ToString();
            RestResponse<NSXTPolicyResourceReferenceForEPListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyResourceReferenceForEPListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFilteredPoliciesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTComputeClusterIdfwConfigurationListResultType> ListComputeClusterIdfwConfiguration(string? Cursor = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListComputeClusterIdfwConfigurationServiceURL = new StringBuilder("/infra/settings/firewall/idfw/cluster");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListComputeClusterIdfwConfigurationServiceURL.ToString();
            RestResponse<NSXTComputeClusterIdfwConfigurationListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComputeClusterIdfwConfigurationListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListComputeClusterIdfwConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTComputeClusterIdfwConfigurationType> PutComputeClusterIdfwConfiguration(string ClusterId, NSXTComputeClusterIdfwConfigurationType ComputeClusterIdfwConfiguration)
        {
            if (ClusterId == null) { throw new System.ArgumentNullException("ClusterId cannot be null"); }
            if (ComputeClusterIdfwConfiguration == null) { throw new System.ArgumentNullException("ComputeClusterIdfwConfiguration cannot be null"); }
            StringBuilder PutComputeClusterIdfwConfigurationServiceURL = new StringBuilder("/infra/settings/firewall/idfw/cluster/{cluster-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            PutComputeClusterIdfwConfigurationServiceURL.Replace("{cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ComputeClusterIdfwConfiguration);
            request.Resource = PutComputeClusterIdfwConfigurationServiceURL.ToString();
            RestResponse<NSXTComputeClusterIdfwConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComputeClusterIdfwConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PutComputeClusterIdfwConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTComputeClusterIdfwConfigurationType> GetComputeClusterIdfwConfiguration(string ClusterId)
        {
            if (ClusterId == null) { throw new System.ArgumentNullException("ClusterId cannot be null"); }
            StringBuilder GetComputeClusterIdfwConfigurationServiceURL = new StringBuilder("/infra/settings/firewall/idfw/cluster/{cluster-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetComputeClusterIdfwConfigurationServiceURL.Replace("{cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetComputeClusterIdfwConfigurationServiceURL.ToString();
            RestResponse<NSXTComputeClusterIdfwConfigurationType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComputeClusterIdfwConfigurationType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetComputeClusterIdfwConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchComputeClusterIdfwConfiguration(string ClusterId, NSXTComputeClusterIdfwConfigurationType ComputeClusterIdfwConfiguration)
        {
            if (ClusterId == null) { throw new System.ArgumentNullException("ClusterId cannot be null"); }
            if (ComputeClusterIdfwConfiguration == null) { throw new System.ArgumentNullException("ComputeClusterIdfwConfiguration cannot be null"); }
            StringBuilder PatchComputeClusterIdfwConfigurationServiceURL = new StringBuilder("/infra/settings/firewall/idfw/cluster/{cluster-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchComputeClusterIdfwConfigurationServiceURL.Replace("{cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ComputeClusterIdfwConfiguration);
            request.Resource = PatchComputeClusterIdfwConfigurationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchComputeClusterIdfwConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteComputeClusterIdfwConfiguration(string ClusterId)
        {
            if (ClusterId == null) { throw new System.ArgumentNullException("ClusterId cannot be null"); }
            StringBuilder DeleteComputeClusterIdfwConfigurationServiceURL = new StringBuilder("/infra/settings/firewall/idfw/cluster/{cluster-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteComputeClusterIdfwConfigurationServiceURL.Replace("{cluster-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ClusterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteComputeClusterIdfwConfigurationServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteComputeClusterIdfwConfigurationServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyExcludeListType> PutExcludeList(NSXTPolicyExcludeListType PolicyExcludeList)
        {
            if (PolicyExcludeList == null) { throw new System.ArgumentNullException("PolicyExcludeList cannot be null"); }
            StringBuilder PutExcludeListServiceURL = new StringBuilder("/infra/settings/firewall/security/exclude-list");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(PolicyExcludeList);
            request.Resource = PutExcludeListServiceURL.ToString();
            RestResponse<NSXTPolicyExcludeListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyExcludeListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + PutExcludeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchExcludeList(NSXTPolicyExcludeListType PolicyExcludeList)
        {
            if (PolicyExcludeList == null) { throw new System.ArgumentNullException("PolicyExcludeList cannot be null"); }
            StringBuilder PatchExcludeListServiceURL = new StringBuilder("/infra/settings/firewall/security/exclude-list");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            request.AddJsonBody(PolicyExcludeList);
            request.Resource = PatchExcludeListServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchExcludeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyExcludeListType> GetFirewallExcludeList()
        {
            StringBuilder GetFirewallExcludeListServiceURL = new StringBuilder("/infra/settings/firewall/security/exclude-list");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetFirewallExcludeListServiceURL.ToString();
            RestResponse<NSXTPolicyExcludeListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyExcludeListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFirewallExcludeListServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyResourceReferenceForEPListResultType> GlobalGlobalInfraGetFilteredPolicies(string Scope, string? EnforcementPointPath = null, string? ParentPath = null)
        {
            if (Scope == null) { throw new System.ArgumentNullException("Scope cannot be null"); }
            StringBuilder GlobalInfraGetFilteredPoliciesServiceURL = new StringBuilder("/global-infra/firewall/policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (ParentPath != null) { request.AddQueryParameter("parent_path", ParentPath.ToString()); }
            if (Scope != null) { request.AddQueryParameter("scope", Scope.ToString()); }
            request.Resource = GlobalInfraGetFilteredPoliciesServiceURL.ToString();
            RestResponse<NSXTPolicyResourceReferenceForEPListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyResourceReferenceForEPListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetFilteredPoliciesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
