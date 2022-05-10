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
    public class AggSvcL2Forwarder
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AggSvcL2Forwarder(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTL2ForwarderStatisticsType> GetL2ForwarderStatistics(string LogicalSwitchId)
        {
            if (LogicalSwitchId == null) { throw new System.ArgumentNullException("LogicalSwitchId cannot be null"); }
            StringBuilder GetL2ForwarderStatisticsServiceURL = new StringBuilder("/logical-switches/{logical-switch-id}/inter-site-forwarder/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2ForwarderStatisticsServiceURL.Replace("{logical-switch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalSwitchId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetL2ForwarderStatisticsServiceURL.ToString();
            RestResponse<NSXTL2ForwarderStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2ForwarderStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2ForwarderStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2ForwarderRemoteMacsType> GetL2ForwarderRemoteMacs(string LogicalSwitchId)
        {
            if (LogicalSwitchId == null) { throw new System.ArgumentNullException("LogicalSwitchId cannot be null"); }
            StringBuilder GetL2ForwarderRemoteMacsServiceURL = new StringBuilder("/logical-switches/{logical-switch-id}/inter-site-forwarder/site-span-info");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2ForwarderRemoteMacsServiceURL.Replace("{logical-switch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalSwitchId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetL2ForwarderRemoteMacsServiceURL.ToString();
            RestResponse<NSXTL2ForwarderRemoteMacsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2ForwarderRemoteMacsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2ForwarderRemoteMacsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTL2ForwarderStatusType> GetL2ForwarderStatus(string LogicalSwitchId, string? Source = null)
        {
            if (LogicalSwitchId == null) { throw new System.ArgumentNullException("LogicalSwitchId cannot be null"); }
            StringBuilder GetL2ForwarderStatusServiceURL = new StringBuilder("/logical-switches/{logical-switch-id}/inter-site-forwarder/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetL2ForwarderStatusServiceURL.Replace("{logical-switch-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LogicalSwitchId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetL2ForwarderStatusServiceURL.ToString();
            RestResponse<NSXTL2ForwarderStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTL2ForwarderStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetL2ForwarderStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
