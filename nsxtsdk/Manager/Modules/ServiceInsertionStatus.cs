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
    public class ServiceInsertionStatus
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ServiceInsertionStatus(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTServiceInsertionStatusListResultType> ListServiceInsertionStatus()
        {
            StringBuilder ListServiceInsertionStatusServiceURL = new StringBuilder("/serviceinsertion/status");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceInsertionStatusServiceURL.ToString();
            RestResponse<NSXTServiceInsertionStatusListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionStatusListResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceInsertionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionStatusType> UpdateServiceInsertionStatus(string ContextType, NSXTServiceInsertionStatusType ServiceInsertionStatus)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            if (ServiceInsertionStatus == null) { throw new System.ArgumentNullException("ServiceInsertionStatus cannot be null"); }
            StringBuilder UpdateServiceInsertionStatusServiceURL = new StringBuilder("/serviceinsertion/status/{context-type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            UpdateServiceInsertionStatusServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(ServiceInsertionStatus);
            request.Resource = UpdateServiceInsertionStatusServiceURL.ToString();
            RestResponse<NSXTServiceInsertionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + UpdateServiceInsertionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTServiceInsertionStatusType> GetServiceInsertionStatus(string ContextType)
        {
            if (ContextType == null) { throw new System.ArgumentNullException("ContextType cannot be null"); }
            StringBuilder GetServiceInsertionStatusServiceURL = new StringBuilder("/serviceinsertion/status/{context-type}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceInsertionStatusServiceURL.Replace("{context-type}", System.Uri.EscapeDataString(Helpers.ConvertToString(ContextType, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceInsertionStatusServiceURL.ToString();
            RestResponse<NSXTServiceInsertionStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTServiceInsertionStatusType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceInsertionStatusServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
