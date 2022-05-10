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
    public class NodeNetworkModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeNetworkModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeNetworkPropertiesType> ReadNetworkProperties()
        {
            StringBuilder ReadNetworkPropertiesServiceURL = new StringBuilder("/node/network");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadNetworkPropertiesServiceURL.ToString();
            RestResponse<NSXTNodeNetworkPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeNetworkPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNetworkPropertiesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
