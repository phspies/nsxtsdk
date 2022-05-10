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
    public class AggSvcDnsForwarder
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AggSvcDnsForwarder(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTDnsForwarderStatisticsType> GetDnsForwarderStatistics(string ForwarderId)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            StringBuilder GetDnsForwarderStatisticsServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDnsForwarderStatisticsServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDnsForwarderStatisticsServiceURL.ToString();
            RestResponse<NSXTDnsForwarderStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsForwarderStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDnsForwarderStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDnsForwarderStatusType> GetDnsForwarderStatus(string ForwarderId)
        {
            if (ForwarderId == null) { throw new System.ArgumentNullException("ForwarderId cannot be null"); }
            StringBuilder GetDnsForwarderStatusServiceURL = new StringBuilder("/dns/forwarders/{forwarder-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDnsForwarderStatusServiceURL.Replace("{forwarder-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ForwarderId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDnsForwarderStatusServiceURL.ToString();
            RestResponse<NSXTDnsForwarderStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDnsForwarderStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDnsForwarderStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
