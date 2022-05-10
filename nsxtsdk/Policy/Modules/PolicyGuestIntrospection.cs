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
    public class PolicyGuestIntrospection
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyGuestIntrospection(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTEndpointRuleListResultType> ListEndpointRule(string DomainId, string EndpointPolicyId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (EndpointPolicyId == null) { throw new System.ArgumentNullException("EndpointPolicyId cannot be null"); }
            StringBuilder ListEndpointRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/endpoint-policies/{endpoint-policy-id}/endpoint-rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListEndpointRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListEndpointRuleServiceURL.Replace("{endpoint-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListEndpointRuleServiceURL.ToString();
            RestResponse<NSXTEndpointRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEndpointRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListEndpointRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEndpointPolicyType> CreateOrUpdateEndpointPolicy(string DomainId, string EndpointPolicyId, NSXTEndpointPolicyType EndpointPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (EndpointPolicyId == null) { throw new System.ArgumentNullException("EndpointPolicyId cannot be null"); }
            if (EndpointPolicy == null) { throw new System.ArgumentNullException("EndpointPolicy cannot be null"); }
            StringBuilder CreateOrUpdateEndpointPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/endpoint-policies/{endpoint-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateEndpointPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateEndpointPolicyServiceURL.Replace("{endpoint-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EndpointPolicy);
            request.Resource = CreateOrUpdateEndpointPolicyServiceURL.ToString();
            RestResponse<NSXTEndpointPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEndpointPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateEndpointPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchEndpointPolicy(string DomainId, string EndpointPolicyId, NSXTEndpointPolicyType EndpointPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (EndpointPolicyId == null) { throw new System.ArgumentNullException("EndpointPolicyId cannot be null"); }
            if (EndpointPolicy == null) { throw new System.ArgumentNullException("EndpointPolicy cannot be null"); }
            StringBuilder PatchEndpointPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/endpoint-policies/{endpoint-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchEndpointPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchEndpointPolicyServiceURL.Replace("{endpoint-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EndpointPolicy);
            request.Resource = PatchEndpointPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchEndpointPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEndpointPolicyType> ReadEndpointPolicy(string DomainId, string EndpointPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (EndpointPolicyId == null) { throw new System.ArgumentNullException("EndpointPolicyId cannot be null"); }
            StringBuilder ReadEndpointPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/endpoint-policies/{endpoint-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadEndpointPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadEndpointPolicyServiceURL.Replace("{endpoint-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadEndpointPolicyServiceURL.ToString();
            RestResponse<NSXTEndpointPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEndpointPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadEndpointPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteEndpointPolicy(string DomainId, string EndpointPolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (EndpointPolicyId == null) { throw new System.ArgumentNullException("EndpointPolicyId cannot be null"); }
            StringBuilder DeleteEndpointPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/endpoint-policies/{endpoint-policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteEndpointPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteEndpointPolicyServiceURL.Replace("{endpoint-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteEndpointPolicyServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteEndpointPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEndpointPolicyListResultType> ListEndpointPoliciesAcrossAllDomains(string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            StringBuilder ListEndpointPoliciesAcrossAllDomainsServiceURL = new StringBuilder("/infra/domains/endpoint-policies");
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
            request.Resource = ListEndpointPoliciesAcrossAllDomainsServiceURL.ToString();
            RestResponse<NSXTEndpointPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEndpointPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListEndpointPoliciesAcrossAllDomainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEndpointRuleType> CreateOrUpdateEndpointRule(string DomainId, string EndpointPolicyId, string EndpointRuleId, NSXTEndpointRuleType EndpointRule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (EndpointPolicyId == null) { throw new System.ArgumentNullException("EndpointPolicyId cannot be null"); }
            if (EndpointRuleId == null) { throw new System.ArgumentNullException("EndpointRuleId cannot be null"); }
            if (EndpointRule == null) { throw new System.ArgumentNullException("EndpointRule cannot be null"); }
            StringBuilder CreateOrUpdateEndpointRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/endpoint-policies/{endpoint-policy-id}/endpoint-rules/{endpoint-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            CreateOrUpdateEndpointRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateEndpointRuleServiceURL.Replace("{endpoint-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrUpdateEndpointRuleServiceURL.Replace("{endpoint-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EndpointRule);
            request.Resource = CreateOrUpdateEndpointRuleServiceURL.ToString();
            RestResponse<NSXTEndpointRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEndpointRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + CreateOrUpdateEndpointRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchEndpointRule(string DomainId, string EndpointPolicyId, string EndpointRuleId, NSXTEndpointRuleType EndpointRule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (EndpointPolicyId == null) { throw new System.ArgumentNullException("EndpointPolicyId cannot be null"); }
            if (EndpointRuleId == null) { throw new System.ArgumentNullException("EndpointRuleId cannot be null"); }
            if (EndpointRule == null) { throw new System.ArgumentNullException("EndpointRule cannot be null"); }
            StringBuilder PatchEndpointRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/endpoint-policies/{endpoint-policy-id}/endpoint-rules/{endpoint-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            PatchEndpointRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchEndpointRuleServiceURL.Replace("{endpoint-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchEndpointRuleServiceURL.Replace("{endpoint-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(EndpointRule);
            request.Resource = PatchEndpointRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + PatchEndpointRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTEndpointRuleType> ReadEndpointRule(string DomainId, string EndpointPolicyId, string EndpointRuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (EndpointPolicyId == null) { throw new System.ArgumentNullException("EndpointPolicyId cannot be null"); }
            if (EndpointRuleId == null) { throw new System.ArgumentNullException("EndpointRuleId cannot be null"); }
            StringBuilder ReadEndpointRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/endpoint-policies/{endpoint-policy-id}/endpoint-rules/{endpoint-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadEndpointRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadEndpointRuleServiceURL.Replace("{endpoint-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadEndpointRuleServiceURL.Replace("{endpoint-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadEndpointRuleServiceURL.ToString();
            RestResponse<NSXTEndpointRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTEndpointRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadEndpointRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteEndpointRule(string DomainId, string EndpointPolicyId, string EndpointRuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (EndpointPolicyId == null) { throw new System.ArgumentNullException("EndpointPolicyId cannot be null"); }
            if (EndpointRuleId == null) { throw new System.ArgumentNullException("EndpointRuleId cannot be null"); }
            StringBuilder DeleteEndpointRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/endpoint-policies/{endpoint-policy-id}/endpoint-rules/{endpoint-rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteEndpointRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteEndpointRuleServiceURL.Replace("{endpoint-policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointPolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteEndpointRuleServiceURL.Replace("{endpoint-rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointRuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteEndpointRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteEndpointRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
