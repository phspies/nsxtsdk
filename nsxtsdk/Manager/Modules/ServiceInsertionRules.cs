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
    public class ServiceInsertionRules
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ServiceInsertionRules(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTServiceInsertionRuleType> AddServiceInsertionRuleInSection(string SectionId, NSXTServiceInsertionRuleType ServiceInsertionRule, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (ServiceInsertionRule == null) { throw new System.ArgumentNullException("ServiceInsertionRule cannot be null"); }
            StringBuilder AddServiceInsertionRuleInSectionServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddServiceInsertionRuleInSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInsertionRule);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = AddServiceInsertionRuleInSectionServiceURL.ToString();
            RestResponse<NSXTServiceInsertionRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddServiceInsertionRuleInSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionRuleListResultType> GetServiceInsertionRules(string SectionId, string? AppliedTos = null, string? Cursor = null, string? Destinations = null, string? FilterType = null, string? IncludedFields = null, long? PageSize = null, string? Services = null, bool? SortAscending = null, string? SortBy = null, string? Sources = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            StringBuilder GetServiceInsertionRulesServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceInsertionRulesServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (AppliedTos != null) { request.AddQueryParameter("applied_tos", AppliedTos.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Destinations != null) { request.AddQueryParameter("destinations", Destinations.ToString()); }
            if (FilterType != null) { request.AddQueryParameter("filter_type", FilterType.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Services != null) { request.AddQueryParameter("services", Services.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Sources != null) { request.AddQueryParameter("sources", Sources.ToString()); }
            request.Resource = GetServiceInsertionRulesServiceURL.ToString();
            RestResponse<NSXTServiceInsertionRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceInsertionRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionSectionRuleListType> GetServiceInsertionSectionWithRules(string SectionId)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            StringBuilder GetServiceInsertionSectionWithRulesServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}?action=list_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            GetServiceInsertionSectionWithRulesServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceInsertionSectionWithRulesServiceURL.ToString();
            RestResponse<NSXTServiceInsertionSectionRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionSectionRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GetServiceInsertionSectionWithRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionSectionRuleListType> ReviseServiceInsertionSectionWithRules(string SectionId, NSXTServiceInsertionSectionRuleListType ServiceInsertionSectionRuleList, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (ServiceInsertionSectionRuleList == null) { throw new System.ArgumentNullException("ServiceInsertionSectionRuleList cannot be null"); }
            StringBuilder ReviseServiceInsertionSectionWithRulesServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}?action=revise_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseServiceInsertionSectionWithRulesServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInsertionSectionRuleList);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseServiceInsertionSectionWithRulesServiceURL.ToString();
            RestResponse<NSXTServiceInsertionSectionRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionSectionRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseServiceInsertionSectionWithRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionSectionType> UpdateServiceInsertionSection(string SectionId, NSXTServiceInsertionSectionType ServiceInsertionSection)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (ServiceInsertionSection == null) { throw new System.ArgumentNullException("ServiceInsertionSection cannot be null"); }
            StringBuilder UpdateServiceInsertionSectionServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateServiceInsertionSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInsertionSection);
            request.Resource = UpdateServiceInsertionSectionServiceURL.ToString();
            RestResponse<NSXTServiceInsertionSectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionSectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateServiceInsertionSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceInsertionSection(string SectionId, bool? Cascade = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            StringBuilder DeleteServiceInsertionSectionServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceInsertionSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cascade != null) { request.AddQueryParameter("cascade", Cascade.ToString()); }
            request.Resource = DeleteServiceInsertionSectionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceInsertionSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionSectionType> GetServiceInsertionSection(string SectionId)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            StringBuilder GetServiceInsertionSectionServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceInsertionSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceInsertionSectionServiceURL.ToString();
            RestResponse<NSXTServiceInsertionSectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionSectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceInsertionSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionSectionRuleListType> AddServiceInsertionSectionWithRules(NSXTServiceInsertionSectionRuleListType ServiceInsertionSectionRuleList, string? Id = null, string? Operation = null)
        {
            if (ServiceInsertionSectionRuleList == null) { throw new System.ArgumentNullException("ServiceInsertionSectionRuleList cannot be null"); }
            StringBuilder AddServiceInsertionSectionWithRulesServiceURL = new StringBuilder("/serviceinsertion/sections?action=create_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ServiceInsertionSectionRuleList);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = AddServiceInsertionSectionWithRulesServiceURL.ToString();
            RestResponse<NSXTServiceInsertionSectionRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionSectionRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddServiceInsertionSectionWithRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionRuleType> ReviseServiceInsertionRule(string SectionId, string RuleId, NSXTServiceInsertionRuleType ServiceInsertionRule, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (ServiceInsertionRule == null) { throw new System.ArgumentNullException("ServiceInsertionRule cannot be null"); }
            StringBuilder ReviseServiceInsertionRuleServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules/{rule-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseServiceInsertionRuleServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            ReviseServiceInsertionRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInsertionRule);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseServiceInsertionRuleServiceURL.ToString();
            RestResponse<NSXTServiceInsertionRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseServiceInsertionRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionRuleType> UpdateServiceInsertionRule(string SectionId, string RuleId, NSXTServiceInsertionRuleType ServiceInsertionRule)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (ServiceInsertionRule == null) { throw new System.ArgumentNullException("ServiceInsertionRule cannot be null"); }
            StringBuilder UpdateServiceInsertionRuleServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateServiceInsertionRuleServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateServiceInsertionRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInsertionRule);
            request.Resource = UpdateServiceInsertionRuleServiceURL.ToString();
            RestResponse<NSXTServiceInsertionRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateServiceInsertionRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteServiceInsertionRule(string SectionId, string RuleId)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder DeleteServiceInsertionRuleServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceInsertionRuleServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceInsertionRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceInsertionRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceInsertionRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionRuleType> GetServiceInsertionRule(string SectionId, string RuleId)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GetServiceInsertionRuleServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceInsertionRuleServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceInsertionRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceInsertionRuleServiceURL.ToString();
            RestResponse<NSXTServiceInsertionRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceInsertionRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionSectionType> ReviseServiceInsertionSection(string SectionId, NSXTServiceInsertionSectionType ServiceInsertionSection, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (ServiceInsertionSection == null) { throw new System.ArgumentNullException("ServiceInsertionSection cannot be null"); }
            StringBuilder ReviseServiceInsertionSectionServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}?action=revise");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ReviseServiceInsertionSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInsertionSection);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = ReviseServiceInsertionSectionServiceURL.ToString();
            RestResponse<NSXTServiceInsertionSectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionSectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ReviseServiceInsertionSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionSectionRuleListType> UpdateServiceInsertionSectionWithRules(string SectionId, NSXTServiceInsertionSectionRuleListType ServiceInsertionSectionRuleList)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (ServiceInsertionSectionRuleList == null) { throw new System.ArgumentNullException("ServiceInsertionSectionRuleList cannot be null"); }
            StringBuilder UpdateServiceInsertionSectionWithRulesServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}?action=update_with_rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UpdateServiceInsertionSectionWithRulesServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInsertionSectionRuleList);
            request.Resource = UpdateServiceInsertionSectionWithRulesServiceURL.ToString();
            RestResponse<NSXTServiceInsertionSectionRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionSectionRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UpdateServiceInsertionSectionWithRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionSectionType> AddServiceInsertionSection(NSXTServiceInsertionSectionType ServiceInsertionSection, string? Id = null, string? Operation = null)
        {
            if (ServiceInsertionSection == null) { throw new System.ArgumentNullException("ServiceInsertionSection cannot be null"); }
            StringBuilder AddServiceInsertionSectionServiceURL = new StringBuilder("/serviceinsertion/sections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ServiceInsertionSection);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = AddServiceInsertionSectionServiceURL.ToString();
            RestResponse<NSXTServiceInsertionSectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionSectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddServiceInsertionSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionSectionListResultType> ListServiceInsertionSections(string? AppliedTos = null, string? Cursor = null, string? Destinations = null, string? ExcludeAppliedToType = null, string? FilterType = null, string? IncludeAppliedToType = null, string? IncludedFields = null, long? PageSize = null, string? Services = null, bool? SortAscending = null, string? SortBy = null, string? Sources = null, string? Type = null)
        {
            StringBuilder ListServiceInsertionSectionsServiceURL = new StringBuilder("/serviceinsertion/sections");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AppliedTos != null) { request.AddQueryParameter("applied_tos", AppliedTos.ToString()); }
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (Destinations != null) { request.AddQueryParameter("destinations", Destinations.ToString()); }
            if (ExcludeAppliedToType != null) { request.AddQueryParameter("exclude_applied_to_type", ExcludeAppliedToType.ToString()); }
            if (FilterType != null) { request.AddQueryParameter("filter_type", FilterType.ToString()); }
            if (IncludeAppliedToType != null) { request.AddQueryParameter("include_applied_to_type", IncludeAppliedToType.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (Services != null) { request.AddQueryParameter("services", Services.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            if (Sources != null) { request.AddQueryParameter("sources", Sources.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = ListServiceInsertionSectionsServiceURL.ToString();
            RestResponse<NSXTServiceInsertionSectionListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionSectionListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceInsertionSectionsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionRuleListType> AddServiceInsertionRulesInSection(string SectionId, NSXTServiceInsertionRuleListType ServiceInsertionRuleList, string? Id = null, string? Operation = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (ServiceInsertionRuleList == null) { throw new System.ArgumentNullException("ServiceInsertionRuleList cannot be null"); }
            StringBuilder AddServiceInsertionRulesInSectionServiceURL = new StringBuilder("/serviceinsertion/sections/{section-id}/rules?action=create_multiple");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddServiceInsertionRulesInSectionServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInsertionRuleList);
            if (Id != null) { request.AddQueryParameter("id", Id.ToString()); }
            if (Operation != null) { request.AddQueryParameter("operation", Operation.ToString()); }
            request.Resource = AddServiceInsertionRulesInSectionServiceURL.ToString();
            RestResponse<NSXTServiceInsertionRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddServiceInsertionRulesInSectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
