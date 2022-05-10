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
    public class ApplianceStats
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ApplianceStats(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeInterfacePropertiesListResultType> ListClusterNodeInterfaces(string NodeId, string? Source = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ListClusterNodeInterfacesServiceURL = new StringBuilder("/cluster/nodes/{node-id}/network/interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListClusterNodeInterfacesServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ListClusterNodeInterfacesServiceURL.ToString();
            RestResponse<NSXTNodeInterfacePropertiesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeInterfacePropertiesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListClusterNodeInterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeInterfaceStatisticsPropertiesType> ReadClusterNodeInterfaceStatistics(string NodeId, string InterfaceId, string? Source = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder ReadClusterNodeInterfaceStatisticsServiceURL = new StringBuilder("/cluster/nodes/{node-id}/network/interfaces/{interface-id}/stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadClusterNodeInterfaceStatisticsServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadClusterNodeInterfaceStatisticsServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ReadClusterNodeInterfaceStatisticsServiceURL.ToString();
            RestResponse<NSXTNodeInterfaceStatisticsPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeInterfaceStatisticsPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadClusterNodeInterfaceStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeInterfacePropertiesType> ReadTransportNodeInterface(string TransportNodeId, string InterfaceId, string? Source = null)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder ReadTransportNodeInterfaceServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}/network/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTransportNodeInterfaceServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTransportNodeInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ReadTransportNodeInterfaceServiceURL.ToString();
            RestResponse<NSXTNodeInterfacePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeInterfacePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTransportNodeInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeInterfacePropertiesListResultType> ListFabricNodeInterfaces(string NodeId, string? AdminStatus = null, string? Source = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ListFabricNodeInterfacesServiceURL = new StringBuilder("/fabric/nodes/{node-id}/network/interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListFabricNodeInterfacesServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (AdminStatus != null) { request.AddQueryParameter("admin_status", AdminStatus.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ListFabricNodeInterfacesServiceURL.ToString();
            RestResponse<NSXTNodeInterfacePropertiesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeInterfacePropertiesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFabricNodeInterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeInterfacePropertiesType> ReadClusterNodeInterface(string NodeId, string InterfaceId, string? Source = null)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder ReadClusterNodeInterfaceServiceURL = new StringBuilder("/cluster/nodes/{node-id}/network/interfaces/{interface-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadClusterNodeInterfaceServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadClusterNodeInterfaceServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ReadClusterNodeInterfaceServiceURL.ToString();
            RestResponse<NSXTNodeInterfacePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeInterfacePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadClusterNodeInterfaceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeInterfacePropertiesListResultType> ListTransportNodeInterfaces(string TransportNodeId, string? AdminStatus = null, string? Source = null)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            StringBuilder ListTransportNodeInterfacesServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}/network/interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListTransportNodeInterfacesServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (AdminStatus != null) { request.AddQueryParameter("admin_status", AdminStatus.ToString()); }
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ListTransportNodeInterfacesServiceURL.ToString();
            RestResponse<NSXTNodeInterfacePropertiesListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeInterfacePropertiesListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListTransportNodeInterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeInterfaceStatisticsPropertiesType> ReadTransportNodeInterfaceStatistics(string TransportNodeId, string InterfaceId, string? Source = null)
        {
            if (TransportNodeId == null) { throw new System.ArgumentNullException("TransportNodeId cannot be null"); }
            if (InterfaceId == null) { throw new System.ArgumentNullException("InterfaceId cannot be null"); }
            StringBuilder ReadTransportNodeInterfaceStatisticsServiceURL = new StringBuilder("/transport-nodes/{transport-node-id}/network/interfaces/{interface-id}/stats");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadTransportNodeInterfaceStatisticsServiceURL.Replace("{transport-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadTransportNodeInterfaceStatisticsServiceURL.Replace("{interface-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Source != null) { request.AddQueryParameter("source", Source.ToString()); }
            request.Resource = ReadTransportNodeInterfaceStatisticsServiceURL.ToString();
            RestResponse<NSXTNodeInterfaceStatisticsPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeInterfaceStatisticsPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadTransportNodeInterfaceStatisticsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
