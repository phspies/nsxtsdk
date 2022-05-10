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
    public class RealizationStateBarrier
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public RealizationStateBarrier(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTCurrentRealizationStateBarrierType> GetCurrentBarrier()
        {
            StringBuilder GetCurrentBarrierServiceURL = new StringBuilder("/realization-state-barrier/current");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetCurrentBarrierServiceURL.ToString();
            RestResponse<NSXTCurrentRealizationStateBarrierType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCurrentRealizationStateBarrierType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetCurrentBarrierServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTCurrentRealizationStateBarrierType> IncrementRealizationStateBarrier()
        {
            StringBuilder IncrementRealizationStateBarrierServiceURL = new StringBuilder("/realization-state-barrier/current?action=increment");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = IncrementRealizationStateBarrierServiceURL.ToString();
            RestResponse<NSXTCurrentRealizationStateBarrierType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTCurrentRealizationStateBarrierType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + IncrementRealizationStateBarrierServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRealizationStateBarrierConfigType> UpdateRealizationStateBarrierConfig(NSXTRealizationStateBarrierConfigType RealizationStateBarrierConfig)
        {
            if (RealizationStateBarrierConfig == null) { throw new System.ArgumentNullException("RealizationStateBarrierConfig cannot be null"); }
            StringBuilder UpdateRealizationStateBarrierConfigServiceURL = new StringBuilder("/realization-state-barrier/config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(RealizationStateBarrierConfig);
            request.Resource = UpdateRealizationStateBarrierConfigServiceURL.ToString();
            RestResponse<NSXTRealizationStateBarrierConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRealizationStateBarrierConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateRealizationStateBarrierConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTRealizationStateBarrierConfigType> GetRealizationStateBarrierConfig()
        {
            StringBuilder GetRealizationStateBarrierConfigServiceURL = new StringBuilder("/realization-state-barrier/config");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetRealizationStateBarrierConfigServiceURL.ToString();
            RestResponse<NSXTRealizationStateBarrierConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTRealizationStateBarrierConfigType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetRealizationStateBarrierConfigServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
