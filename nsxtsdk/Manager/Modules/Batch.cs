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
    public class Batch
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public Batch(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTBatchResponseType> RegisterBatchRequest(NSXTBatchRequestType BatchRequest, bool? Atomic = null)
        {
            if (BatchRequest == null) { throw new System.ArgumentNullException("BatchRequest cannot be null"); }
            StringBuilder RegisterBatchRequestServiceURL = new StringBuilder("/batch");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(BatchRequest);
            if (Atomic != null) { request.AddQueryParameter("atomic", Atomic.ToString()); }
            request.Resource = RegisterBatchRequestServiceURL.ToString();
            RestResponse<NSXTBatchResponseType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTBatchResponseType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + RegisterBatchRequestServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
