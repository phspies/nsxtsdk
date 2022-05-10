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
    public class PolicyNAT
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyNAT(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPolicyNatRuleStatisticsListResultType> GetPolicyNatRuleStatisticsFromTier1(string Tier1Id, string NatId, string NatRuleId, string? Action = null, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            StringBuilder GetPolicyNatRuleStatisticsFromTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/nat/{nat-id}/nat-rules/{nat-rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyNatRuleStatisticsFromTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyNatRuleStatisticsFromTier1ServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyNatRuleStatisticsFromTier1ServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetPolicyNatRuleStatisticsFromTier1ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyNatRuleStatisticsFromTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleListResultType> ListPolicyNatRules(string Tier1Id, string NatId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            StringBuilder ListPolicyNatRulesServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/nat/{nat-id}/nat-rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPolicyNatRulesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListPolicyNatRulesServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyNatRulesServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyNatRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleType> GlobalGlobalInfraGetPolicyNatRuleFromTier0(string Tier0Id, string NatId, string NatRuleId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            StringBuilder GlobalInfraGetPolicyNatRuleFromTier0ServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/nat/{nat-id}/nat-rules/{nat-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPolicyNatRuleFromTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyNatRuleFromTier0ServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyNatRuleFromTier0ServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPolicyNatRuleFromTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyNatRuleFromTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleListResultType> ListPolicyNatRulesFromTier0(string Tier0Id, string NatId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            StringBuilder ListPolicyNatRulesFromTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/nat/{nat-id}/nat-rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPolicyNatRulesFromTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ListPolicyNatRulesFromTier0ServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyNatRulesFromTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyNatRulesFromTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleType> CreateOrReplacePolicyNatRule(string Tier1Id, string NatId, string NatRuleId, NSXTPolicyNatRuleType PolicyNatRule)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            if (PolicyNatRule == null) { throw new System.ArgumentNullException("PolicyNatRule cannot be null"); }
            StringBuilder CreateOrReplacePolicyNatRuleServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/nat/{nat-id}/nat-rules/{nat-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplacePolicyNatRuleServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplacePolicyNatRuleServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplacePolicyNatRuleServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyNatRule);
            request.Resource = CreateOrReplacePolicyNatRuleServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplacePolicyNatRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyNatRule(string Tier1Id, string NatId, string NatRuleId, NSXTPolicyNatRuleType PolicyNatRule)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            if (PolicyNatRule == null) { throw new System.ArgumentNullException("PolicyNatRule cannot be null"); }
            StringBuilder PatchPolicyNatRuleServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/nat/{nat-id}/nat-rules/{nat-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyNatRuleServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyNatRuleServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyNatRuleServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyNatRule);
            request.Resource = PatchPolicyNatRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyNatRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleType> GetPolicyNatRule(string Tier1Id, string NatId, string NatRuleId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            StringBuilder GetPolicyNatRuleServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/nat/{nat-id}/nat-rules/{nat-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyNatRuleServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyNatRuleServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyNatRuleServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyNatRuleServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyNatRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyNatRule(string Tier1Id, string NatId, string NatRuleId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            StringBuilder DeletePolicyNatRuleServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/nat/{nat-id}/nat-rules/{nat-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyNatRuleServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyNatRuleServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyNatRuleServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyNatRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyNatRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatListResultType> GlobalGlobalInfraListPolicyNatOnTier0(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraListPolicyNatOnTier0ServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/nat");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPolicyNatOnTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPolicyNatOnTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyNatListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyNatOnTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleStatisticsPerLogicalRouterListResultType> ListPolicyNatRulesStatisticsFromTier0(string Tier0Id, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ListPolicyNatRulesStatisticsFromTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/nat/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPolicyNatRulesStatisticsFromTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyNatRulesStatisticsFromTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleStatisticsPerLogicalRouterListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleStatisticsPerLogicalRouterListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyNatRulesStatisticsFromTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleStatisticsListResultType> GlobalGlobalInfraGetPolicyNatRuleStatisticsFromTier0(string Tier0Id, string NatId, string NatRuleId, string? Action = null, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            StringBuilder GlobalInfraGetPolicyNatRuleStatisticsFromTier0ServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/nat/{nat-id}/nat-rules/{nat-rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPolicyNatRuleStatisticsFromTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyNatRuleStatisticsFromTier0ServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyNatRuleStatisticsFromTier0ServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraGetPolicyNatRuleStatisticsFromTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyNatRuleStatisticsFromTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleStatisticsPerLogicalRouterListResultType> GlobalGlobalInfraListPolicyNatRulesStatisticsFromTier0(string Tier0Id, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraListPolicyNatRulesStatisticsFromTier0ServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/nat/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPolicyNatRulesStatisticsFromTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPolicyNatRulesStatisticsFromTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleStatisticsPerLogicalRouterListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleStatisticsPerLogicalRouterListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyNatRulesStatisticsFromTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleListResultType> GlobalGlobalInfraListPolicyNatRulesFromTier0(string Tier0Id, string NatId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            StringBuilder GlobalInfraListPolicyNatRulesFromTier0ServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/nat/{nat-id}/nat-rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPolicyNatRulesFromTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListPolicyNatRulesFromTier0ServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPolicyNatRulesFromTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyNatRulesFromTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleStatisticsPerLogicalRouterListResultType> GlobalGlobalInfraListPolicyNatRulesStatisticsFromTier1(string Tier1Id, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraListPolicyNatRulesStatisticsFromTier1ServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/nat/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPolicyNatRulesStatisticsFromTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPolicyNatRulesStatisticsFromTier1ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleStatisticsPerLogicalRouterListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleStatisticsPerLogicalRouterListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyNatRulesStatisticsFromTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleStatisticsListResultType> GlobalGlobalInfraGetPolicyNatRuleStatisticsFromTier1(string Tier1Id, string NatId, string NatRuleId, string? Action = null, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            StringBuilder GlobalInfraGetPolicyNatRuleStatisticsFromTier1ServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/nat/{nat-id}/nat-rules/{nat-rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPolicyNatRuleStatisticsFromTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyNatRuleStatisticsFromTier1ServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyNatRuleStatisticsFromTier1ServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraGetPolicyNatRuleStatisticsFromTier1ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyNatRuleStatisticsFromTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleStatisticsPerLogicalRouterListResultType> ListPolicyNatRulesStatisticsFromTier1(string Tier1Id, string? Cursor = null, string? EnforcementPointPath = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ListPolicyNatRulesStatisticsFromTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/nat/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPolicyNatRulesStatisticsFromTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyNatRulesStatisticsFromTier1ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleStatisticsPerLogicalRouterListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleStatisticsPerLogicalRouterListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyNatRulesStatisticsFromTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleStatisticsListResultType> GetPolicyNatRuleStatisticsFromTier0(string Tier0Id, string NatId, string NatRuleId, string? Action = null, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            StringBuilder GetPolicyNatRuleStatisticsFromTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/nat/{nat-id}/nat-rules/{nat-rule-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyNatRuleStatisticsFromTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyNatRuleStatisticsFromTier0ServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyNatRuleStatisticsFromTier0ServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetPolicyNatRuleStatisticsFromTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleStatisticsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleStatisticsListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyNatRuleStatisticsFromTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleType> CreateOrReplacePolicyNatRuleOnTier0(string Tier0Id, string NatId, string NatRuleId, NSXTPolicyNatRuleType PolicyNatRule)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            if (PolicyNatRule == null) { throw new System.ArgumentNullException("PolicyNatRule cannot be null"); }
            StringBuilder CreateOrReplacePolicyNatRuleOnTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/nat/{nat-id}/nat-rules/{nat-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplacePolicyNatRuleOnTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplacePolicyNatRuleOnTier0ServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplacePolicyNatRuleOnTier0ServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyNatRule);
            request.Resource = CreateOrReplacePolicyNatRuleOnTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplacePolicyNatRuleOnTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleType> GetPolicyNatRuleFromTier0(string Tier0Id, string NatId, string NatRuleId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            StringBuilder GetPolicyNatRuleFromTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/nat/{nat-id}/nat-rules/{nat-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetPolicyNatRuleFromTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyNatRuleFromTier0ServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            GetPolicyNatRuleFromTier0ServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetPolicyNatRuleFromTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetPolicyNatRuleFromTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchPolicyNatRuleOnTier0(string Tier0Id, string NatId, string NatRuleId, NSXTPolicyNatRuleType PolicyNatRule)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            if (PolicyNatRule == null) { throw new System.ArgumentNullException("PolicyNatRule cannot be null"); }
            StringBuilder PatchPolicyNatRuleOnTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/nat/{nat-id}/nat-rules/{nat-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchPolicyNatRuleOnTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyNatRuleOnTier0ServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchPolicyNatRuleOnTier0ServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(PolicyNatRule);
            request.Resource = PatchPolicyNatRuleOnTier0ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchPolicyNatRuleOnTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeletePolicyNatRuleFromTier0(string Tier0Id, string NatId, string NatRuleId)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            StringBuilder DeletePolicyNatRuleFromTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/nat/{nat-id}/nat-rules/{nat-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeletePolicyNatRuleFromTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyNatRuleFromTier0ServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            DeletePolicyNatRuleFromTier0ServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeletePolicyNatRuleFromTier0ServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeletePolicyNatRuleFromTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleType> GlobalGlobalInfraGetPolicyNatRule(string Tier1Id, string NatId, string NatRuleId)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            if (NatRuleId == null) { throw new System.ArgumentNullException("NatRuleId cannot be null"); }
            StringBuilder GlobalInfraGetPolicyNatRuleServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/nat/{nat-id}/nat-rules/{nat-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetPolicyNatRuleServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyNatRuleServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraGetPolicyNatRuleServiceURL.Replace("{nat-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraGetPolicyNatRuleServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetPolicyNatRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatListResultType> GlobalGlobalInfraListPolicyNatOnTier1(string Tier1Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraListPolicyNatOnTier1ServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/nat");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPolicyNatOnTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPolicyNatOnTier1ServiceURL.ToString();
            RestResponse<NSXTPolicyNatListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyNatOnTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatListResultType> ListPolicyNatOnTier1(string Tier1Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder ListPolicyNatOnTier1ServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/nat");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPolicyNatOnTier1ServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyNatOnTier1ServiceURL.ToString();
            RestResponse<NSXTPolicyNatListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyNatOnTier1ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatListResultType> ListPolicyNatOnTier0(string Tier0Id, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder ListPolicyNatOnTier0ServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/nat");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListPolicyNatOnTier0ServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListPolicyNatOnTier0ServiceURL.ToString();
            RestResponse<NSXTPolicyNatListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListPolicyNatOnTier0ServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyNatRuleListResultType> GlobalGlobalInfraListPolicyNatRules(string Tier1Id, string NatId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (NatId == null) { throw new System.ArgumentNullException("NatId cannot be null"); }
            StringBuilder GlobalInfraListPolicyNatRulesServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/nat/{nat-id}/nat-rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListPolicyNatRulesServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListPolicyNatRulesServiceURL.Replace("{nat-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NatId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListPolicyNatRulesServiceURL.ToString();
            RestResponse<NSXTPolicyNatRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyNatRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListPolicyNatRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
