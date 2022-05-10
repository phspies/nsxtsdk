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
    public class ComputeCollectionDeployment
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ComputeCollectionDeployment(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task PerformActionOnComputeCollection(string CcExtId, string? Action = null)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            StringBuilder PerformActionOnComputeCollectionServiceURL = new StringBuilder("/fabric/compute-collections/{cc-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            PerformActionOnComputeCollectionServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Action != null) { request.AddQueryParameter("action", Action.ToString()); }
            request.Resource = PerformActionOnComputeCollectionServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + PerformActionOnComputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTComputeCollectionType> ReadComputeCollection(string CcExtId)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            StringBuilder ReadComputeCollectionServiceURL = new StringBuilder("/fabric/compute-collections/{cc-ext-id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ReadComputeCollectionServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ReadComputeCollectionServiceURL.ToString();
            RestResponse<NSXTComputeCollectionType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTComputeCollectionType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ReadComputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTHostNodeStatusListResultType> GetHostNodeStatusOnComputeCollection(string CcExtId)
        {
            if (CcExtId == null) { throw new System.ArgumentNullException("CcExtId cannot be null"); }
            StringBuilder GetHostNodeStatusOnComputeCollectionServiceURL = new StringBuilder("/fabric/compute-collections/{cc-ext-id}/member-status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetHostNodeStatusOnComputeCollectionServiceURL.Replace("{cc-ext-id}", System.Uri.EscapeDataString(Helpers.ConvertToString(CcExtId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetHostNodeStatusOnComputeCollectionServiceURL.ToString();
            RestResponse<NSXTHostNodeStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTHostNodeStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetHostNodeStatusOnComputeCollectionServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
