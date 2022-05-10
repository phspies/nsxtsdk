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
    public class AggSvcMetadataProxy
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AggSvcMetadataProxy(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTMetadataProxyStatusType> GetMetadataProxyStatus(string ProxyId, string LogicalSwitchId)
        {
            if (ProxyId == null) { throw new System.ArgumentNullException("ProxyId cannot be null"); }
            if (LogicalSwitchId == null) { throw new System.ArgumentNullException("LogicalSwitchId cannot be null"); }
            StringBuilder GetMetadataProxyStatusServiceURL = new StringBuilder("/md-proxies/{proxy-id}/{logical-switch-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetMetadataProxyStatusServiceURL.Replace("{proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            GetMetadataProxyStatusServiceURL.Replace("{logical-switch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalSwitchId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetMetadataProxyStatusServiceURL.ToString();
            RestResponse<NSXTMetadataProxyStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMetadataProxyStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMetadataProxyStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTMetadataProxyStatisticsType> GetMetadataProxyStatistics(string ProxyId, string? LogicalSwitchId = null, string? Source = null)
        {
            if (ProxyId == null) { throw new System.ArgumentNullException("ProxyId cannot be null"); }
            StringBuilder GetMetadataProxyStatisticsServiceURL = new StringBuilder("/md-proxies/{proxy-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetMetadataProxyStatisticsServiceURL.Replace("{proxy-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ProxyId, System.Globalization.CultureInfo.InvariantCulture)));
            if (LogicalSwitchId != null) { request.AddQueryParameter("logical_switch_id", LogicalSwitchId.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetMetadataProxyStatisticsServiceURL.ToString();
            RestResponse<NSXTMetadataProxyStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTMetadataProxyStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetMetadataProxyStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
