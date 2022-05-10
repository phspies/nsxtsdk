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
    public class Lldp
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Lldp(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTInterfaceNeighborPropertyListResultType> ListFabricNodeNeighborProperties(string FabricNodeId)
        {
            if (FabricNodeId == null) { throw new System.ArgumentNullException("FabricNodeId cannot be null"); }
            StringBuilder ListFabricNodeNeighborPropertiesServiceURL = new StringBuilder("/lldp/fabric-nodes/{fabric-node-id}/interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListFabricNodeNeighborPropertiesServiceURL.Replace("{fabric-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FabricNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListFabricNodeNeighborPropertiesServiceURL.ToString();
            RestResponse<NSXTInterfaceNeighborPropertyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceNeighborPropertyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListFabricNodeNeighborPropertiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceNeighborPropertiesType> ReadNeighborProperties(string NodeId, string InterfaceName)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            if (InterfaceName == null) { throw new System.ArgumentNullException("InterfaceName cannot be null"); }
            StringBuilder ReadNeighborPropertiesServiceURL = new StringBuilder("/lldp/transport-nodes/{node-id}/interfaces/{interface-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadNeighborPropertiesServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadNeighborPropertiesServiceURL.Replace("{interface-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadNeighborPropertiesServiceURL.ToString();
            RestResponse<NSXTInterfaceNeighborPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceNeighborPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNeighborPropertiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceNeighborPropertiesType> ReadFabricNodeNeighborProperties(string FabricNodeId, string InterfaceName)
        {
            if (FabricNodeId == null) { throw new System.ArgumentNullException("FabricNodeId cannot be null"); }
            if (InterfaceName == null) { throw new System.ArgumentNullException("InterfaceName cannot be null"); }
            StringBuilder ReadFabricNodeNeighborPropertiesServiceURL = new StringBuilder("/lldp/fabric-nodes/{fabric-node-id}/interfaces/{interface-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadFabricNodeNeighborPropertiesServiceURL.Replace("{fabric-node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(FabricNodeId, System.Globalization.CultureInfo.InvariantCulture)));
            ReadFabricNodeNeighborPropertiesServiceURL.Replace("{interface-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadFabricNodeNeighborPropertiesServiceURL.ToString();
            RestResponse<NSXTInterfaceNeighborPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceNeighborPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadFabricNodeNeighborPropertiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceNeighborPropertyListResultType> ListNeighborProperties(string NodeId)
        {
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ListNeighborPropertiesServiceURL = new StringBuilder("/lldp/transport-nodes/{node-id}/interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListNeighborPropertiesServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListNeighborPropertiesServiceURL.ToString();
            RestResponse<NSXTInterfaceNeighborPropertyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceNeighborPropertyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListNeighborPropertiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
