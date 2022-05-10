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
    public class PolicyTlsPolicy
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyTlsPolicy(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTTlsRuleListResultType> ListTlsRules(string PolicyId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            StringBuilder ListTlsRulesServiceURL = new StringBuilder("/infra/tls-inspection-policies/{policy-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTlsRulesServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTlsRulesServiceURL.ToString();
            RestResponse<NSXTTlsRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTlsRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsPolicyListResultType> ListTlsPolicies(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, bool? IncludeRuleCount = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListTlsPoliciesServiceURL = new StringBuilder("/infra/tls-inspection-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludeRuleCount != null) { request.AddQueryParameter("include_rule_count", IncludeRuleCount.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListTlsPoliciesServiceURL.ToString();
            RestResponse<NSXTTlsPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTlsPoliciesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsPolicyType> CreateOrReplaceTlsPolicy(string PolicyId, NSXTTlsPolicyType TlsPolicy)
        {
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (TlsPolicy == null) { throw new System.ArgumentNullException("TlsPolicy cannot be null"); }
            StringBuilder CreateOrReplaceTlsPolicyServiceURL = new StringBuilder("/infra/tls-inspection-policies/{policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTlsPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsPolicy);
            request.Resource = CreateOrReplaceTlsPolicyServiceURL.ToString();
            RestResponse<NSXTTlsPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTlsPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsPolicyType> ReadTlsPolicy(string PolicyId)
        {
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            StringBuilder ReadTlsPolicyServiceURL = new StringBuilder("/infra/tls-inspection-policies/{policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTlsPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTlsPolicyServiceURL.ToString();
            RestResponse<NSXTTlsPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTlsPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTlsPolicy(string PolicyId)
        {
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            StringBuilder DeleteTlsPolicyServiceURL = new StringBuilder("/infra/tls-inspection-policies/{policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTlsPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTlsPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTlsPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsPolicyType> PatchTlsPolicy(string PolicyId, NSXTTlsPolicyType TlsPolicy)
        {
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (TlsPolicy == null) { throw new System.ArgumentNullException("TlsPolicy cannot be null"); }
            StringBuilder PatchTlsPolicyServiceURL = new StringBuilder("/infra/tls-inspection-policies/{policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTlsPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsPolicy);
            request.Resource = PatchTlsPolicyServiceURL.ToString();
            RestResponse<NSXTTlsPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTlsPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsRuleType> CreateOrReplaceTlsRule(string PolicyId, string RuleId, NSXTTlsRuleType TlsRule)
        {
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (TlsRule == null) { throw new System.ArgumentNullException("TlsRule cannot be null"); }
            StringBuilder CreateOrReplaceTlsRuleServiceURL = new StringBuilder("/infra/tls-inspection-policies/{policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrReplaceTlsRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceTlsRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsRule);
            request.Resource = CreateOrReplaceTlsRuleServiceURL.ToString();
            RestResponse<NSXTTlsRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrReplaceTlsRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteTlsRule(string PolicyId, string RuleId)
        {
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder DeleteTlsRuleServiceURL = new StringBuilder("/infra/tls-inspection-policies/{policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTlsRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteTlsRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTlsRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteTlsRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsRuleType> PatchTlsRule(string PolicyId, string RuleId, NSXTTlsRuleType TlsRule)
        {
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (TlsRule == null) { throw new System.ArgumentNullException("TlsRule cannot be null"); }
            StringBuilder PatchTlsRuleServiceURL = new StringBuilder("/infra/tls-inspection-policies/{policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchTlsRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchTlsRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(TlsRule);
            request.Resource = PatchTlsRuleServiceURL.ToString();
            RestResponse<NSXTTlsRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchTlsRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTTlsRuleType> ReadTlsRule(string PolicyId, string RuleId)
        {
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder ReadTlsRuleServiceURL = new StringBuilder("/infra/tls-inspection-policies/{policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTlsRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTlsRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadTlsRuleServiceURL.ToString();
            RestResponse<NSXTTlsRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTTlsRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTlsRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
