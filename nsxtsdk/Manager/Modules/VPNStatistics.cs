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
    public class VPNStatistics
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public VPNStatistics(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTIPSecVPNIKEServiceSummaryType> GetIpsecVpnikeservice(string ServiceId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            StringBuilder GetIpsecVpnikeserviceServiceURL = new StringBuilder("/vpn/services/{service-id}/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnikeserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetIpsecVpnikeserviceServiceURL.ToString();
            RestResponse<NSXTIPSecVPNIKEServiceSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNIKEServiceSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnikeserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNSessionStatisticsType> GetIpsecVpnsessionStatistics(string SessionId, string? Source = null)
        {
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetIpsecVpnsessionStatisticsServiceURL = new StringBuilder("/vpn/ipsec/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnsessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetIpsecVpnsessionStatisticsServiceURL.ToString();
            RestResponse<NSXTIPSecVPNSessionStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNSessionStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnsessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResetIpsecVpnsessionStatistics(string SessionId)
        {
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder ResetIpsecVpnsessionStatisticsServiceURL = new StringBuilder("/vpn/ipsec/sessions/{session-id}/statistics?action=reset");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ResetIpsecVpnsessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ResetIpsecVpnsessionStatisticsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetIpsecVpnsessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNSessionSummaryType> GetIpsecVpnsessionSummary(string? SiteId = null, string? Source = null)
        {
            StringBuilder GetIpsecVpnsessionSummaryServiceURL = new StringBuilder("/vpn/ipsec/sessions/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (SiteId != null) { request.AddQueryParameter("site_id", SiteId.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetIpsecVpnsessionSummaryServiceURL.ToString();
            RestResponse<NSXTIPSecVPNSessionSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNSessionSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnsessionSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNSessionStatusType> GetIpsecVpnikesessionStatus(string SessionId, string? Source = null)
        {
            if (SessionId == null) { throw new System.ArgumentNullException("SessionId cannot be null"); }
            StringBuilder GetIpsecVpnikesessionStatusServiceURL = new StringBuilder("/vpn/ipsec/sessions/{session-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetIpsecVpnikesessionStatusServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetIpsecVpnikesessionStatusServiceURL.ToString();
            RestResponse<NSXTIPSecVPNSessionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNSessionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetIpsecVpnikesessionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
