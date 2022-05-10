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
    public class Nat
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Nat(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNatRuleListType> AddNatRules(string LogicalRouterId, NSXTNatRuleListType NatRuleList)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (NatRuleList == null) { throw new System.ArgumentNullException("NatRuleList cannot be null"); }
            StringBuilder AddNatRulesServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/nat/rules?action=create_multiple");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddNatRulesServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(NatRuleList);
            request.Resource = AddNatRulesServiceURL.ToString();
            RestResponse<NSXTNatRuleListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNatRuleListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddNatRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNatRuleType> UpdateNatRule(string LogicalRouterId, string RuleId, NSXTNatRuleType NatRule)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            if (NatRule == null) { throw new System.ArgumentNullException("NatRule cannot be null"); }
            StringBuilder UpdateNatRuleServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/nat/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateNatRuleServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateNatRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(NatRule);
            request.Resource = UpdateNatRuleServiceURL.ToString();
            RestResponse<NSXTNatRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNatRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNatRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNatRuleType> GetNatRule(string LogicalRouterId, string RuleId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GetNatRuleServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/nat/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetNatRuleServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            GetNatRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetNatRuleServiceURL.ToString();
            RestResponse<NSXTNatRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNatRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetNatRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteNatRule(string LogicalRouterId, string RuleId)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder DeleteNatRuleServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/nat/rules/{rule-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteNatRuleServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteNatRuleServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteNatRuleServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteNatRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNatRuleType> AddNatRule(string LogicalRouterId, NSXTNatRuleType NatRule)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            if (NatRule == null) { throw new System.ArgumentNullException("NatRule cannot be null"); }
            StringBuilder AddNatRuleServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/nat/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddNatRuleServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(NatRule);
            request.Resource = AddNatRuleServiceURL.ToString();
            RestResponse<NSXTNatRuleType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNatRuleType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddNatRuleServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNatRuleListResultType> ListNatRules(string LogicalRouterId, string? Cursor = null, string? IncludedFields = null, long? PageSize = null, string? RuleType = null, bool? SortAscending = null, string? SortBy = null)
        {
            if (LogicalRouterId == null) { throw new System.ArgumentNullException("LogicalRouterId cannot be null"); }
            StringBuilder ListNatRulesServiceURL = new StringBuilder("/logical-routers/{logical-router-id}/nat/rules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListNatRulesServiceURL.Replace("{logical-router-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalRouterId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Cursor != null) { request.AddQueryParameter("cursor", Cursor.ToString()); }
            if (IncludedFields != null) { request.AddQueryParameter("included_fields", IncludedFields.ToString()); }
            if (PageSize != null) { request.AddQueryParameter("page_size", PageSize.ToString()); }
            if (RuleType != null) { request.AddQueryParameter("rule_type", RuleType.ToString()); }
            if (SortAscending != null) { request.AddQueryParameter("sort_ascending", SortAscending.ToString()); }
            if (SortBy != null) { request.AddQueryParameter("sort_by", SortBy.ToString()); }
            request.Resource = ListNatRulesServiceURL.ToString();
            RestResponse<NSXTNatRuleListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNatRuleListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNatRulesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
