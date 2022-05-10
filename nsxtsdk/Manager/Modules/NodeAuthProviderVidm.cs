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
    public class NodeAuthProviderVidm
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeAuthProviderVidm(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTNodeAuthProviderVidmPropertiesType> UpdateAuthProviderVidm(NSXTNodeAuthProviderVidmPropertiesType NodeAuthProviderVidmProperties)
        {
            if (NodeAuthProviderVidmProperties == null) { throw new System.ArgumentNullException("NodeAuthProviderVidmProperties cannot be null"); }
            StringBuilder UpdateAuthProviderVidmServiceURL = new StringBuilder("/node/aaa/providers/vidm");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(NodeAuthProviderVidmProperties);
            request.Resource = UpdateAuthProviderVidmServiceURL.ToString();
            RestResponse<NSXTNodeAuthProviderVidmPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeAuthProviderVidmPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateAuthProviderVidmServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeAuthProviderVidmPropertiesType> ReadAuthProviderVidm()
        {
            StringBuilder ReadAuthProviderVidmServiceURL = new StringBuilder("/node/aaa/providers/vidm");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadAuthProviderVidmServiceURL.ToString();
            RestResponse<NSXTNodeAuthProviderVidmPropertiesType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeAuthProviderVidmPropertiesType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAuthProviderVidmServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTNodeAuthProviderVidmStatusType> ReadAuthProviderVidmStatus()
        {
            StringBuilder ReadAuthProviderVidmStatusServiceURL = new StringBuilder("/node/aaa/providers/vidm/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ReadAuthProviderVidmStatusServiceURL.ToString();
            RestResponse<NSXTNodeAuthProviderVidmStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTNodeAuthProviderVidmStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadAuthProviderVidmStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
