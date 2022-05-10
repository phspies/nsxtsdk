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
    public class PortConnection
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PortConnection(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTPortConnectionEntitiesType> GetForwardingPath(string LportId, string PeerPortId)
        {
            if (LportId == null) { throw new System.ArgumentNullException("LportId cannot be null"); }
            if (PeerPortId == null) { throw new System.ArgumentNullException("PeerPortId cannot be null"); }
            StringBuilder GetForwardingPathServiceURL = new StringBuilder("/logical-ports/{lport-id}/forwarding-path");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetForwardingPathServiceURL.Replace("{lport-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LportId, System.Globalization.CultureInfo.InvariantCulture)));
            if (PeerPortId != null) { request.AddQueryParameter("peer_port_id", PeerPortId.ToString()); }
            request.Resource = GetForwardingPathServiceURL.ToString();
            RestResponse<NSXTPortConnectionEntitiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTPortConnectionEntitiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetForwardingPathServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
