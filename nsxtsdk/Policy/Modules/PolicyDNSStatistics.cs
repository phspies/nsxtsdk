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
    public class PolicyDNSStatistics
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyDNSStatistics(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTAggregateDNSForwarderStatusType> GlobalGlobalInfraGetTier1DnsforwarderStatus(string Tier1Id, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraGetTier1DnsforwarderStatusServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/dns-forwarder/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1DnsforwarderStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraGetTier1DnsforwarderStatusServiceURL.ToString();
            RestResponse<NSXTAggregateDNSForwarderStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateDNSForwarderStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1DnsforwarderStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateDNSForwarderStatusType> GlobalGlobalInfraGetTier0DnsforwarderStatus(string Tier0Id, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraGetTier0DnsforwarderStatusServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/dns-forwarder/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0DnsforwarderStatusServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraGetTier0DnsforwarderStatusServiceURL.ToString();
            RestResponse<NSXTAggregateDNSForwarderStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateDNSForwarderStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0DnsforwarderStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateDNSForwarderStatusType> GetTier0DnsforwarderStatus(string Tier0Id, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GetTier0DnsforwarderStatusServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/dns-forwarder/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0DnsforwarderStatusServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier0DnsforwarderStatusServiceURL.ToString();
            RestResponse<NSXTAggregateDNSForwarderStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateDNSForwarderStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0DnsforwarderStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateDNSForwarderStatisticsType> GlobalGlobalInfraGetTier1DnsforwarderStatistics(string Tier1Id, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GlobalInfraGetTier1DnsforwarderStatisticsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/dns-forwarder/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier1DnsforwarderStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraGetTier1DnsforwarderStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateDNSForwarderStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateDNSForwarderStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier1DnsforwarderStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateDNSForwarderStatusType> GetTier1DnsforwarderStatus(string Tier1Id, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GetTier1DnsforwarderStatusServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/dns-forwarder/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1DnsforwarderStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier1DnsforwarderStatusServiceURL.ToString();
            RestResponse<NSXTAggregateDNSForwarderStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateDNSForwarderStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1DnsforwarderStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateDNSForwarderStatisticsType> GlobalGlobalInfraGetTier0DnsforwarderStatistics(string Tier0Id, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GlobalInfraGetTier0DnsforwarderStatisticsServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/dns-forwarder/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GlobalInfraGetTier0DnsforwarderStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraGetTier0DnsforwarderStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateDNSForwarderStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateDNSForwarderStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetTier0DnsforwarderStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateDNSForwarderStatisticsType> GetTier0DnsforwarderStatistics(string Tier0Id, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            StringBuilder GetTier0DnsforwarderStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/dns-forwarder/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0DnsforwarderStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier0DnsforwarderStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateDNSForwarderStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateDNSForwarderStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0DnsforwarderStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateDNSForwarderStatisticsType> GetTier1DnsforwarderStatistics(string Tier1Id, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            StringBuilder GetTier1DnsforwarderStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/dns-forwarder/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1DnsforwarderStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetTier1DnsforwarderStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateDNSForwarderStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateDNSForwarderStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1DnsforwarderStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
