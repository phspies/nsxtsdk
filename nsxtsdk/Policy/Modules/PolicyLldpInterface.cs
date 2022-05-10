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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class PolicyLldpInterface
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicyLldpInterface(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTInterfaceNeighborPropertiesType> ShowLldpNeighborInterfaces(string SiteId, string EnforcementPointId, string NodeId, string InterfaceName)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            if (InterfaceName == null) { throw new System.ArgumentNullException("InterfaceName cannot be null"); }
            StringBuilder ShowLldpNeighborInterfacesServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/host-transport-nodes/{node-id}/lldp/interfaces/{interface-name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ShowLldpNeighborInterfacesServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ShowLldpNeighborInterfacesServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            ShowLldpNeighborInterfacesServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            ShowLldpNeighborInterfacesServiceURL.Replace("{interface-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ShowLldpNeighborInterfacesServiceURL.ToString();
            RestResponse<NSXTInterfaceNeighborPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceNeighborPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ShowLldpNeighborInterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTInterfaceNeighborPropertyListResultType> ListAllLldpNeighborInterfaces(string SiteId, string EnforcementPointId, string NodeId)
        {
            if (SiteId == null) { throw new System.ArgumentNullException("SiteId cannot be null"); }
            if (EnforcementPointId == null) { throw new System.ArgumentNullException("EnforcementPointId cannot be null"); }
            if (NodeId == null) { throw new System.ArgumentNullException("NodeId cannot be null"); }
            StringBuilder ListAllLldpNeighborInterfacesServiceURL = new StringBuilder("/infra/sites/{site-id}/enforcement-points/{enforcement-point-id}/host-transport-nodes/{node-id}/lldp/interfaces");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListAllLldpNeighborInterfacesServiceURL.Replace("{site-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SiteId, System.Globalization.CultureInfo.InvariantCulture)));
            ListAllLldpNeighborInterfacesServiceURL.Replace("{enforcement-point-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(EnforcementPointId, System.Globalization.CultureInfo.InvariantCulture)));
            ListAllLldpNeighborInterfacesServiceURL.Replace("{node-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(NodeId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListAllLldpNeighborInterfacesServiceURL.ToString();
            RestResponse<NSXTInterfaceNeighborPropertyListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTInterfaceNeighborPropertyListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListAllLldpNeighborInterfacesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
