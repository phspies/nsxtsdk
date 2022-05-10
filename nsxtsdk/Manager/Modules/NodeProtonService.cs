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
    public class NodeProtonService
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeProtonService(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateProtonServiceActionRestart()
        {
            StringBuilder CreateProtonServiceActionRestartServiceURL = new StringBuilder("/node/services/manager?action=restart");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateProtonServiceActionRestartServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateProtonServiceActionRestartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeProtonServicePropertiesType> UpdateProtonService(NSXTNodeProtonServicePropertiesType NodeProtonServiceProperties)
        {
            if (NodeProtonServiceProperties == null) { throw new System.ArgumentNullException("NodeProtonServiceProperties cannot be null"); }
            StringBuilder UpdateProtonServiceServiceURL = new StringBuilder("/node/services/manager");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(NodeProtonServiceProperties);
            request.Resource = UpdateProtonServiceServiceURL.ToString();
            RestResponse<NSXTNodeProtonServicePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeProtonServicePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateProtonServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeProtonServicePropertiesType> ReadProtonService()
        {
            StringBuilder ReadProtonServiceServiceURL = new StringBuilder("/node/services/manager");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadProtonServiceServiceURL.ToString();
            RestResponse<NSXTNodeProtonServicePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeProtonServicePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadProtonServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateProtonServiceActionStart()
        {
            StringBuilder CreateProtonServiceActionStartServiceURL = new StringBuilder("/node/services/manager?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateProtonServiceActionStartServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateProtonServiceActionStartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateProtonServiceActionStop()
        {
            StringBuilder CreateProtonServiceActionStopServiceURL = new StringBuilder("/node/services/manager?action=stop");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateProtonServiceActionStopServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateProtonServiceActionStopServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResetProtonServiceLoggingLevelActionResetManagerLoggingLevels()
        {
            StringBuilder ResetProtonServiceLoggingLevelActionResetManagerLoggingLevelsServiceURL = new StringBuilder("/node/services/manager?action=reset-manager-logging-levels");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = ResetProtonServiceLoggingLevelActionResetManagerLoggingLevelsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResetProtonServiceLoggingLevelActionResetManagerLoggingLevelsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> ReadProtonServiceStatus()
        {
            StringBuilder ReadProtonServiceStatusServiceURL = new StringBuilder("/node/services/manager/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadProtonServiceStatusServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadProtonServiceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
