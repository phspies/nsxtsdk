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
    public class NodeStatus
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeStatus(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeStatusPropertiesType> UpdateApplianceNodeStatusClearBootupError()
        {
            StringBuilder UpdateApplianceNodeStatusClearBootupErrorServiceURL = new StringBuilder("/node/status?action=clear_bootup_error");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = UpdateApplianceNodeStatusClearBootupErrorServiceURL.ToString();
            RestResponse<NSXTNodeStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + UpdateApplianceNodeStatusClearBootupErrorServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeStatusPropertiesType> ReadApplianceNodeStatus()
        {
            StringBuilder ReadApplianceNodeStatusServiceURL = new StringBuilder("/node/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadApplianceNodeStatusServiceURL.ToString();
            RestResponse<NSXTNodeStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadApplianceNodeStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
