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
using nsxtsdk.PolicyModels;

namespace nsxtapi.PolicyModules
{
    public class ErrorResolver
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ErrorResolver(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTErrorResolverInfoType> GetErrorResolverInfo(string ErrorId)
        {
            if (ErrorId == null) { throw new System.ArgumentNullException("ErrorId cannot be null"); }
            StringBuilder GetErrorResolverInfoServiceURL = new StringBuilder("/error-resolver/{error_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetErrorResolverInfoServiceURL.Replace("{error_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ErrorId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetErrorResolverInfoServiceURL.ToString();
            RestResponse<NSXTErrorResolverInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTErrorResolverInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetErrorResolverInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTErrorResolverInfoListType> ListErrorResolverInfo()
        {
            StringBuilder ListErrorResolverInfoServiceURL = new StringBuilder("/error-resolver");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListErrorResolverInfoServiceURL.ToString();
            RestResponse<NSXTErrorResolverInfoListType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTErrorResolverInfoListType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListErrorResolverInfoServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task ResolveError(NSXTErrorResolverMetadataListType ErrorResolverMetadataList)
        {
            if (ErrorResolverMetadataList == null) { throw new System.ArgumentNullException("ErrorResolverMetadataList cannot be null"); }
            StringBuilder ResolveErrorServiceURL = new StringBuilder("/error-resolver?action=resolve_error");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(ErrorResolverMetadataList);
            request.Resource = ResolveErrorServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ResolveErrorServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
