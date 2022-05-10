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
    public class L2VPNStatistics
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public L2VPNStatistics(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTL2VPNSessionSummaryType> GetL2VpnsessionSummary(string? Source = null)
        {
            StringBuilder GetL2VpnsessionSummaryServiceURL = new StringBuilder("/vpn/l2vpn/sessions/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetL2VpnsessionSummaryServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnsessionSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionStatusType> GetL2VpnsessionStatus(string SessionId, string? Source = null)
        {
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetL2VpnsessionStatusServiceURL = new StringBuilder("/vpn/l2vpn/sessions/{session-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2VpnsessionStatusServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetL2VpnsessionStatusServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnsessionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionRemoteMacsType> GetL2VpnsessionRemoteMacsForLS(string SessionId, string? LogicalSwitchId = null)
        {
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetL2VpnsessionRemoteMacsForLSServiceURL = new StringBuilder("/vpn/l2vpn/sessions/{session-id}/remote-mac");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2VpnsessionRemoteMacsForLSServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (LogicalSwitchId != null) { request.AddQueryParameter("logical_switch_id", LogicalSwitchId.ToString()); }
            request.Resource = GetL2VpnsessionRemoteMacsForLSServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionRemoteMacsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionRemoteMacsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnsessionRemoteMacsForLSServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2VPNSessionStatisticsType> GetL2VpnsessionStatistics(string SessionId, string? Source = null)
        {
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetL2VpnsessionStatisticsServiceURL = new StringBuilder("/vpn/l2vpn/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2VpnsessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetL2VpnsessionStatisticsServiceURL.ToString();
            RestResponse<NSXTL2VPNSessionStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2VPNSessionStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2VpnsessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
