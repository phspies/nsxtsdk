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
    public class AggSvcDhcp
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AggSvcDhcp(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTDhcpServerStatusType> GetDhcpStatus(string ServerId)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder GetDhcpStatusServiceURL = new StringBuilder("/dhcp/servers/{server-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDhcpStatusServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDhcpStatusServiceURL.ToString();
            RestResponse<NSXTDhcpServerStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpServerStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDhcpStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpStatisticsType> GetDhcpStatistics(string ServerId)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder GetDhcpStatisticsServiceURL = new StringBuilder("/dhcp/servers/{server-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDhcpStatisticsServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDhcpStatisticsServiceURL.ToString();
            RestResponse<NSXTDhcpStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDhcpStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDhcpLeasesType> GetDhcpLeaseInfo(string ServerId, string? Address = null, string? PoolId = null, string? Source = null)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            StringBuilder GetDhcpLeaseInfoServiceURL = new StringBuilder("/dhcp/servers/{server-id}/leases");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDhcpLeaseInfoServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Address != null) { request.AddQueryParameter("address", Address.ToString()); }
            if (PoolId != null) { request.AddQueryParameter("pool_id", PoolId.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetDhcpLeaseInfoServiceURL.ToString();
            RestResponse<NSXTDhcpLeasesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDhcpLeasesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDhcpLeaseInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteAdhcpLease(string ServerId, string Ip, string Mac)
        {
            if (ServerId == null) { throw new System.ArgumentNullException("ServerId cannot be null"); }
            if (Ip == null) { throw new System.ArgumentNullException("Ip cannot be null"); }
            if (Mac == null) { throw new System.ArgumentNullException("Mac cannot be null"); }
            StringBuilder DeleteAdhcpLeaseServiceURL = new StringBuilder("/dhcp/servers/{server-id}/leases");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteAdhcpLeaseServiceURL.Replace("{server-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ServerId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Ip != null) { request.AddQueryParameter("ip", Ip.ToString()); }
            if (Mac != null) { request.AddQueryParameter("mac", Mac.ToString()); }
            request.Resource = DeleteAdhcpLeaseServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteAdhcpLeaseServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
