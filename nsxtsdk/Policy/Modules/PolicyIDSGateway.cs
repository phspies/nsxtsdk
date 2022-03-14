// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

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
    public class PolicyIDSGateway
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public PolicyIDSGateway(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsRuleType> CreateOrReplaceIdsGatewayRule(string DomainId, string PolicyId, string RuleId, NSXTIdsRuleType IdsRule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (IdsRule == null) { throw new System.ArgumentNullException("IdsRule cannot be null"); }
            NSXTIdsRuleType returnValue = default(NSXTIdsRuleType);
            StringBuilder CreateOrReplaceIdsGatewayRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrReplaceIdsGatewayRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceIdsGatewayRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceIdsGatewayRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IdsRule, defaultSerializationSettings));
            request.Resource = CreateOrReplaceIdsGatewayRuleServiceURL.ToString();
            IRestResponse<NSXTIdsRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrReplaceIdsGatewayRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIdsGatewayRule(string DomainId, string PolicyId, string RuleId, NSXTIdsRuleType IdsRule)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (IdsRule == null) { throw new System.ArgumentNullException("IdsRule cannot be null"); }
            
            StringBuilder PatchIdsGatewayRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchIdsGatewayRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchIdsGatewayRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchIdsGatewayRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IdsRule, defaultSerializationSettings));
            request.Resource = PatchIdsGatewayRuleServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchIdsGatewayRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsRuleType> ReadIdsGatewayRule(string DomainId, string PolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            NSXTIdsRuleType returnValue = default(NSXTIdsRuleType);
            StringBuilder ReadIdsGatewayRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadIdsGatewayRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadIdsGatewayRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadIdsGatewayRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIdsGatewayRuleServiceURL.ToString();
            IRestResponse<NSXTIdsRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadIdsGatewayRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIdsGatewayRule(string DomainId, string PolicyId, string RuleId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            
            StringBuilder DeleteIdsGatewayRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteIdsGatewayRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteIdsGatewayRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteIdsGatewayRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIdsGatewayRuleServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteIdsGatewayRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsGatewayPolicyType> ReviseIdsGatewayPolicy(string DomainId, string PolicyId, NSXTIdsGatewayPolicyType IdsGatewayPolicy, string? AnchorPath = null, string? Operation = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (IdsGatewayPolicy == null) { throw new System.ArgumentNullException("IdsGatewayPolicy cannot be null"); }
            NSXTIdsGatewayPolicyType returnValue = default(NSXTIdsGatewayPolicyType);
            StringBuilder ReviseIdsGatewayPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            ReviseIdsGatewayPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseIdsGatewayPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IdsGatewayPolicy, defaultSerializationSettings));
            if (AnchorPath != null) { request.AddQueryParameter("anchor_path", AnchorPath.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseIdsGatewayPolicyServiceURL.ToString();
            IRestResponse<NSXTIdsGatewayPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsGatewayPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + ReviseIdsGatewayPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsGatewayPolicyListResultType> ListIdsGatewayPolicies(string DomainId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, bool? IncludeRuleCount = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            NSXTIdsGatewayPolicyListResultType returnValue = default(NSXTIdsGatewayPolicyListResultType);
            StringBuilder ListIdsGatewayPoliciesServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ListIdsGatewayPoliciesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludeRuleCount != null) { request.AddQueryParameter("include_rule_count", IncludeRuleCount.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIdsGatewayPoliciesServiceURL.ToString();
            IRestResponse<NSXTIdsGatewayPolicyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsGatewayPolicyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListIdsGatewayPoliciesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsGatewayPolicyType> CreateOrReplaceIdsGatewayPolicy(string DomainId, string PolicyId, NSXTIdsGatewayPolicyType IdsGatewayPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (IdsGatewayPolicy == null) { throw new System.ArgumentNullException("IdsGatewayPolicy cannot be null"); }
            NSXTIdsGatewayPolicyType returnValue = default(NSXTIdsGatewayPolicyType);
            StringBuilder CreateOrReplaceIdsGatewayPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PUT
            };
            request.AddHeader("Content-type", "application/json");
            CreateOrReplaceIdsGatewayPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            CreateOrReplaceIdsGatewayPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IdsGatewayPolicy, defaultSerializationSettings));
            request.Resource = CreateOrReplaceIdsGatewayPolicyServiceURL.ToString();
            IRestResponse<NSXTIdsGatewayPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsGatewayPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PUT operation to " + CreateOrReplaceIdsGatewayPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteIdsGatewayPolicy(string DomainId, string PolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            
            StringBuilder DeleteIdsGatewayPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.DELETE
            };
            request.AddHeader("Content-type", "application/json");
            DeleteIdsGatewayPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteIdsGatewayPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteIdsGatewayPolicyServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP DELETE operation to " + DeleteIdsGatewayPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task PatchIdsGatewayPolicy(string DomainId, string PolicyId, NSXTIdsGatewayPolicyType IdsGatewayPolicy)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (IdsGatewayPolicy == null) { throw new System.ArgumentNullException("IdsGatewayPolicy cannot be null"); }
            
            StringBuilder PatchIdsGatewayPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.PATCH
            };
            request.AddHeader("Content-type", "application/json");
            PatchIdsGatewayPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            PatchIdsGatewayPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IdsGatewayPolicy, defaultSerializationSettings));
            request.Resource = PatchIdsGatewayPolicyServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP PATCH operation to " + PatchIdsGatewayPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsGatewayPolicyType> ReadIdsGatewayPolicy(string DomainId, string PolicyId)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            NSXTIdsGatewayPolicyType returnValue = default(NSXTIdsGatewayPolicyType);
            StringBuilder ReadIdsGatewayPolicyServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ReadIdsGatewayPolicyServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadIdsGatewayPolicyServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadIdsGatewayPolicyServiceURL.ToString();
            IRestResponse<NSXTIdsGatewayPolicyType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsGatewayPolicyType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ReadIdsGatewayPolicyServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsRuleType> ReviseIdsGatewayRule(string DomainId, string PolicyId, string RuleId, NSXTIdsRuleType IdsRule, string? AnchorPath = null, string? Operation = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (IdsRule == null) { throw new System.ArgumentNullException("IdsRule cannot be null"); }
            NSXTIdsRuleType returnValue = default(NSXTIdsRuleType);
            StringBuilder ReviseIdsGatewayRuleServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}/rules/{rule-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            ReviseIdsGatewayRuleServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseIdsGatewayRuleServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseIdsGatewayRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(IdsRule, defaultSerializationSettings));
            if (AnchorPath != null) { request.AddQueryParameter("anchor_path", AnchorPath.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseIdsGatewayRuleServiceURL.ToString();
            IRestResponse<NSXTIdsRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + ReviseIdsGatewayRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIdsRuleListResultType> ListIdsGatewayRules(string DomainId, string PolicyId, string? Cursor = null, bool? IncludeMarkForDeleteObjects = null, string? IncludedFields = null, long? PageSize = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (DomainId == null) { throw new System.ArgumentNullException("DomainId cannot be null"); }
            if (PolicyId == null) { throw new System.ArgumentNullException("PolicyId cannot be null"); }
            NSXTIdsRuleListResultType returnValue = default(NSXTIdsRuleListResultType);
            StringBuilder ListIdsGatewayRulesServiceURL = new StringBuilder("/infra/domains/{domain-id}/intrusion-service-gateway-policies/{policy-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            ListIdsGatewayRulesServiceURL.Replace("{domain-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DomainId, System.Globalization.CultureInfo.InvariantCulture)));
            ListIdsGatewayRulesServiceURL.Replace("{policy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(PolicyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludeMarkForDeleteObjects != null) { request.AddQueryParameter("include_mark_for_delete_objects", IncludeMarkForDeleteObjects.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListIdsGatewayRulesServiceURL.ToString();
            IRestResponse<NSXTIdsRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIdsRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + ListIdsGatewayRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
