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
    public class TransportNode
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TransportNode(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task UpdateTransportNodeMaintenanceMode(string TransportnodeId, string? Action = null)
        {
            if (TransportnodeId == null) { throw new System.ArgumentNullException("TransportnodeId cannot be null"); }
            StringBuilder UpdateTransportNodeMaintenanceModeServiceURL = new StringBuilder("/transport-nodes/{transportnode-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            UpdateTransportNodeMaintenanceModeServiceURL.Replace("{transportnode-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TransportnodeId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = UpdateTransportNodeMaintenanceModeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UpdateTransportNodeMaintenanceModeServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
