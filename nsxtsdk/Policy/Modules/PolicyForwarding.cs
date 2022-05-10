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
    public class PolicyForwarding
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyForwarding(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTForwardingRuleType> CreateOrUpdateForwardingRule(string DomainId, string ForwardingPolicyId, string RuleId, NSXTForwardingRuleType ForwardingRule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (ForwardingRule == null) { throw new System.ArgumentNullException("ForwardingRule cannot be null"); }
            StringBuilder CreateOrUpdateForwardingRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateForwardingRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateForwardingRuleServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateForwardingRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ForwardingRule);
            request.Resource = CreateOrUpdateForwardingRuleServiceURL.ToString();
            RestResponse<NSXTForwardingRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTForwardingRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateForwardingRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTForwardingRuleType> ReadForwardingRule(string DomainId, string ForwardingPolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder ReadForwardingRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadForwardingRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadForwardingRuleServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadForwardingRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadForwardingRuleServiceURL.ToString();
            RestResponse<NSXTForwardingRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTForwardingRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadForwardingRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchForwardingRule(string DomainId, string ForwardingPolicyId, string RuleId, NSXTForwardingRuleType ForwardingRule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (ForwardingRule == null) { throw new System.ArgumentNullException("ForwardingRule cannot be null"); }
            StringBuilder PatchForwardingRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchForwardingRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchForwardingRuleServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchForwardingRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ForwardingRule);
            request.Resource = PatchForwardingRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchForwardingRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteForwardingRule(string DomainId, string ForwardingPolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder DeleteForwardingRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteForwardingRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteForwardingRuleServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteForwardingRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteForwardingRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteForwardingRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTForwardingRuleListResultType> ListForwardingRule(string DomainId, string ForwardingPolicyId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            StringBuilder ListForwardingRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListForwardingRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListForwardingRuleServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListForwardingRuleServiceURL.ToString();
            RestResponse<NSXTForwardingRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTForwardingRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListForwardingRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTForwardingRuleType> GlobalGlobalInfraReadForwardingRule(string DomainId, string ForwardingPolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GlobalInfraReadForwardingRuleServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadForwardingRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadForwardingRuleServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadForwardingRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadForwardingRuleServiceURL.ToString();
            RestResponse<NSXTForwardingRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTForwardingRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadForwardingRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTForwardingPolicyListResultType> ListForwardingPolicies(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, bool? IncludeRuleCount = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder ListForwardingPoliciesServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListForwardingPoliciesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludeRuleCount != null) { request.AddQueryParameter("include_rule_count", IncludeRuleCount.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListForwardingPoliciesServiceURL.ToString();
            RestResponse<NSXTForwardingPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTForwardingPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListForwardingPoliciesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTForwardingPolicyType> CreateOrUpdateForwardingPolicy(string DomainId, string ForwardingPolicyId, NSXTForwardingPolicyType ForwardingPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            if (ForwardingPolicy == null) { throw new System.ArgumentNullException("ForwardingPolicy cannot be null"); }
            StringBuilder CreateOrUpdateForwardingPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateForwardingPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateForwardingPolicyServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ForwardingPolicy);
            request.Resource = CreateOrUpdateForwardingPolicyServiceURL.ToString();
            RestResponse<NSXTForwardingPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTForwardingPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateForwardingPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchForwardingPolicy(string DomainId, string ForwardingPolicyId, NSXTForwardingPolicyType ForwardingPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            if (ForwardingPolicy == null) { throw new System.ArgumentNullException("ForwardingPolicy cannot be null"); }
            StringBuilder PatchForwardingPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchForwardingPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchForwardingPolicyServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ForwardingPolicy);
            request.Resource = PatchForwardingPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchForwardingPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteForwardingPolicy(string DomainId, string ForwardingPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            StringBuilder DeleteForwardingPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteForwardingPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteForwardingPolicyServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteForwardingPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteForwardingPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTForwardingPolicyType> ReadForwardingPolicy(string DomainId, string ForwardingPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            StringBuilder ReadForwardingPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadForwardingPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadForwardingPolicyServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadForwardingPolicyServiceURL.ToString();
            RestResponse<NSXTForwardingPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTForwardingPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadForwardingPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTForwardingPolicyType> GlobalGlobalInfraReadForwardingPolicy(string DomainId, string ForwardingPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            StringBuilder GlobalInfraReadForwardingPolicyServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraReadForwardingPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraReadForwardingPolicyServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GlobalInfraReadForwardingPolicyServiceURL.ToString();
            RestResponse<NSXTForwardingPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTForwardingPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraReadForwardingPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTForwardingPolicyListResultType> GlobalGlobalInfraListForwardingPolicies(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, bool? IncludeRuleCount = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            StringBuilder GlobalInfraListForwardingPoliciesServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/forwarding-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListForwardingPoliciesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludeRuleCount != null) { request.AddQueryParameter("include_rule_count", IncludeRuleCount.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListForwardingPoliciesServiceURL.ToString();
            RestResponse<NSXTForwardingPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTForwardingPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListForwardingPoliciesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTForwardingRuleListResultType> GlobalGlobalInfraListForwardingRule(string DomainId, string ForwardingPolicyId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (ForwardingPolicyId == null) { throw new System.ArgumentNullException("ForwardingPolicyId cannot be null"); }
            StringBuilder GlobalInfraListForwardingRuleServiceURL = new StringBuilder("/global-infra/domains/{domain-id}/forwarding-policies/{forwarding-policy-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraListForwardingRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraListForwardingRuleServiceURL.Replace("{forwarding-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwardingPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = GlobalInfraListForwardingRuleServiceURL.ToString();
            RestResponse<NSXTForwardingRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTForwardingRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraListForwardingRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
