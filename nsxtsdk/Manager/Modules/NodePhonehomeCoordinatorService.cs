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
    public class NodePhonehomeCoordinatorService
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodePhonehomeCoordinatorService(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeServiceStatusPropertiesType> CreatePhonehomeCoordinatorServiceActionStop()
        {
            StringBuilder CreatePhonehomeCoordinatorServiceActionStopServiceURL = new StringBuilder("/node/services/telemetry?action=stop");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreatePhonehomeCoordinatorServiceActionStopServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreatePhonehomeCoordinatorServiceActionStopServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> ReadPhonehomeCoordinatorServiceStatus()
        {
            StringBuilder ReadPhonehomeCoordinatorServiceStatusServiceURL = new StringBuilder("/node/services/telemetry/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadPhonehomeCoordinatorServiceStatusServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPhonehomeCoordinatorServiceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServicePropertiesType> ReadPhonehomeCoordinatorService()
        {
            StringBuilder ReadPhonehomeCoordinatorServiceServiceURL = new StringBuilder("/node/services/telemetry");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadPhonehomeCoordinatorServiceServiceURL.ToString();
            RestResponse<NSXTNodeServicePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServicePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadPhonehomeCoordinatorServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> CreatePhonehomeCoordinatorServiceActionStart()
        {
            StringBuilder CreatePhonehomeCoordinatorServiceActionStartServiceURL = new StringBuilder("/node/services/telemetry?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreatePhonehomeCoordinatorServiceActionStartServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreatePhonehomeCoordinatorServiceActionStartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> CreatePhonehomeCoordinatorServiceActionRestart()
        {
            StringBuilder CreatePhonehomeCoordinatorServiceActionRestartServiceURL = new StringBuilder("/node/services/telemetry?action=restart");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreatePhonehomeCoordinatorServiceActionRestartServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreatePhonehomeCoordinatorServiceActionRestartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
