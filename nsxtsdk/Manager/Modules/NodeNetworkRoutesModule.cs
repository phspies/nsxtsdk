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
    public class NodeNetworkRoutesModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeNetworkRoutesModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeRoutePropertiesType> ReadNodeNetworkRoute(string RouteId)
        {
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            StringBuilder ReadNodeNetworkRouteServiceURL = new StringBuilder("/node/network/routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNodeNetworkRouteServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNodeNetworkRouteServiceURL.ToString();
            RestResponse<NSXTNodeRoutePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeRoutePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNodeNetworkRouteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteNodeNetworkRoute(string RouteId)
        {
            if (RouteId == null) { throw new System.ArgumentNullException("RouteId cannot be null"); }
            StringBuilder DeleteNodeNetworkRouteServiceURL = new StringBuilder("/node/network/routes/{route-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteNodeNetworkRouteServiceURL.Replace("{route-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(RouteId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteNodeNetworkRouteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteNodeNetworkRouteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeRoutePropertiesType> CreateNodeNetworkRoute(NSXTNodeRoutePropertiesType NodeRouteProperties)
        {
            if (NodeRouteProperties == null) { throw new System.ArgumentNullException("NodeRouteProperties cannot be null"); }
            StringBuilder CreateNodeNetworkRouteServiceURL = new StringBuilder("/node/network/routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(NodeRouteProperties);
            request.Resource = CreateNodeNetworkRouteServiceURL.ToString();
            RestResponse<NSXTNodeRoutePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeRoutePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateNodeNetworkRouteServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeRoutePropertiesListResultType> ListNodeNetworkRoutes()
        {
            StringBuilder ListNodeNetworkRoutesServiceURL = new StringBuilder("/node/network/routes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListNodeNetworkRoutesServiceURL.ToString();
            RestResponse<NSXTNodeRoutePropertiesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeRoutePropertiesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNodeNetworkRoutesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
