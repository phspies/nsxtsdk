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
    public class FirewallStatsRule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public FirewallStatsRule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTFirewallStatsListType> GetFirewallSectionStats(string SectionId, string? Source = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            StringBuilder GetFirewallSectionStatsServiceURL = new StringBuilder("/firewall/sections/{section-id}/rules/stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFirewallSectionStatsServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetFirewallSectionStatsServiceURL.ToString();
            RestResponse<NSXTFirewallStatsListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallStatsListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFirewallSectionStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTFirewallStatsType> GetFirewallStats(string SectionId, string RuleId, string? Source = null)
        {
            if (SectionId == null) { throw new System.ArgumentNullException("SectionId cannot be null"); }
            if (RuleId == null) { throw new System.ArgumentNullException("RuleId cannot be null"); }
            StringBuilder GetFirewallStatsServiceURL = new StringBuilder("/firewall/sections/{section-id}/rules/{rule-id}/stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetFirewallStatsServiceURL.Replace("{section-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SectionId, System.Globalization.CultureInfo.InvariantCulture)));
            GetFirewallStatsServiceURL.Replace("{rule-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RuleId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetFirewallStatsServiceURL.ToString();
            RestResponse<NSXTFirewallStatsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTFirewallStatsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetFirewallStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResetFirewallRuleStats(string Category)
        {
            if (Category == null) { throw new System.ArgumentNullException("Category cannot be null"); }
            StringBuilder ResetFirewallRuleStatsServiceURL = new StringBuilder("/firewall/stats?action=reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            if (Category != null) { request.AddQueryParameter("category", Category.ToString()); }
            request.Resource = ResetFirewallRuleStatsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetFirewallRuleStatsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
