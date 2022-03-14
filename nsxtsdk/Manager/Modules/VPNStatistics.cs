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
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class VPNStatistics
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public VPNStatistics(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

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
        public async Task<NSXTIPSecVPNIKEServiceSummaryType> GetIpsecVpnikeservice(string ServiceId, string? Source = null)
        {
            if (ServiceId == null) { throw new System.ArgumentNullException("ServiceId cannot be null"); }
            NSXTIPSecVPNIKEServiceSummaryType returnValue = default(NSXTIPSecVPNIKEServiceSummaryType);
            StringBuilder GetIpsecVpnikeserviceServiceURL = new StringBuilder("/vpn/services/{service-id}/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetIpsecVpnikeserviceServiceURL.Replace("{service-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServiceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetIpsecVpnikeserviceServiceURL.ToString();
            IRestResponse<NSXTIPSecVPNIKEServiceSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNIKEServiceSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetIpsecVpnikeserviceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
            NSXTIPSecVPNSessionStatisticsType returnValue = default(NSXTIPSecVPNSessionStatisticsType);
            StringBuilder GetIpsecVpnsessionStatisticsServiceURL = new StringBuilder("/vpn/ipsec/sessions/{session-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetIpsecVpnsessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetIpsecVpnsessionStatisticsServiceURL.ToString();
            IRestResponse<NSXTIPSecVPNSessionStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNSessionStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetIpsecVpnsessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            ResetIpsecVpnsessionStatisticsServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ResetIpsecVpnsessionStatisticsServiceURL.ToString();
            IRestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP POST operation to " + ResetIpsecVpnsessionStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTIPSecVPNSessionSummaryType> GetIpsecVpnsessionSummary(string? SiteId = null, string? Source = null)
        {
            NSXTIPSecVPNSessionSummaryType returnValue = default(NSXTIPSecVPNSessionSummaryType);
            StringBuilder GetIpsecVpnsessionSummaryServiceURL = new StringBuilder("/vpn/ipsec/sessions/summary");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            if (SiteId != null) { request.AddQueryParameter("site_id", SiteId.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetIpsecVpnsessionSummaryServiceURL.ToString();
            IRestResponse<NSXTIPSecVPNSessionSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNSessionSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetIpsecVpnsessionSummaryServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
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
            NSXTIPSecVPNSessionStatusType returnValue = default(NSXTIPSecVPNSessionStatusType);
            StringBuilder GetIpsecVpnikesessionStatusServiceURL = new StringBuilder("/vpn/ipsec/sessions/{session-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetIpsecVpnikesessionStatusServiceURL.Replace("{session-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetIpsecVpnikesessionStatusServiceURL.ToString();
            IRestResponse<NSXTIPSecVPNSessionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTIPSecVPNSessionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetIpsecVpnikesessionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
