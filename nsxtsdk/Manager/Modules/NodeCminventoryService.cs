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
    public class NodeCminventoryService
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeCminventoryService(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateCminventoryServiceActionStop()
        {
            StringBuilder CreateCminventoryServiceActionStopServiceURL = new StringBuilder("/node/services/cm-inventory?action=stop");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateCminventoryServiceActionStopServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateCminventoryServiceActionStopServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> ReadCminventoryServiceStatus()
        {
            StringBuilder ReadCminventoryServiceStatusServiceURL = new StringBuilder("/node/services/cm-inventory/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadCminventoryServiceStatusServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadCminventoryServiceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServicePropertiesType> ReadCminventoryService()
        {
            StringBuilder ReadCminventoryServiceServiceURL = new StringBuilder("/node/services/cm-inventory");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadCminventoryServiceServiceURL.ToString();
            RestResponse<NSXTNodeServicePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServicePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadCminventoryServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateCminventoryServiceActionRestart()
        {
            StringBuilder CreateCminventoryServiceActionRestartServiceURL = new StringBuilder("/node/services/cm-inventory?action=restart");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateCminventoryServiceActionRestartServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateCminventoryServiceActionRestartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateCminventoryServiceActionStart()
        {
            StringBuilder CreateCminventoryServiceActionStartServiceURL = new StringBuilder("/node/services/cm-inventory?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateCminventoryServiceActionStartServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateCminventoryServiceActionStartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
