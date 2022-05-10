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
    public class NodeNsxUpgradeAgent
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeNsxUpgradeAgent(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateNsxUpgradeAgentServiceActionRestart()
        {
            StringBuilder CreateNsxUpgradeAgentServiceActionRestartServiceURL = new StringBuilder("/node/services/nsx-upgrade-agent?action=restart");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateNsxUpgradeAgentServiceActionRestartServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateNsxUpgradeAgentServiceActionRestartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateNsxUpgradeAgentServiceActionStart()
        {
            StringBuilder CreateNsxUpgradeAgentServiceActionStartServiceURL = new StringBuilder("/node/services/nsx-upgrade-agent?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateNsxUpgradeAgentServiceActionStartServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateNsxUpgradeAgentServiceActionStartServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> ReadNsxUpgradeAgentServiceStatus()
        {
            StringBuilder ReadNsxUpgradeAgentServiceStatusServiceURL = new StringBuilder("/node/services/nsx-upgrade-agent/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadNsxUpgradeAgentServiceStatusServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNsxUpgradeAgentServiceStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServicePropertiesType> ReadNsxUpgradeAgentService()
        {
            StringBuilder ReadNsxUpgradeAgentServiceServiceURL = new StringBuilder("/node/services/nsx-upgrade-agent");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadNsxUpgradeAgentServiceServiceURL.ToString();
            RestResponse<NSXTNodeServicePropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServicePropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNsxUpgradeAgentServiceServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeServiceStatusPropertiesType> CreateNsxUpgradeAgentServiceActionStop()
        {
            StringBuilder CreateNsxUpgradeAgentServiceActionStopServiceURL = new StringBuilder("/node/services/nsx-upgrade-agent?action=stop");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateNsxUpgradeAgentServiceActionStopServiceURL.ToString();
            RestResponse<NSXTNodeServiceStatusPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeServiceStatusPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateNsxUpgradeAgentServiceActionStopServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
