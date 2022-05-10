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
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class Firewall
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Firewall(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTFirewallRuleType> ReadFirewallRule(string RuleId)
        {
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder ReadFirewallRuleServiceURL = new StringBuilder("/firewall/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadFirewallRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadFirewallRuleServiceURL.ToString();
            RestResponse<NSXTFirewallRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadFirewallRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallSectionRuleListType> ReviseSectionWithRules(string SectionId, NSXTFirewallSectionRuleListType FirewallSectionRuleList, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (FirewallSectionRuleList == null) { throw new System.ArgumentNullException("FirewallSectionRuleList cannot be null"); }
            StringBuilder ReviseSectionWithRulesServiceURL = new StringBuilder("/firewall/sections/{section-id}?action=revise_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseSectionWithRulesServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FirewallSectionRuleList);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseSectionWithRulesServiceURL.ToString();
            RestResponse<NSXTFirewallSectionRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallSectionRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseSectionWithRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallSectionRuleListType> UpdateSectionWithRules(string SectionId, NSXTFirewallSectionRuleListType FirewallSectionRuleList)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (FirewallSectionRuleList == null) { throw new System.ArgumentNullException("FirewallSectionRuleList cannot be null"); }
            StringBuilder UpdateSectionWithRulesServiceURL = new StringBuilder("/firewall/sections/{section-id}?action=update_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UpdateSectionWithRulesServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FirewallSectionRuleList);
            request.Resource = UpdateSectionWithRulesServiceURL.ToString();
            RestResponse<NSXTFirewallSectionRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallSectionRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UpdateSectionWithRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallRuleListType> AddRulesInSection(string SectionId, NSXTFirewallRuleListType FirewallRuleList, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (FirewallRuleList == null) { throw new System.ArgumentNullException("FirewallRuleList cannot be null"); }
            StringBuilder AddRulesInSectionServiceURL = new StringBuilder("/firewall/sections/{section-id}/rules?action=create_multiple");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddRulesInSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FirewallRuleList);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = AddRulesInSectionServiceURL.ToString();
            RestResponse<NSXTFirewallRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddRulesInSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallRuleType> AddRuleInSection(string SectionId, NSXTFirewallRuleType FirewallRule, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (FirewallRule == null) { throw new System.ArgumentNullException("FirewallRule cannot be null"); }
            StringBuilder AddRuleInSectionServiceURL = new StringBuilder("/firewall/sections/{section-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddRuleInSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FirewallRule);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = AddRuleInSectionServiceURL.ToString();
            RestResponse<NSXTFirewallRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddRuleInSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallRuleListResultType> GetRules(string SectionId, string? AppliedTos = null, string? ContextProfiles = null, string? Cursor = null, bool? DeepSearch = null, string? Destinations = null, string? ExtendedSources = null, string? FilterType = null, string? IncludedFields = null, long? PageSize = null, bool? SearchInvalidReferences = null, string? Services = null, bool? SortAscending = null, string? SortBy = null, string? Sources = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            StringBuilder GetRulesServiceURL = new StringBuilder("/firewall/sections/{section-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetRulesServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (AppliedTos != null) { request.AddQueryParameter("applied_tos", AppliedTos.ToString()); }
            if (ContextProfiles != null) { request.AddQueryParameter("context_profiles", ContextProfiles.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DeepSearch != null) { request.AddQueryParameter("deep_search", DeepSearch.ToString()); }
            if (Destinations != null) { request.AddQueryParameter("destinations", Destinations.ToString()); }
            if (ExtendedSources != null) { request.AddQueryParameter("extended_sources", ExtendedSources.ToString()); }
            if (FilterType != null) { request.AddQueryParameter("filter_type", FilterType.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SearchInvalidReferences != null) { request.AddQueryParameter("search_invalid_references", SearchInvalidReferences.ToString()); }
            if (Services != null) { request.AddQueryParameter("services", Services.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Sources != null) { request.AddQueryParameter("sources", Sources.ToString()); }
            request.Resource = GetRulesServiceURL.ToString();
            RestResponse<NSXTFirewallRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallSectionType> UnlockSection(string SectionId, NSXTFirewallSectionLockType FirewallSectionLock)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (FirewallSectionLock == null) { throw new System.ArgumentNullException("FirewallSectionLock cannot be null"); }
            StringBuilder UnlockSectionServiceURL = new StringBuilder("/firewall/sections/{section-id}?action=unlock");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UnlockSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FirewallSectionLock);
            request.Resource = UnlockSectionServiceURL.ToString();
            RestResponse<NSXTFirewallSectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallSectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UnlockSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallSectionRuleListType> AddSectionWithRules(NSXTFirewallSectionRuleListType FirewallSectionRuleList, string? Id = null, string? Operation = null)
        {
            if (FirewallSectionRuleList == null) { throw new System.ArgumentNullException("FirewallSectionRuleList cannot be null"); }
            StringBuilder AddSectionWithRulesServiceURL = new StringBuilder("/firewall/sections?action=create_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(FirewallSectionRuleList);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = AddSectionWithRulesServiceURL.ToString();
            RestResponse<NSXTFirewallSectionRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallSectionRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddSectionWithRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallSectionType> ReviseSection(string SectionId, NSXTFirewallSectionType FirewallSection, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (FirewallSection == null) { throw new System.ArgumentNullException("FirewallSection cannot be null"); }
            StringBuilder ReviseSectionServiceURL = new StringBuilder("/firewall/sections/{section-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FirewallSection);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseSectionServiceURL.ToString();
            RestResponse<NSXTFirewallSectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallSectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallRuleType> ReviseRule(string SectionId, string RuleId, NSXTFirewallRuleType FirewallRule, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (FirewallRule == null) { throw new System.ArgumentNullException("FirewallRule cannot be null"); }
            StringBuilder ReviseRuleServiceURL = new StringBuilder("/firewall/sections/{section-id}/rules/{rule-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseRuleServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FirewallRule);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseRuleServiceURL.ToString();
            RestResponse<NSXTFirewallRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallSectionType> LockSection(string SectionId, NSXTFirewallSectionLockType FirewallSectionLock)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (FirewallSectionLock == null) { throw new System.ArgumentNullException("FirewallSectionLock cannot be null"); }
            StringBuilder LockSectionServiceURL = new StringBuilder("/firewall/sections/{section-id}?action=lock");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            LockSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FirewallSectionLock);
            request.Resource = LockSectionServiceURL.ToString();
            RestResponse<NSXTFirewallSectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallSectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + LockSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallSectionType> AddSection(NSXTFirewallSectionType FirewallSection, string? Id = null, string? Operation = null)
        {
            if (FirewallSection == null) { throw new System.ArgumentNullException("FirewallSection cannot be null"); }
            StringBuilder AddSectionServiceURL = new StringBuilder("/firewall/sections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(FirewallSection);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = AddSectionServiceURL.ToString();
            RestResponse<NSXTFirewallSectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallSectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallSectionListResultType> ListSections(string? AppliedTos = null, string? ContextProfiles = null, string? Cursor = null, bool? DeepSearch = null, string? Destinations = null, string? EnforcedOn = null, string? ExcludeAppliedToType = null, string? ExtendedSources = null, string? FilterType = null, string? IncludeAppliedToType = null, string? IncludedFields = null, bool? Locked = null, long? PageSize = null, bool? SearchInvalidReferences = null, string? SearchScope = null, string? Services = null, bool? SortAscending = null, string? SortBy = null, string? Sources = null, string? Type = null)
        {
            StringBuilder ListSectionsServiceURL = new StringBuilder("/firewall/sections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AppliedTos != null) { request.AddQueryParameter("applied_tos", AppliedTos.ToString()); }
            if (ContextProfiles != null) { request.AddQueryParameter("context_profiles", ContextProfiles.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (DeepSearch != null) { request.AddQueryParameter("deep_search", DeepSearch.ToString()); }
            if (Destinations != null) { request.AddQueryParameter("destinations", Destinations.ToString()); }
            if (EnforcedOn != null) { request.AddQueryParameter("enforced_on", EnforcedOn.ToString()); }
            if (ExcludeAppliedToType != null) { request.AddQueryParameter("exclude_applied_to_type", ExcludeAppliedToType.ToString()); }
            if (ExtendedSources != null) { request.AddQueryParameter("extended_sources", ExtendedSources.ToString()); }
            if (FilterType != null) { request.AddQueryParameter("filter_type", FilterType.ToString()); }
            if (IncludeAppliedToType != null) { request.AddQueryParameter("include_applied_to_type", IncludeAppliedToType.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (Locked != null) { request.AddQueryParameter("locked", Locked.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (SearchInvalidReferences != null) { request.AddQueryParameter("search_invalid_references", SearchInvalidReferences.ToString()); }
            if (SearchScope != null) { request.AddQueryParameter("search_scope", SearchScope.ToString()); }
            if (Services != null) { request.AddQueryParameter("services", Services.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Sources != null) { request.AddQueryParameter("sources", Sources.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = ListSectionsServiceURL.ToString();
            RestResponse<NSXTFirewallSectionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallSectionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListSectionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallSectionType> UpdateSection(string SectionId, NSXTFirewallSectionType FirewallSection)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (FirewallSection == null) { throw new System.ArgumentNullException("FirewallSection cannot be null"); }
            StringBuilder UpdateSectionServiceURL = new StringBuilder("/firewall/sections/{section-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FirewallSection);
            request.Resource = UpdateSectionServiceURL.ToString();
            RestResponse<NSXTFirewallSectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallSectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallSectionType> GetSection(string SectionId)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            StringBuilder GetSectionServiceURL = new StringBuilder("/firewall/sections/{section-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetSectionServiceURL.ToString();
            RestResponse<NSXTFirewallSectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallSectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSection(string SectionId, bool? Cascade = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            StringBuilder DeleteSectionServiceURL = new StringBuilder("/firewall/sections/{section-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cascade != null) { request.AddQueryParameter("cascade", Cascade.ToString()); }
            request.Resource = DeleteSectionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallRuleType> UpdateRule(string SectionId, string RuleId, NSXTFirewallRuleType FirewallRule)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (FirewallRule == null) { throw new System.ArgumentNullException("FirewallRule cannot be null"); }
            StringBuilder UpdateRuleServiceURL = new StringBuilder("/firewall/sections/{section-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateRuleServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(FirewallRule);
            request.Resource = UpdateRuleServiceURL.ToString();
            RestResponse<NSXTFirewallRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallRuleType> GetRule(string SectionId, string RuleId)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GetRuleServiceURL = new StringBuilder("/firewall/sections/{section-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetRuleServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            GetRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetRuleServiceURL.ToString();
            RestResponse<NSXTFirewallRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteRule(string SectionId, string RuleId)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder DeleteRuleServiceURL = new StringBuilder("/firewall/sections/{section-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteRuleServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallSectionStateType> GetSectionState(string SectionId, long? BarrierId = null, string? RequestId = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            StringBuilder GetSectionStateServiceURL = new StringBuilder("/firewall/sections/{section-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetSectionStateServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BarrierId != null) { request.AddQueryParameter("barrier_id", BarrierId.ToString()); }
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            request.Resource = GetSectionStateServiceURL.ToString();
            RestResponse<NSXTFirewallSectionStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallSectionStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSectionStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRuleStateType> GetRuleState(string RuleId, long? BarrierId = null, string? RequestId = null)
        {
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GetRuleStateServiceURL = new StringBuilder("/firewall/rules/{rule-id}/state");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetRuleStateServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (BarrierId != null) { request.AddQueryParameter("barrier_id", BarrierId.ToString()); }
            if (RequestId != null) { request.AddQueryParameter("request_id", RequestId.ToString()); }
            request.Resource = GetRuleStateServiceURL.ToString();
            RestResponse<NSXTRuleStateType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRuleStateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRuleStateServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallSectionRuleListType> GetSectionWithRules(string SectionId)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            StringBuilder GetSectionWithRulesServiceURL = new StringBuilder("/firewall/sections/{section-id}?action=list_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            GetSectionWithRulesServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetSectionWithRulesServiceURL.ToString();
            RestResponse<NSXTFirewallSectionRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallSectionRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetSectionWithRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
