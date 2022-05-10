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
    public class NodeSupportBundle
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NodeSupportBundle(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTSupportBundleResultType> CollectSupportBundlesCollect(NSXTSupportBundleRequestType SupportBundleRequest, bool? OverrideAsyncResponse = null, bool? RequireDeleteOrOverrideAsyncResponse = null)
        {
            if (SupportBundleRequest == null) { throw new System.ArgumentNullException("SupportBundleRequest cannot be null"); }
            StringBuilder CollectSupportBundlesCollectServiceURL = new StringBuilder("/administration/support-bundles?action=collect");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(SupportBundleRequest);
            if (OverrideAsyncResponse != null) { request.AddQueryParameter("override_async_response", OverrideAsyncResponse.ToString()); }
            if (RequireDeleteOrOverrideAsyncResponse != null) { request.AddQueryParameter("require_delete_or_override_async_response", RequireDeleteOrOverrideAsyncResponse.ToString()); }
            request.Resource = CollectSupportBundlesCollectServiceURL.ToString();
            RestResponse<NSXTSupportBundleResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSupportBundleResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CollectSupportBundlesCollectServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task DeleteSupportBundlesAsyncResponseDeleteAsyncResponse()
        {
            StringBuilder DeleteSupportBundlesAsyncResponseDeleteAsyncResponseServiceURL = new StringBuilder("/administration/support-bundles?action=delete_async_response");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = DeleteSupportBundlesAsyncResponseDeleteAsyncResponseServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeleteSupportBundlesAsyncResponseDeleteAsyncResponseServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTDynamicContentFiltersType> GetDynamicContentFilterValues(string? Scope = null)
        {
            StringBuilder GetDynamicContentFilterValuesServiceURL = new StringBuilder("/administration/support-bundles/dynamic-content-filters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Scope != null) { request.AddQueryParameter("scope", Scope.ToString()); }
            request.Resource = GetDynamicContentFilterValuesServiceURL.ToString();
            RestResponse<NSXTDynamicContentFiltersType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTDynamicContentFiltersType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetDynamicContentFilterValuesServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
