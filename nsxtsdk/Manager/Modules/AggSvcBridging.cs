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
    public class AggSvcBridging
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        int retry;
        int timeout;
        CancellationToken cancellationToken;
        public AggSvcBridging(RestClient Client, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken, int _timeout, int _retry)

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
        public async Task<NSXTBridgeEndpointStatusType> GetBridgeEndpointStatus(string EndpointId, string? Source = null)
        {
            if (EndpointId == null) { throw new System.ArgumentNullException("EndpointId cannot be null"); }
            NSXTBridgeEndpointStatusType returnValue = default(NSXTBridgeEndpointStatusType);
            StringBuilder GetBridgeEndpointStatusServiceURL = new StringBuilder("/bridge-endpoints/{endpoint-id}/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetBridgeEndpointStatusServiceURL.Replace("{endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetBridgeEndpointStatusServiceURL.ToString();
            IRestResponse<NSXTBridgeEndpointStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetBridgeEndpointStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTBridgeEndpointStatisticsType> GetBridgeEndpointStatistics(string EndpointId, string? Source = null)
        {
            if (EndpointId == null) { throw new System.ArgumentNullException("EndpointId cannot be null"); }
            NSXTBridgeEndpointStatisticsType returnValue = default(NSXTBridgeEndpointStatisticsType);
            StringBuilder GetBridgeEndpointStatisticsServiceURL = new StringBuilder("/bridge-endpoints/{endpoint-id}/statistics");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            GetBridgeEndpointStatisticsServiceURL.Replace("{endpoint-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EndpointId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = GetBridgeEndpointStatisticsServiceURL.ToString();
            IRestResponse<NSXTBridgeEndpointStatisticsType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBridgeEndpointStatisticsType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP GET operation to " + GetBridgeEndpointStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, null);
			}
            return response.Data;
        }
    }
}
