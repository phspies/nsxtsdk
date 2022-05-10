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
    public class PolicySitesSpan
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public PolicySitesSpan(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
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
        public async Task<NSXTSpanType> GetSpan(string IntentPath, string? SitePath = null)
        {
            if (IntentPath == null) { throw new System.ArgumentNullException("IntentPath cannot be null"); }
            StringBuilder GetSpanServiceURL = new StringBuilder("/infra/span");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (IntentPath != null) { request.AddQueryParameter("intent_path", IntentPath.ToString()); }
            if (SitePath != null) { request.AddQueryParameter("site_path", SitePath.ToString()); }
            request.Resource = GetSpanServiceURL.ToString();
            RestResponse<NSXTSpanType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSpanType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetSpanServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public async Task<NSXTSpanType> GlobalGlobalInfraGetSpan(string IntentPath, string? SitePath = null)
        {
            if (IntentPath == null) { throw new System.ArgumentNullException("IntentPath cannot be null"); }
            StringBuilder GlobalInfraGetSpanServiceURL = new StringBuilder("/global-infra/span");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (IntentPath != null) { request.AddQueryParameter("intent_path", IntentPath.ToString()); }
            if (SitePath != null) { request.AddQueryParameter("site_path", SitePath.ToString()); }
            request.Resource = GlobalInfraGetSpanServiceURL.ToString();
            RestResponse<NSXTSpanType> response = await restClient.ExecuteTaskAsyncWithPolicy<NSXTSpanType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GlobalInfraGetSpanServiceURL.ToString() + " did not complete successfull";
                throw new NSXTException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
