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
    public class NodeNetworkDnsModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeNetworkDnsModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeNameServersPropertiesType> UpdateNodeNameServers(NSXTNodeNameServersPropertiesType NodeNameServersProperties)
        {
            if (NodeNameServersProperties == null) { throw new System.ArgumentNullException("NodeNameServersProperties cannot be null"); }
            StringBuilder UpdateNodeNameServersServiceURL = new StringBuilder("/node/network/name-servers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(NodeNameServersProperties);
            request.Resource = UpdateNodeNameServersServiceURL.ToString();
            RestResponse<NSXTNodeNameServersPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeNameServersPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNodeNameServersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeNameServersPropertiesType> ReadNodeNameServers()
        {
            StringBuilder ReadNodeNameServersServiceURL = new StringBuilder("/node/network/name-servers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadNodeNameServersServiceURL.ToString();
            RestResponse<NSXTNodeNameServersPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeNameServersPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNodeNameServersServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeSearchDomainsPropertiesType> UpdateNodeSearchDomains(NSXTNodeSearchDomainsPropertiesType NodeSearchDomainsProperties)
        {
            if (NodeSearchDomainsProperties == null) { throw new System.ArgumentNullException("NodeSearchDomainsProperties cannot be null"); }
            StringBuilder UpdateNodeSearchDomainsServiceURL = new StringBuilder("/node/network/search-domains");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(NodeSearchDomainsProperties);
            request.Resource = UpdateNodeSearchDomainsServiceURL.ToString();
            RestResponse<NSXTNodeSearchDomainsPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeSearchDomainsPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateNodeSearchDomainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeSearchDomainsPropertiesType> ReadNodeSearchDomains()
        {
            StringBuilder ReadNodeSearchDomainsServiceURL = new StringBuilder("/node/network/search-domains");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadNodeSearchDomainsServiceURL.ToString();
            RestResponse<NSXTNodeSearchDomainsPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeSearchDomainsPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadNodeSearchDomainsServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
