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
    public class PolicyVPNStatistics
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyVPNStatistics(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTAggregateIPSecVpnSessionStatusType> GetTier0VpnIpsecVpnSessionStatus(string Tier0Id, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0VpnIpsecVpnSessionStatusServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/detailed-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnIpsecVpnSessionStatusServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnSessionStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnSessionStatusServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier0VpnIpsecVpnSessionStatusServiceURL.ToString();
            RestResponse<NSXTAggregateIPSecVpnSessionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateIPSecVpnSessionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnIpsecVpnSessionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VPNSessionStatusType> GetL2VpnSessionStatus(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetL2VpnSessionStatusServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}/detailed-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2VpnSessionStatusServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnSessionStatusServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnSessionStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnSessionStatusServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetL2VpnSessionStatusServiceURL.ToString();
            RestResponse<NSXTAggregateL2VPNSessionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VPNSessionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnSessionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VPNSessionStatusType> GetTier1VpnL2VpnSessionStatus(string Tier1Id, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1VpnL2VpnSessionStatusServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}/sessions/{session-id}/detailed-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnL2VpnSessionStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnL2VpnSessionStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnL2VpnSessionStatusServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier1VpnL2VpnSessionStatusServiceURL.ToString();
            RestResponse<NSXTAggregateL2VPNSessionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VPNSessionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnL2VpnSessionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VPNSessionStatisticsType> GetTier1VpnL2VpnSessionStatistics(string Tier1Id, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1VpnL2VpnSessionStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnL2VpnSessionStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnL2VpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnL2VpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier1VpnL2VpnSessionStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateL2VPNSessionStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VPNSessionStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnL2VpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VpnSessionRemoteMacType> GetTier0L2VpnSessionRemoteMacsForLS(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? SegmentPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0L2VpnSessionRemoteMacsForLSServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}/remote-mac");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0L2VpnSessionRemoteMacsForLSServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0L2VpnSessionRemoteMacsForLSServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0L2VpnSessionRemoteMacsForLSServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0L2VpnSessionRemoteMacsForLSServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (SegmentPath != null) { request.AddQueryParameter("segment_path", SegmentPath.ToString()); }
            request.Resource = GetTier0L2VpnSessionRemoteMacsForLSServiceURL.ToString();
            RestResponse<NSXTAggregateL2VpnSessionRemoteMacType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VpnSessionRemoteMacType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0L2VpnSessionRemoteMacsForLSServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VPNSessionStatusType> GetTier0VpnL2VpnSessionStatus(string Tier0Id, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0VpnL2VpnSessionStatusServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}/sessions/{session-id}/detailed-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnL2VpnSessionStatusServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnL2VpnSessionStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnL2VpnSessionStatusServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier0VpnL2VpnSessionStatusServiceURL.ToString();
            RestResponse<NSXTAggregateL2VPNSessionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VPNSessionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnL2VpnSessionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VPNSessionStatisticsType> GetTier0VpnL2VpnSessionStatistics(string Tier0Id, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0VpnL2VpnSessionStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnL2VpnSessionStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnL2VpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnL2VpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier0VpnL2VpnSessionStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateL2VPNSessionStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VPNSessionStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnL2VpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyIpsecVpnIkeServiceSummaryType> GetTier1VpnIpsecVpnSessionSummary(string Tier1Id, string ServiceId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetTier1VpnIpsecVpnSessionSummaryServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnIpsecVpnSessionSummaryServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnSessionSummaryServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier1VpnIpsecVpnSessionSummaryServiceURL.ToString();
            RestResponse<NSXTPolicyIpsecVpnIkeServiceSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIpsecVpnIkeServiceSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnIpsecVpnSessionSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyIpsecVpnIkeServiceSummaryType> GetTier1IpsecVpnSessionSummary(string Tier1Id, string LocaleServiceId, string ServiceId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetTier1IpsecVpnSessionSummaryServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1IpsecVpnSessionSummaryServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionSummaryServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionSummaryServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier1IpsecVpnSessionSummaryServiceURL.ToString();
            RestResponse<NSXTPolicyIpsecVpnIkeServiceSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIpsecVpnIkeServiceSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1IpsecVpnSessionSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyIpsecVpnIkeServiceSummaryType> GetTier0VpnIpsecVpnSessionSummary(string Tier0Id, string ServiceId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetTier0VpnIpsecVpnSessionSummaryServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnIpsecVpnSessionSummaryServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnSessionSummaryServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier0VpnIpsecVpnSessionSummaryServiceURL.ToString();
            RestResponse<NSXTPolicyIpsecVpnIkeServiceSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIpsecVpnIkeServiceSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnIpsecVpnSessionSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VpnSessionRemoteMacType> GetTier0VpnL2VpnSessionRemoteMacsForLS(string Tier0Id, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? SegmentPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0VpnL2VpnSessionRemoteMacsForLSServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/l2vpn-services/{service-id}/sessions/{session-id}/remote-mac");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnL2VpnSessionRemoteMacsForLSServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnL2VpnSessionRemoteMacsForLSServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnL2VpnSessionRemoteMacsForLSServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (SegmentPath != null) { request.AddQueryParameter("segment_path", SegmentPath.ToString()); }
            request.Resource = GetTier0VpnL2VpnSessionRemoteMacsForLSServiceURL.ToString();
            RestResponse<NSXTAggregateL2VpnSessionRemoteMacType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VpnSessionRemoteMacType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnL2VpnSessionRemoteMacsForLSServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VpnSessionRemoteMacType> GetTier1L2VpnSessionRemoteMacsForLS(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? SegmentPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1L2VpnSessionRemoteMacsForLSServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}/remote-mac");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1L2VpnSessionRemoteMacsForLSServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnSessionRemoteMacsForLSServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnSessionRemoteMacsForLSServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnSessionRemoteMacsForLSServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (SegmentPath != null) { request.AddQueryParameter("segment_path", SegmentPath.ToString()); }
            request.Resource = GetTier1L2VpnSessionRemoteMacsForLSServiceURL.ToString();
            RestResponse<NSXTAggregateL2VpnSessionRemoteMacType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VpnSessionRemoteMacType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1L2VpnSessionRemoteMacsForLSServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL3VpnStatisticsType> GetL3VpnStatistics(string Tier0Id, string LocaleServiceId, string L3vpnId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L3vpnId == null) { throw new System.ArgumentNullException("L3vpnId cannot be null"); }
            StringBuilder GetL3VpnStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l3vpns/{l3vpn-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL3VpnStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetL3VpnStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetL3VpnStatisticsServiceURL.Replace("{l3vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L3vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetL3VpnStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateL3VpnStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL3VpnStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL3VpnStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraResetTier1VpnIpsecVpnSessionStatistics(string Tier1Id, string ServiceId, string SessionId, string Action, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder GlobalInfraResetTier1VpnIpsecVpnSessionStatisticsServiceURL = new StringBuilder("/global-infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            GlobalInfraResetTier1VpnIpsecVpnSessionStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraResetTier1VpnIpsecVpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraResetTier1VpnIpsecVpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraResetTier1VpnIpsecVpnSessionStatisticsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GlobalInfraResetTier1VpnIpsecVpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateIPSecVpnSessionStatusType> GetTier1IpsecVpnSessionStatus(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1IpsecVpnSessionStatusServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/detailed-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1IpsecVpnSessionStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionStatusServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionStatusServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier1IpsecVpnSessionStatusServiceURL.ToString();
            RestResponse<NSXTAggregateIPSecVpnSessionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateIPSecVpnSessionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1IpsecVpnSessionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResetTier0IpsecVpnSessionStatistics(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, string Action, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder ResetTier0IpsecVpnSessionStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ResetTier0IpsecVpnSessionStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ResetTier0IpsecVpnSessionStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ResetTier0IpsecVpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ResetTier0IpsecVpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ResetTier0IpsecVpnSessionStatisticsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetTier0IpsecVpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateIPSecVpnSessionStatisticsType> GetTier0IpsecVpnSessionStatistics(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0IpsecVpnSessionStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0IpsecVpnSessionStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier0IpsecVpnSessionStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateIPSecVpnSessionStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateIPSecVpnSessionStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0IpsecVpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTPolicyIpsecVpnIkeServiceSummaryType> GetTier0IpsecVpnSessionSummary(string Tier0Id, string LocaleServiceId, string ServiceId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetTier0IpsecVpnSessionSummaryServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0IpsecVpnSessionSummaryServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionSummaryServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionSummaryServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier0IpsecVpnSessionSummaryServiceURL.ToString();
            RestResponse<NSXTPolicyIpsecVpnIkeServiceSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPolicyIpsecVpnIkeServiceSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0IpsecVpnSessionSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VPNSessionStatisticsType> GetL2VpnSessionStatistics(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetL2VpnSessionStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2VpnSessionStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnSessionStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetL2VpnSessionStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateL2VPNSessionStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VPNSessionStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResetTier1VpnIpsecVpnSessionStatistics(string Tier1Id, string ServiceId, string SessionId, string Action, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder ResetTier1VpnIpsecVpnSessionStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ResetTier1VpnIpsecVpnSessionStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ResetTier1VpnIpsecVpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ResetTier1VpnIpsecVpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ResetTier1VpnIpsecVpnSessionStatisticsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetTier1VpnIpsecVpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateIPSecVpnSessionStatisticsType> GetTier1VpnIpsecVpnSessionStatistics(string Tier1Id, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1VpnIpsecVpnSessionStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnIpsecVpnSessionStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier1VpnIpsecVpnSessionStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateIPSecVpnSessionStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateIPSecVpnSessionStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnIpsecVpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VPNSessionStatisticsType> GetTier1L2VpnSessionStatistics(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1L2VpnSessionStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1L2VpnSessionStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnSessionStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier1L2VpnSessionStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateL2VPNSessionStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VPNSessionStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1L2VpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VPNSessionStatusType> GetTier1L2VpnSessionStatus(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1L2VpnSessionStatusServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/l2vpn-services/{service-id}/sessions/{session-id}/detailed-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1L2VpnSessionStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnSessionStatusServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnSessionStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1L2VpnSessionStatusServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier1L2VpnSessionStatusServiceURL.ToString();
            RestResponse<NSXTAggregateL2VPNSessionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VPNSessionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1L2VpnSessionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VpnSessionRemoteMacType> GetTier1VpnL2VpnSessionRemoteMacsForLS(string Tier1Id, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? SegmentPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1VpnL2VpnSessionRemoteMacsForLSServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/l2vpn-services/{service-id}/sessions/{session-id}/remote-mac");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnL2VpnSessionRemoteMacsForLSServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnL2VpnSessionRemoteMacsForLSServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnL2VpnSessionRemoteMacsForLSServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (SegmentPath != null) { request.AddQueryParameter("segment_path", SegmentPath.ToString()); }
            request.Resource = GetTier1VpnL2VpnSessionRemoteMacsForLSServiceURL.ToString();
            RestResponse<NSXTAggregateL2VpnSessionRemoteMacType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VpnSessionRemoteMacType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnL2VpnSessionRemoteMacsForLSServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateIPSecVpnSessionStatusType> GetTier1VpnIpsecVpnSessionStatus(string Tier1Id, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1VpnIpsecVpnSessionStatusServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/detailed-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1VpnIpsecVpnSessionStatusServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnSessionStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1VpnIpsecVpnSessionStatusServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier1VpnIpsecVpnSessionStatusServiceURL.ToString();
            RestResponse<NSXTAggregateIPSecVpnSessionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateIPSecVpnSessionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1VpnIpsecVpnSessionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task GlobalGlobalInfraResetTier0VpnIpsecVpnSessionStatistics(string Tier0Id, string ServiceId, string SessionId, string Action, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder GlobalInfraResetTier0VpnIpsecVpnSessionStatisticsServiceURL = new StringBuilder("/global-infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            GlobalInfraResetTier0VpnIpsecVpnSessionStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraResetTier0VpnIpsecVpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GlobalInfraResetTier0VpnIpsecVpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GlobalInfraResetTier0VpnIpsecVpnSessionStatisticsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + GlobalInfraResetTier0VpnIpsecVpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateIPSecVpnSessionStatusType> GetTier0IpsecVpnSessionStatus(string Tier0Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0IpsecVpnSessionStatusServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/detailed-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0IpsecVpnSessionStatusServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionStatusServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionStatusServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0IpsecVpnSessionStatusServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier0IpsecVpnSessionStatusServiceURL.ToString();
            RestResponse<NSXTAggregateIPSecVpnSessionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateIPSecVpnSessionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0IpsecVpnSessionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateL2VpnStatisticsType> GetL2VpnStatistics(string Tier0Id, string LocaleServiceId, string L2vpnId, string? ContainerClusterPath = null, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (L2vpnId == null) { throw new System.ArgumentNullException("L2vpnId cannot be null"); }
            StringBuilder GetL2VpnStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/locale-services/{locale-service-id}/l2vpn-context/l2vpns/{l2vpn-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2VpnStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetL2VpnStatisticsServiceURL.Replace("{l2vpn-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(L2vpnId, System.Globalization.CultureInfo.InvariantCulture)));
            if (ContainerClusterPath != null) { request.AddQueryParameter("container_cluster_path", ContainerClusterPath.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = GetL2VpnStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateL2VpnStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateL2VpnStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResetTier1IpsecVpnSessionStatistics(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, string Action, string? EnforcementPointPath = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder ResetTier1IpsecVpnSessionStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ResetTier1IpsecVpnSessionStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            ResetTier1IpsecVpnSessionStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ResetTier1IpsecVpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ResetTier1IpsecVpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ResetTier1IpsecVpnSessionStatisticsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetTier1IpsecVpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateIPSecVpnSessionStatisticsType> GetTier1IpsecVpnSessionStatistics(string Tier1Id, string LocaleServiceId, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier1Id == null) { throw new System.ArgumentNullException("Tier1Id cannot be null"); }
            if (LocaleServiceId == null) { throw new System.ArgumentNullException("LocaleServiceId cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier1IpsecVpnSessionStatisticsServiceURL = new StringBuilder("/infra/tier-1s/{tier-1-id}/locale-services/{locale-service-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier1IpsecVpnSessionStatisticsServiceURL.Replace("{tier-1-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier1Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionStatisticsServiceURL.Replace("{locale-service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LocaleServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier1IpsecVpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier1IpsecVpnSessionStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateIPSecVpnSessionStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateIPSecVpnSessionStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier1IpsecVpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResetTier0VpnIpsecVpnSessionStatistics(string Tier0Id, string ServiceId, string SessionId, string Action, string? EnforcementPointPath = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            if (Action == null) { throw new System.ArgumentNullException("Action cannot be null"); }
            StringBuilder ResetTier0VpnIpsecVpnSessionStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ResetTier0VpnIpsecVpnSessionStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            ResetTier0VpnIpsecVpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            ResetTier0VpnIpsecVpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            request.Resource = ResetTier0VpnIpsecVpnSessionStatisticsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetTier0VpnIpsecVpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTAggregateIPSecVpnSessionStatisticsType> GetTier0VpnIpsecVpnSessionStatistics(string Tier0Id, string ServiceId, string SessionId, string? EnforcementPointPath = null, string? Source = null)
        {
            if (Tier0Id == null) { throw new System.ArgumentNullException("Tier0Id cannot be null"); }
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetTier0VpnIpsecVpnSessionStatisticsServiceURL = new StringBuilder("/infra/tier-0s/{tier-0-id}/ipsec-vpn-services/{service-id}/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetTier0VpnIpsecVpnSessionStatisticsServiceURL.Replace("{tier-0-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Tier0Id, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnSessionStatisticsServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            GetTier0VpnIpsecVpnSessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (EnforcementPointPath != null) { request.AddQueryParameter("enforcement_point_path", EnforcementPointPath.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetTier0VpnIpsecVpnSessionStatisticsServiceURL.ToString();
            RestResponse<NSXTAggregateIPSecVpnSessionStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTAggregateIPSecVpnSessionStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetTier0VpnIpsecVpnSessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
