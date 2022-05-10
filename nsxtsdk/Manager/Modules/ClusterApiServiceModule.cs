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
    public class ClusterApiServiceModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ClusterApiServiceModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTApiServiceConfigType> UpdateApiServiceConfig(NSXTApiServiceConfigType ApiServiceConfig)
        {
            if (ApiServiceConfig == null) { throw new System.ArgumentNullException("ApiServiceConfig cannot be null"); }
            StringBuilder UpdateApiServiceConfigServiceURL = new StringBuilder("/cluster/api-service");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(ApiServiceConfig);
            request.Resource = UpdateApiServiceConfigServiceURL.ToString();
            RestResponse<NSXTApiServiceConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTApiServiceConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateApiServiceConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTApiServiceConfigType> GetApiServiceConfig()
        {
            StringBuilder GetApiServiceConfigServiceURL = new StringBuilder("/cluster/api-service");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetApiServiceConfigServiceURL.ToString();
            RestResponse<NSXTApiServiceConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTApiServiceConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetApiServiceConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
