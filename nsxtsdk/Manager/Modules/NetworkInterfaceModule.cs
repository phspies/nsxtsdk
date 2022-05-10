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
    public class NetworkInterfaceModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NetworkInterfaceModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeNetworkInterfacePropertiesType> UpdateNodeInterface(string InterfaceId, NSXTNodeNetworkInterfacePropertiesType NodeNetworkInterfaceProperties)
        {
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            if (NodeNetworkInterfaceProperties == null) { throw new System.ArgumentNullException("NodeNetworkInterfaceProperties cannot be null"); }
            StringBuilder UpdateNodeInterfaceServiceURL = new StringBuilder("/node/network/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateNodeInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(NodeNetworkInterfaceProperties);
            request.Resource = UpdateNodeInterfaceServiceURL.ToString();
            RestResponse<NSXTNodeNetworkInterfacePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeNetworkInterfacePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNodeInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeNetworkInterfacePropertiesType> ReadNodeInterface(string InterfaceId)
        {
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder ReadNodeInterfaceServiceURL = new StringBuilder("/node/network/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNodeInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNodeInterfaceServiceURL.ToString();
            RestResponse<NSXTNodeNetworkInterfacePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeNetworkInterfacePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNodeInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeNetworkInterfacePropertiesListResultType> ListNodeInterfaces()
        {
            StringBuilder ListNodeInterfacesServiceURL = new StringBuilder("/node/network/interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListNodeInterfacesServiceURL.ToString();
            RestResponse<NSXTNodeNetworkInterfacePropertiesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeNetworkInterfacePropertiesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNodeInterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeInterfaceStatisticsPropertiesType> ReadNetworkInterfaceStatistics(string InterfaceId)
        {
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder ReadNetworkInterfaceStatisticsServiceURL = new StringBuilder("/node/network/interfaces/{interface-id}/stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNetworkInterfaceStatisticsServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNetworkInterfaceStatisticsServiceURL.ToString();
            RestResponse<NSXTNodeInterfaceStatisticsPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeInterfaceStatisticsPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNetworkInterfaceStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
